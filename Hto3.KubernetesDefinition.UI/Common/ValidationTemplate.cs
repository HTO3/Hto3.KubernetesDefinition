using FluentValidation;
using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;

namespace Hto3.KubernetesDefinition.UI.Common
{
    /// <summary>
    /// This Validation Template should work like a partial class on every ViewModel class, providing a validation logic.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ValidationTemplate<T> : IDataErrorInfo, INotifyDataErrorInfo where T : INotifyPropertyChanged
    {
        private T target;
        private IValidator validator;
        private ValidationResult validationResult;
        private static ConcurrentDictionary<RuntimeTypeHandle, IValidator> validators = new ConcurrentDictionary<RuntimeTypeHandle, IValidator>();

        public ValidationTemplate(T target)
        {
            this.target = target;
            this.validator = this.GetValidator(target.GetType());
            this.target.PropertyChanged += this.Validate;
        }

        private IValidator GetValidator(Type modelType)
        {
            if (!validators.TryGetValue(modelType.TypeHandle, out var validator))
            {
                var typeName = String.Format("{0}.{1}Validator", modelType.Namespace.Replace("ViewModels", "ObjectValidation"), modelType.Name.Replace("ViewModel", String.Empty));
                var type = modelType.Assembly.GetTypes().SingleOrDefault(t => t.FullName == typeName);

                if (type == null)
                    return null;

                validators[modelType.TypeHandle] = validator = (IValidator)Activator.CreateInstance(type);
            }
            return validator;
        }

        private void Validate(Object sender, PropertyChangedEventArgs e)
        {
            var ignitionControl = target as IValidationIgnition;

            if (ignitionControl != null && !ignitionControl.ValidationEnabled)
                return;

            validationResult = validator?.Validate(new ValidationContext<T>(target));

            if (validationResult == null)
                return;

            foreach (var error in validationResult.Errors)
                RaiseErrorsChanged(error.PropertyName);
        }

        public IEnumerable GetErrors(String propertyName)
        {
            return
                validationResult.Errors
                    .Where(x => x.PropertyName == propertyName)
                    .Select(x => x.ErrorMessage);
        }

        public Boolean HasErrors => this.validationResult?.IsValid == false;

        public String Error
        {
            get
            {
                var strings = validationResult.Errors
                    .Select(x => x.ErrorMessage);

                return String.Join(Environment.NewLine, strings);
            }
        }

        public String this[String propertyName]
        {
            get
            {
                var strings = validationResult.Errors
                    .Where(x => x.PropertyName == propertyName)
                    .Select(x => x.ErrorMessage);

                return String.Join(Environment.NewLine, strings);
            }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private void RaiseErrorsChanged(String propertyName)
        {
            this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
