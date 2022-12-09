using Hto3.CollectionHelpers;
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
    public class PodObjectManagerViewModel : ObjectManagerViewModel
    {
        public PodObjectManagerViewModel(IMvxNavigationService navigationService, IMvxViewModelLoader loader, IMvxMessenger messenger) : base(navigationService, loader, messenger)
        {
            base.Metadata = new PodMetadata();
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

            var podTemplateSpec = (PodTemplateSpec)base.KubernetesDataObject;

            podTemplateSpec.Spec.Containers = new List<Container>();
            podTemplateSpec.Spec.Volumes = new List<Volume>();

            foreach (var child in base.ChildrenKubernetesDataObjects)
            {
                if (child.KubernetesDataObject is Container)
                    podTemplateSpec.Spec.Containers.Add((Container)child.KubernetesDataObject);
                else if (child.KubernetesDataObject is Volume)
                    podTemplateSpec.Spec.Volumes.Add((Volume)child.KubernetesDataObject);
            }

            if (podTemplateSpec.Spec.Containers.Count == 0)
                podTemplateSpec.Spec.Containers = null;
            if (podTemplateSpec.Spec.Volumes.Count == 0)
                podTemplateSpec.Spec.Volumes = null;
        }

        public override void ResolveVisualizationChildren()
        {
            base.ChildrenKubernetesDataObjects.Clear();

            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var podTemplateSpec = (PodTemplateSpec)base.KubernetesDataObject;

            var innerObjects = new[]
            {
                (IEnumerable)podTemplateSpec.Spec?.Containers.EmptyIfNull()
                ,
                (IEnumerable)podTemplateSpec.Spec?.Volumes.EmptyIfNull()
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
