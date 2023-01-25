using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class ReplicaSetViewModelMapper : IViewModelMapper<DeploymentSpec, ReplicaSetViewModel>
    {
        public DeploymentSpec ConvertBack(ReplicaSetViewModel source)
        {
            var deploymentSpec = new DeploymentSpec();
            deploymentSpec.Replicas = source.Replicas;
            deploymentSpec.ProgressDeadlineSeconds = source.ProgressDeadlineSeconds == 600 ? (Int32?)null : source.ProgressDeadlineSeconds;
            deploymentSpec.Selector = new LabelSelector();
            deploymentSpec.Selector.MatchLabels = source.LabelSelectorForPods.ToDictionary(e => e.Item1, e => e.Item2);
            
            return deploymentSpec;
        }

        public void Fill(DeploymentSpec source, ReplicaSetViewModel target)
        {
            target.Replicas = source.Replicas ?? 1;
            target.ProgressDeadlineSeconds = source.ProgressDeadlineSeconds ?? 600;

            target.LabelSelectorForPods.Clear();
            target.LabelSelectorForPods.AddRange
                (
                    source.Selector?.MatchLabels
                        .EmptyIfNull()
                        .Select(l => new Tuple<String, String>(l.Key, l.Value))
                );
        }

        public Object ConvertBack(Object source) => ConvertBack((ReplicaSetViewModel)source);
        public void Fill(Object source, Object target) => Fill((DeploymentSpec)source, (ReplicaSetViewModel)target);
    }
}
