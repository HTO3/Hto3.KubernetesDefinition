using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class NamespaceMetadata : IObjectMetadataUI
    {
        public String EditorPath => "/Views/NamespaceView";
        public String IconName => "ns.svg";
        public String Name => "Namespace";
        public String Description => "Namespace provides a scope for Names. Use of multiple namespaces is optional.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.Namespace);
        public Type ManagerType => typeof(NamespaceObjectManagerViewModel);
        public Boolean Unique => false;
    }
}
