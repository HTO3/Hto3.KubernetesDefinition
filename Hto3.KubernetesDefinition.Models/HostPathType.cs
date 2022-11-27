using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public enum HostPathType
    {
        [Description("")]
        Any = 0,
        [Description("Directory or Create")]
        DirectoryOrCreate = 1,
        Directory = 2,
        [Description("File or Create")]
        FileOrCreate = 3,
        File = 4,
        Socket = 5,
        [Description("Char Device")]
        CharDevice = 6,
        [Description("BlockD evice")]
        BlockDevice = 7
    }
}
