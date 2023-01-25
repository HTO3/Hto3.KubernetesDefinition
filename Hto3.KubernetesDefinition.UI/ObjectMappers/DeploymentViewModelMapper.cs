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
    public class DeploymentViewModelMapper : IViewModelMapper<Deployment, DeploymentViewModel>
    {
        public Deployment ConvertBack(DeploymentViewModel source)
        {
            var deployment = new Deployment();
            deployment.ApiVersion = "apps/v1";
            deployment.Kind = DeploymentKind.Deployment;
            deployment.Metadata = new ObjectMeta();
            deployment.Metadata.Name = source.Name;
            deployment.Metadata.Namespace = source.Namespace;
            deployment.Metadata.Labels = source.Labels.ToDictionary(e => e.Item1, e => e.Item2);
            return deployment;
        }

        public void Fill(Deployment source, DeploymentViewModel target)
        {
            target.Name = source.Metadata?.Name;
            target.Namespace = source.Metadata?.Namespace;

            target.Labels.Clear();
            target.Labels.AddRange
                (
                    source.Metadata?.Labels
                        .EmptyIfNull()
                        .Select(l => new Tuple<String, String>(l.Key, l.Value))
                );
        }

        public Object ConvertBack(Object source) => ConvertBack((DeploymentViewModel)source);
        public void Fill(Object source, Object target) => Fill((Deployment)source, (DeploymentViewModel)target);
    }
}
