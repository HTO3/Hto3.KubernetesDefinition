using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class PodMetadata : IObjectMetadataUI
    {
        public String EditorPath => "/Views/PodView";
        public String IconName => "pod.svg";
        public Type ManagerType => typeof(PodObjectManagerViewModel);
        public String Name => "Pod";
        public String Description => "Describes the data a pod should have when created from a template.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.PodTemplateSpec);
        public Boolean Unique => true;
    }
}
