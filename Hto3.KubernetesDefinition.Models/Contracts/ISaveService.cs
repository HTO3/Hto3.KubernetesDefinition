using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface ISaveService
    {
        void WriteYml(IEnumerable<IObjectGraph> graph, String fileName);
        String WriteYml(IEnumerable<IObjectGraph> graph);
    }
}
