using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public enum MemorySize
    {
        [Description("Bytes")]
        b = -1,
        [Description("Kibibytes")]
        Ki = 0,
        [Description("Kilobytes")]
        K = 1,
        [Description("Mebibytes")]
        Mi = 2,
        [Description("Megabytes")]
        M = 3,
        [Description("Gibibytes")]
        Gi = 4,
        [Description("Gigabytes")]
        G = 5,
        [Description("Tebibytes")]
        Ti = 6,
        [Description("Terabytes")]
        T = 7,
        [Description("Pebibytes")]
        Pi = 8,
        [Description("Petabytes")]
        P = 9,
        [Description("Exabibytes")]
        Ei = 10,
        [Description("Exabytes")]
        E = 11
    }
}
