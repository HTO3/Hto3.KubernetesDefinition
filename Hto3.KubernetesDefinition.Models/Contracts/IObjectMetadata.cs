using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface IObjectMetadata
    {
        /// <summary>
        /// The name of this Kubernetes object.
        /// </summary>
        String Name { get; }
        /// <summary>
        /// Description of this Kubernetes object.
        /// </summary>
        String Description { get; }
        /// <summary>
        /// The original Kubernetes type.
        /// </summary>
        Type KubernetesObjectType { get; }
        /// <summary>
        /// If true, this object cannot have siblings.
        /// </summary>
        Boolean Unique { get; }
    }
}
