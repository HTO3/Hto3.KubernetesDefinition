using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models;
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
    public class CronJobObjectManagerViewModel : ObjectManagerViewModel
    {
        public CronJobObjectManagerViewModel(IMvxNavigationService navigationService, IMvxViewModelLoader loader, IMvxMessenger messenger)
            : base(navigationService, loader, messenger)
        {
            base.Metadata = new CronJobMetadata();
        }

        public override void Prepare()
        {
            base.Prepare();

            base.OptionsToExecute.Add(null);
            base.OptionsToExecute.Add(base.CreateAddMenuOption<PodMetadata>());
            base.OptionsToExecute.Add(base.CreateAddMenuOption<VolumeMetadata>());
        }

        public override void ResolveKubernetesObjectChildren()
        {
            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var cronJob = (CronJob)base.KubernetesDataObject;

            cronJob.Spec.JobTemplate.Spec = new JobSpec();
            cronJob.Spec.JobTemplate.Spec.Template.Spec = new PodSpec();
            cronJob.Spec.JobTemplate.Spec.Template.Spec.Containers = new List<Container>();
            cronJob.Spec.JobTemplate.Spec.Template.Spec.Volumes = new List<Volume>();

            foreach (var child in base.ChildrenKubernetesDataObjects)
            {
                if (child.KubernetesDataObject is Container)
                    cronJob.Spec.JobTemplate.Spec.Template.Spec.Containers.Add((Container)child.KubernetesDataObject);
                else if (child.KubernetesDataObject is Volume)
                    cronJob.Spec.JobTemplate.Spec.Template.Spec.Volumes.Add((Volume)child.KubernetesDataObject);
            }

            if (cronJob.Spec.JobTemplate.Spec.Template.Spec.Containers.Count == 0)
                cronJob.Spec.JobTemplate.Spec.Template.Spec.Containers = null;
            if (cronJob.Spec.JobTemplate.Spec.Template.Spec.Volumes.Count == 0)
                cronJob.Spec.JobTemplate.Spec.Template.Spec.Volumes = null;
        }

        public override void ResolveVisualizationChildren()
        {
            base.ChildrenKubernetesDataObjects.Clear();

            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var cronJob = (CronJob)base.KubernetesDataObject;

            var innerObjects = new[]
            {
                (IEnumerable)cronJob.Spec?.JobTemplate?.Spec?.Template?.Spec?.Containers.EmptyIfNull()
                ,
                (IEnumerable)cronJob.Spec?.JobTemplate?.Spec?.Template?.Spec?.Volumes.EmptyIfNull()
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
