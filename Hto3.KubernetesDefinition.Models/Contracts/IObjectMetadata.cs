using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface IObjectMetadata
    {
        String Name { get; }
        String Description { get; }
        Type KubernetesObjectType { get; }
        Boolean Unique { get; }
    }
}
