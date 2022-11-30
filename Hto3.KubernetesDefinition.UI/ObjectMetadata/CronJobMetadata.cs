using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class CronJobMetadata : IObjectMetadataUI
    {
        public String EditorPath => "/Views/CronJobView";
        public String IconName => "cronjob.svg";
        public String Name => "CronJob";
        public String Description => "CronJob represents the configuration of a single cron job.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.CronJob);
        public Type ManagerType => typeof(CronJobObjectManagerViewModel);
        public Boolean Unique => false;
    }
}
