using FluentValidation;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;

namespace Hto3.KubernetesDefinition.UI.ObjectValidation
{
    public class NamespaceValidator : AbstractValidator<NamespaceViewModel>
    {
        public NamespaceValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Please provide a name.");
        }
    }
}
