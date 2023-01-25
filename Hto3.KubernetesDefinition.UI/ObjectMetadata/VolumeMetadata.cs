using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class VolumeMetadata : IObjectMetadataUI
    {
        public String EditorPath => "/Views/VolumeView";
        public String IconName => "vol.svg";
        public String Name => "Volume";
        public String Description => "Volume represents a named volume in a pod that may be accessed by any container in the pod.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.Volume);
        public Type ManagerType => typeof(VolumeObjectManagerViewModel);
        public Boolean Unique => false;
    }
}
