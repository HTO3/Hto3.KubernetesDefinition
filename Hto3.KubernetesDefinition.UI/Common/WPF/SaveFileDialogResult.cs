using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common.WPF
{
    public class SaveFileDialogResult
    {
        public String ChosenPath { get; set; }
        public Boolean Cancel { get; set; }
    }
}
