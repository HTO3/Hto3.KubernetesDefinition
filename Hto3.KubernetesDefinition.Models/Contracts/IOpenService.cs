using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface IOpenService
    {
        IEnumerable<Object> ReadYml(String fileName);
    }
}
