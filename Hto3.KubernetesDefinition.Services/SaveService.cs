using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models.Contracts;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.EventEmitters;
using YamlDotNet.Serialization.NamingConventions;

namespace Hto3.KubernetesDefinition.Services
{
    public class SaveService : ISaveService
    {
        private readonly ISerializer serializer;

        public SaveService()
        {
            this.serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .WithEventEmitter(nextEmitter => new CustomizeEnvVarEventEmitter(nextEmitter))
                .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitDefaults)
                .Build();
        }

        public void WriteYml(IEnumerable<IObjectGraph> graph, String fileName)
        {
            using (var streamWriter = new StreamWriter(fileName, false, Encoding.UTF8))
                WriteYml(graph, streamWriter);
        }

        public string WriteYml(IEnumerable<IObjectGraph> graph)
        {
            var stringBuilder = new StringBuilder();
            using (var streamWriter = new StringWriter(stringBuilder))
                WriteYml(graph, streamWriter);

            return stringBuilder.ToString();
        }

        private void WriteYml(IEnumerable<IObjectGraph> graph, TextWriter textWriter)
        {
            Action<IObjectGraph> glueParts = null;
            glueParts = new Action<IObjectGraph>(node =>
            {
                node.ResolveKubernetesObjectChildren();
                foreach (var innerNode in node.ChildrenKubernetesDataObjects.EmptyIfNull())
                    glueParts(innerNode);
            });

            foreach (var item in graph)
            {
                glueParts(item);
                serializer.Serialize(textWriter, item.KubernetesDataObject);
                if (item != graph.Last())
                    textWriter.WriteLine("---");
            }
        }

        private class CustomizeEnvVarEventEmitter : ChainedEventEmitter
        {
            private Boolean envVarEmitting = false;

            public CustomizeEnvVarEventEmitter(IEventEmitter nextEmitter) : base(nextEmitter)
            {
            }

            public override void Emit(ScalarEventInfo eventInfo, IEmitter emitter)
            {
                if (envVarEmitting && Int32.TryParse(eventInfo.Source.Value?.ToString() ?? String.Empty, out var number))
                    eventInfo.Style = ScalarStyle.DoubleQuoted;

                base.Emit(eventInfo, emitter);
            }

            public override void Emit(MappingStartEventInfo eventInfo, IEmitter emitter)
            {
                if (eventInfo.Source.StaticType == typeof(EnvVar))
                    envVarEmitting = true;

                base.Emit(eventInfo, emitter);
            }

            public override void Emit(MappingEndEventInfo eventInfo, IEmitter emitter)
            {
                if (eventInfo.Source.StaticType == typeof(EnvVar))
                    envVarEmitting = false;

                base.Emit(eventInfo, emitter);
            }
        }
    }
}
