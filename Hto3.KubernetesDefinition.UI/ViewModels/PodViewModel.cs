using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(PodViewModel), "/Views/PodView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class PodViewModel : EditorViewModel
    {
        public PodViewModel(IMvxNavigationService navigationService, IViewModelMapper<PodTemplateSpec, PodViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.Labels = new MvxObservableCollection<Tuple<String, String>>();
            this.NodeSelector = new MvxObservableCollection<Tuple<String, String>>();
        }

        public String Name { get; set; }
        public MvxObservableCollection<Tuple<String, String>> Labels { get; }
        public Boolean HostNetwork { get; set; }
        public String HostName { get; set; }
        public MvxObservableCollection<Tuple<String, String>> NodeSelector { get; }
        public RestartPolicy RestartPolicy { get; set; }
        public Boolean ShareProcessNamespace { get; set; }
    }
}
