using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class ConfigMapMetadata : IObjectMetadataUI
    {
        public String EditorPath => "/Views/ConfigMapView";
        public String IconName => "cm.svg";
        public String Name => "Config Map";
        public String Description => "ConfigMap holds configuration data for pods to consume.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.ConfigMap);
        public Type ManagerType => typeof(ConfigMapObjectManagerViewModel);
        public Boolean Unique => false;
    }
}
