using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public interface IObjectMetadata
    {
        String EditorPath { get; }
        String IconName { get; }
        String Name { get; }
        String Description { get; }
        Type KubernetesObjectType { get; }
        Type ManagerType { get; }
    }
}
