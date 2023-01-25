using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common.WPF
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    internal class ConfigurationAttribute : Attribute
    {
        public String SyncfusionLicense { get; set; }
    }
}
