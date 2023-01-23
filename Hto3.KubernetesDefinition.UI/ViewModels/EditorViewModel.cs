using FluentValidation;
using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Messages;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validar;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    [InjectValidation]
    public abstract class EditorViewModel : MvxViewModel<Object>, IValidationIgnition
    {
        protected Object kubernetesDataObject;
        protected readonly IMvxNavigationService navigationService;
        protected readonly IViewModelMapper viewModelMapper;
        protected readonly IMvxMessenger messenger;
        private readonly MvxSubscriptionToken kubernetesObjectChangingSubscriptionToken;
        private readonly MvxSubscriptionToken queryFromExistingEditorSubscriptionToken;

        public EditorViewModel(IMvxNavigationService navigationService, IViewModelMapper viewModelMapper, IMvxMessenger messenger)
        {
            this.navigationService = navigationService;
            this.viewModelMapper = viewModelMapper;
            this.messenger = messenger;
            this.kubernetesObjectChangingSubscriptionToken = messenger.Subscribe<KubernetesObjectChangingMessage>(KubernetesObjectChangingMessage_Subscription);
            this.queryFromExistingEditorSubscriptionToken = messenger.Subscribe<QueryFromExistingEditorMessage>(QueryFromExistingEditorMessage_Subscription);
        }

        public Action ActivateEditorView { get; set; }
        public Boolean ValidationEnabled { get; set; }
        public Action<String> ShowWaningDialog { get; set; }

        public MvxCommand OkCommand => new MvxCommand(() =>
        {
            this.ApplyCommand.Execute();
            this.navigationService.Close(this);
        },
        () =>
        {
            return this.ApplyCommand.CanExecute();
        });

        public MvxCommand ApplyCommand => new MvxCommand(() =>
        {
            var newKubernetesObject = this.viewModelMapper.ConvertBack(this);

            this.messenger.Publish(new KubernetesObjectChangingMessage(this, this.kubernetesDataObject.GetHashCode(), newKubernetesObject));

            this.kubernetesDataObject = newKubernetesObject;

            KubernetesObjectChanged();
        },
        () =>
        {
            var notifyErrorInfo = (INotifyDataErrorInfo)this;
            return !notifyErrorInfo.HasErrors;
        });

        public MvxCommand CancelCommand => new MvxCommand(() =>
        {
            this.navigationService.Close(this);
        });

        private void KubernetesObjectChangingMessage_Subscription(KubernetesObjectChangingMessage message)
        {
            //occurs when someone deletes this specific object, then the editor dialog now remains with a non-existing object
            //so the dialog needs to be disposed.
            if (this.kubernetesDataObject.GetHashCode() == message.PreviousInstanceHashCode && message.Sender != this)
                this.CancelCommand.Execute();
        }

        private void QueryFromExistingEditorMessage_Subscription(QueryFromExistingEditorMessage message)
        {
            if (message.KubernetesObjectInstanceHashCode != kubernetesDataObject?.GetHashCode())
                return;

            message.IsAnEditorAlive = true;
            this.ActivateEditorView?.Invoke();
        }

        public override void Prepare(Object parameter)
        {
            this.kubernetesDataObject = parameter;
            if (parameter.IsNullOrDummy())
                return;
            this.viewModelMapper.Fill(this.kubernetesDataObject, this);
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
            this.ValidationEnabled = true;
        }

        protected virtual void KubernetesObjectChanged()
        {
        }

        public override void ViewDisappeared()
        {
            base.ViewDisappeared();
            this.ValidationEnabled = false;
            this.kubernetesObjectChangingSubscriptionToken.Dispose();
            this.queryFromExistingEditorSubscriptionToken.Dispose();
        }
    }
}
