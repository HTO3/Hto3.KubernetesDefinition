using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class ServiceMetadata : IObjectMetadataUI
    {
        public string EditorPath => "/Views/ServiceView";
        public string IconName => "svc.svg";
        public string Name => "Service";
        public string Description => "Service is a named abstraction of software service (for example, mysql) consisting of local port (for example 3306) that the proxy listens on, and the selector that determines which pods will answer requests sent through the proxy.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.Service);
        public Type ManagerType => typeof(ServiceObjectManagerViewModel);
        public Boolean Unique => false;
    }
}
