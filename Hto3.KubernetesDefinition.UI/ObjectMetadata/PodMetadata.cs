using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class PodMetadata : IObjectMetadata
    {
        public String EditorPath => "/Views/PodView";
        public String IconName => "pod.svg";
        public String Name => "Pod";
        public String Description => "A single application container that you want to run within a pod.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.Container);
        public Type ManagerType => typeof(PodObjectManagerViewModel);
    }
}
