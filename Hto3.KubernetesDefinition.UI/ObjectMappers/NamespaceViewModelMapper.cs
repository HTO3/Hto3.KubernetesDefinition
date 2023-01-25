using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class NamespaceViewModelMapper : IViewModelMapper<Namespace, NamespaceViewModel>
    {
        public Namespace ConvertBack(NamespaceViewModel source)
        {
            var @namespace = new Namespace();
            @namespace.ApiVersion = "v1";
            @namespace.Kind = NamespaceKind.Namespace;
            @namespace.Metadata = @namespace.Metadata ?? new ObjectMeta();
            @namespace.Metadata.Name = source.Name;
            return @namespace;
        }

        public void Fill(Namespace source, NamespaceViewModel target)
        {
            target.Name = source?.Metadata?.Name;
        }

        public Object ConvertBack(Object source) => ConvertBack((NamespaceViewModel)source);
        public void Fill(Object source, Object target) => Fill((Namespace)source, (NamespaceViewModel)target);
    }
}
