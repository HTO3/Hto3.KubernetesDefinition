using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.Contracts;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ObjectMetadata;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class DeploymentObjectManagerViewModel : ObjectManagerViewModel
    {
        public DeploymentObjectManagerViewModel(IMvxNavigationService navigationService, IMvxViewModelLoader loader, IMvxMessenger messenger)
            : base(navigationService, loader, messenger)
        {
            base.Metadata = new DeploymentMetadata();
        }

        public override void Prepare()
        {
            base.Prepare();

            base.OptionsToExecute.Add(null);
            base.OptionsToExecute.Add(base.CreateAddMenuOption<ReplicaSetMetadata>());
        }

        public override void ResolveKubernetesObjectChildren()
        {
            if (this.KubernetesDataObject.IsNullOrDummy())
                return;

            var deployment = (Deployment)base.KubernetesDataObject;
            var child = this.ChildrenKubernetesDataObjects.SingleOrDefault();
            if (child != null)
            {
                var deploymentSpec = default(DeploymentSpec);
                if ((deploymentSpec = child.KubernetesDataObject as DeploymentSpec) != null)
                    deployment.Spec = deploymentSpec;
            }
            else
                deployment.Spec = null;
        }

        public override void ResolveVisualizationChildren()
        {
            base.ChildrenKubernetesDataObjects.Clear();

            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var deployment = (Deployment)base.KubernetesDataObject;
            if (deployment.Spec == null)
                return;

            var addMetadata = base.OptionsToExecute.Single(o => o?.KubernetesObjectType == typeof(Models.KubernetesObjects.DeploymentSpec));
            base.AddCommand.Execute(addMetadata);
            var recentlyAdded = base.ChildrenKubernetesDataObjects.Last();
            recentlyAdded.KubernetesDataObject = deployment.Spec;
            recentlyAdded.ResolveVisualizationChildren();
        }
    }
}
