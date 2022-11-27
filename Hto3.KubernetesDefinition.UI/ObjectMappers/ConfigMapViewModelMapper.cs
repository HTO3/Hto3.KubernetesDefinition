using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class ConfigMapViewModelMapper : IViewModelMapper<ConfigMap, ConfigMapViewModel>
    {
        public ConfigMap ConvertBack(ConfigMapViewModel source)
        {
            var configMap = new ConfigMap();
            configMap.ApiVersion = "v1";
            configMap.Kind = ConfigMapKind.ConfigMap;
            configMap.Metadata = new ObjectMeta();
            configMap.Metadata.Name = source.Name;
            configMap.Metadata.Namespace = source.Namespace;
            if (source.KeyValueConfigs.EmptyIfNull().Any())
                configMap.Data = source.KeyValueConfigs.ToDictionary(i => i.Item1, i => i.Item2);
            if (source.KeyFileConfigs.EmptyIfNull().Any())
                configMap.BinaryData = source.KeyFileConfigs.ToDictionary(i => i.Name, i => i.FileContentBase64);
            return configMap;
        }

        public void Fill(ConfigMap source, ConfigMapViewModel target)
        {
            target.Name = source.Metadata?.Name;
            target.Namespace = source.Metadata?.Namespace;
            
            target.KeyValueConfigs.Clear();
            target.KeyValueConfigs.AddRange
                (
                    source.Data
                        .EmptyIfNull()
                        .Select(d => new Tuple<String, String>(d.Key, d.Value))
                );

            target.KeyFileConfigs.Clear();
            target.KeyFileConfigs.AddRange
                (
                    source.BinaryData
                        .EmptyIfNull()
                        .Select(d => new ConfigMapFileEntry(d.Key, d.Value))
                );
        }

        public Object ConvertBack(Object source) => ConvertBack((ConfigMapViewModel)source);
        public void Fill(Object source, Object target) => Fill((ConfigMap)source, (ConfigMapViewModel)target);
    }
}
