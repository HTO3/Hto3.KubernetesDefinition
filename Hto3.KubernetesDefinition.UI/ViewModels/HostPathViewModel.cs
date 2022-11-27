using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.UI.Common;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class HostPathViewModel : MvxViewModel, IClearableViewModel
    {
        public String Path { get; set; }
        public HostPathType Type { get; set; }

        public void Clear()
        {
            this.Path = null;
            this.Type = default(HostPathType);
        }
    }
}
