using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public class ExecuteContextMenuOption
    {
        public String Name { get; set; }
        public String IconName { get; set; }
        public ICommand ExecuteCommand { get; set; }
        public Type ManagerType { get; set; }
        public Type KubernetesObjectType { get; set; }
        public Boolean UniqueChild { get; set; }
    }
}
