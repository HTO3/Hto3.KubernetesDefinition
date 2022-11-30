using Hto3.KubernetesDefinition.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public interface IObjectMetadataUI : IObjectMetadata
    {
        String EditorPath { get; }
        String IconName { get; }
        Type ManagerType { get; }
    }
}
