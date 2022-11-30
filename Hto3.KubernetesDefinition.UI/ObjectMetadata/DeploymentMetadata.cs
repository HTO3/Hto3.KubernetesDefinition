using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class DeploymentMetadata : IObjectMetadataUI
    {
        public String EditorPath => "/Views/DeploymentView";
        public String IconName => "deploy.svg";
        public String Name => "Deployment";
        public String Description => "Deployment enables declarative updates for Pods and ReplicaSets.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.Deployment);
        public Type ManagerType => typeof(DeploymentObjectManagerViewModel);
        public Boolean Unique => false;
    }
}
