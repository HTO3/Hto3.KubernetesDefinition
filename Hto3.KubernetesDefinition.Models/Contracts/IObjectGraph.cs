using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface IObjectGraph
    {
        Object KubernetesDataObject { get; set; }
        ICollection<IObjectGraph> ChildrenKubernetesDataObjects { get; }
        void ResolveKubernetesObjectChildren();
        void ResolveVisualizationChildren();
    }
}
