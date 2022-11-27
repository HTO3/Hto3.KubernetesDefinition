using Hto3.KubernetesDefinition.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Hto3.KubernetesDefinition.Services
{
    public class OpenService : IOpenService
    {
        private readonly IKindResolverService kindResolverService;
        private readonly IDeserializer deserializer;

        public OpenService(IKindResolverService kindResolverService)
        {
            this.kindResolverService = kindResolverService;
            this.deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
        }

        public IEnumerable<Object> ReadYml(string fileName)
        {
            var ymlFullContent = File.ReadAllText(fileName);
            var ymlContentParts = ymlFullContent.Split(new[] { "\n---" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ymlContentPart in ymlContentParts)
            {
                var kindType = kindResolverService.ResolveKind(ymlContentPart);
                yield return deserializer.Deserialize(ymlContentPart, kindType);
            }
        }
    }
}
