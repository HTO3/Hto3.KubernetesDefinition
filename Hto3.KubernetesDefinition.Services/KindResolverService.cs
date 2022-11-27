using Hto3.KubernetesDefinition.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Services
{
    public class KindResolverService : IKindResolverService
    {
        const String KUBERNETES_OBJ_NAMESPACE = "Hto3.KubernetesDefinition.Models.KubernetesObjects";
        private readonly Regex kindRegex;
        private readonly Assembly kubernetesObjectsAssembly;

        public KindResolverService()
        {
            this.kindRegex = new Regex(@"^(kind:\s+(?<kind>\w+))", RegexOptions.Multiline);
            this.kubernetesObjectsAssembly = Assembly.GetAssembly(typeof(Hto3.KubernetesDefinition.Models.KubernetesObjects.Namespace));
        }

        public Type ResolveKind(String rawYmlString)
        {
            var match = kindRegex.Match(rawYmlString);
            if (!match.Success)
                return null;

            var kind = match.Groups["kind"].Value;
            var type = kubernetesObjectsAssembly.GetType($"{KUBERNETES_OBJ_NAMESPACE}.{kind}");
            return type;
        }
    }
}
