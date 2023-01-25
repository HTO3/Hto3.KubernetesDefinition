using Hto3.StringHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common.Models
{
    public class ConfigMapFileEntry
    {
        public ConfigMapFileEntry(String name, String fileContentBase64)
        {
            this.Name = name;
            this.FileContentBase64 = fileContentBase64;
        }

        public String Name { get; }
        public String FileContentBase64 { get; }
        public Int64 Length => this.FileContentBase64.CalcBase64SizeBytes();
    }
}
