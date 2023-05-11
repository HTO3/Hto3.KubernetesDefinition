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
        }

        public override void ResolveKubernetesObjectChildren()
        {
            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var cronJob = (CronJob)base.KubernetesDataObject;

            cronJob.Spec.JobTemplate.Spec = new JobSpec();
            if (base.ChildrenKubernetesDataObjects.Any())
                cronJob.Spec.JobTemplate.Spec.Template = (PodTemplateSpec)base.ChildrenKubernetesDataObjects.Single().KubernetesDataObject;
        }

        public override void ResolveVisualizationChildren()
        {
            base.ChildrenKubernetesDataObjects.Clear();

            if (base.KubernetesDataObject.IsNullOrDummy())
                return;

            var cronJob = (CronJob)base.KubernetesDataObject;

            if (cronJob.Spec?.JobTemplate?.Spec?.Template == null)
                return;

            var addMetadata = base.OptionsToExecute.Single(o => o?.KubernetesObjectType == typeof(PodTemplateSpec));

            base.AddCommand.Execute(addMetadata);
            var recentlyAdded = base.ChildrenKubernetesDataObjects.Last();
            recentlyAdded.KubernetesDataObject = cronJob.Spec.JobTemplate.Spec.Template;
            recentlyAdded.ResolveVisualizationChildren();
        }
    }
}
