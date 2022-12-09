using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ObjectMappers;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(ContainerViewModel), "/Views/ContainerView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ContainerViewModel : EditorViewModel
    {
        public ContainerViewModel(IMvxNavigationService navigationService, IViewModelMapper<Container, ContainerViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.ExposedPorts = new MvxObservableCollection<Tuple<Int32, String>>();
            this.EnvironmentVariables = new MvxObservableCollection<Tuple<String, String>>();
            this.VolumeMounts = new MvxObservableCollection<Tuple<String, String, Boolean>>();
            this.LivenessProbe = new ProbeViewModel();
            this.ReadinessProbe = new ProbeViewModel();
            this.MemoryLimitSize = MemorySize.G;
            this.MemoryRequestSize = MemorySize.G;
        }

        public String Name { get; set; }
        public String ImageName { get; set; }
        public MvxObservableCollection<Tuple<Int32, String>> ExposedPorts { get; }
        public MvxObservableCollection<Tuple<String, String>> EnvironmentVariables { get; }
        public MvxObservableCollection<Tuple<String, String, Boolean>> VolumeMounts { get; }
        public ProbeViewModel LivenessProbe { get; }
        public Boolean LivenessProbeDesired { get; set; }
        public ProbeViewModel ReadinessProbe { get; }
        public Boolean ReadinessProbeDesired { get; set; }
        public Decimal? CpuLimit { get; set; }
        public Decimal? MemoryLimit { get; set; }
        public MemorySize MemoryLimitSize { get; set; }
        public Decimal? CpuRequest { get; set; }
        public Decimal? MemoryRequest { get; set; }
        public MemorySize MemoryRequestSize { get; set; }
    }
}
