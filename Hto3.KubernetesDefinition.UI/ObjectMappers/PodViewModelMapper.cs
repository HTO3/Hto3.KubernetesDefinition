using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class PodViewModelMapper : IViewModelMapper<PodTemplateSpec, PodViewModel>
    {
        public PodTemplateSpec ConvertBack(PodViewModel source)
        {
            var podTemplateSpec = new PodTemplateSpec();
            podTemplateSpec.Metadata = new ObjectMeta();
            podTemplateSpec.Metadata.Name = source.Name;
            if (source.Labels.Any())
                podTemplateSpec.Metadata.Labels = source.Labels.ToDictionary(e => e.Item1, e => e.Item2);
            podTemplateSpec.Spec = new PodSpec();
            if (source.HostNetwork)
                podTemplateSpec.Spec.HostNetwork = true;
            if (!String.IsNullOrWhiteSpace(source.HostName))
                podTemplateSpec.Spec.Hostname = source.HostName;
            if (source.RestartPolicy != Models.RestartPolicy.Always)
                podTemplateSpec.Spec.RestartPolicy = source.RestartPolicy.ToString();
            if (source.ShareProcessNamespace)
                podTemplateSpec.Spec.ShareProcessNamespace = true;
            if (source.NodeSelector.Any())
                podTemplateSpec.Spec.NodeSelector = source.NodeSelector.ToDictionary(e => e.Item1, e => e.Item2);

            return podTemplateSpec;
        }

        public void Fill(PodTemplateSpec source, PodViewModel target)
        {
            target.Name = source.Metadata?.Name;
            target.Labels.Clear();
            target.Labels.AddRange
                (
                    source.Metadata?.Labels
                        .EmptyIfNull()
                        .Select(l => new Tuple<String, String>(l.Key, l.Value))
                );
            target.HostNetwork = source.Spec.HostNetwork == true;
            target.HostName = source.Spec.Hostname;
            target.NodeSelector.Clear();
            target.NodeSelector.AddRange
                (
                    source.Spec?.NodeSelector
                        .EmptyIfNull()
                        .Select(l => new Tuple<String, String>(l.Key, l.Value))
                );
            if (source.Spec?.RestartPolicy == "Never")
                target.RestartPolicy = Models.RestartPolicy.Never;
            else if (source.Spec?.RestartPolicy == "OnFailure")
                target.RestartPolicy = Models.RestartPolicy.OnFailure;
            else
                target.RestartPolicy = Models.RestartPolicy.Always;
            target.ShareProcessNamespace = source.Spec.ShareProcessNamespace == true;
        }

        public Object ConvertBack(Object source) => ConvertBack((PodViewModel)source);
        public void Fill(Object source, Object target) => Fill((PodTemplateSpec)source, (PodViewModel)target);
    }
}
