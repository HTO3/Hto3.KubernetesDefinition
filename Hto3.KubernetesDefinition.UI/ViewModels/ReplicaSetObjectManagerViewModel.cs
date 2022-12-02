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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ReplicaSetObjectManagerViewModel : ObjectManagerViewModel
    {
        public ReplicaSetObjectManagerViewModel(IMvxNavigationService navigationService, IMvxViewModelLoader loader, IMvxMessenger messenger)
            : base(navigationService, loader, messenger)
        {
            base.Metadata = new ReplicaSetMetadata();
        }

        public override void Prepare()
        {
            base.Prepare();

            base.OptionsToExecute.Add(null);
            base.OptionsToExecute.Add(base.CreateAddMenuOption<ContainerMetadata>());
            base.OptionsToExecute.Add(base.CreateAddMenuOption<VolumeMetadata>());
        }

        public override void ResolveKubernetesObjectChildren()
        {
            if (this.KubernetesDataObject.IsNullOrDummy())
                return;

            var deploymentSpec = (DeploymentSpec)base.KubernetesDataObject;

            deploymentSpec.Template = deploymentSpec.Template ?? new PodTemplateSpec();
            deploymentSpec.Template.Spec = new PodSpec();
            deploymentSpec.Template.Spec.Containers = new List<Container>();
            deploymentSpec.Template.Spec.Volumes = new List<Volume>();

            foreach (var child in base.ChildrenKubernetesDataObjects)
            {
                if (child.KubernetesDataObject is Container)
                    deploymentSpec.Template.Spec.Containers.Add((Container)child.KubernetesDataObject);
                else if (child.KubernetesDataObject is Volume)
                    deploymentSpec.Template.Spec.Volumes.Add((Volume)child.KubernetesDataObject);
            }

            if (deploymentSpec.Template.Spec.Containers.Count == 0)
                deploymentSpec.Template.Spec.Containers = null;
            if (deploymentSpec.Template.Spec.Volumes.Count == 0)
                deploymentSpec.Template.Spec.Volumes = null;
        }

        public override void ResolveVisualizationChildren()
        {
            base.ChildrenKubernetesDataObjects.Clear();

            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var deploymentSpec = (DeploymentSpec)base.KubernetesDataObject;

            var innerObjects = new[]
            {
                (IEnumerable)deploymentSpec.Template?.Spec?.Containers.EmptyIfNull()
                ,
                (IEnumerable)deploymentSpec.Template?.Spec?.Volumes.EmptyIfNull()
            };

            foreach (var inners in innerObjects)
            {
                var kubeObjType = inners.GetItemType();
                var addMetadata = base.OptionsToExecute.Single(o => o?.KubernetesObjectType == kubeObjType);
                foreach (var obj in inners)
                {
                    base.AddCommand.Execute(addMetadata);
                    var recentlyAdded = base.ChildrenKubernetesDataObjects.Last();
                    recentlyAdded.KubernetesDataObject = obj;
                    recentlyAdded.ResolveVisualizationChildren();
                }
            }
        }
    }
}
