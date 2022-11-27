using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public class ConfigMapVolumeItem
    {
        public ConfigMapVolumeItem(String key, String path)
        {
            this.Key = key;
            this.Path = path;
        }

        public String Key { get; }
        public String Path { get; }
    }
}
