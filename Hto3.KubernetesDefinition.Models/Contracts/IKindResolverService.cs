using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface IKindResolverService
    {
        Type ResolveKind(String rawYmlString);
    }
}
