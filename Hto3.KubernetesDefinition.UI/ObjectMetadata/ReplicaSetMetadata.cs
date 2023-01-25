using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMetadata
{
    public class ReplicaSetMetadata : IObjectMetadataUI
    {
        public string EditorPath => "/Views/ReplicaSetView";
        public string IconName => "rs.svg";
        public string Name => "Replica Set";
        public string Description => "The specification of the desired behavior of the Deployment.";
        public Type KubernetesObjectType => typeof(Models.KubernetesObjects.DeploymentSpec);
        public Type ManagerType => typeof(ReplicaSetObjectManagerViewModel);
        public Boolean Unique => true;
    }
}
