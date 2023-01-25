using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
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

[assembly: MvxNavigation(typeof(ReplicaSetViewModel), "/Views/ReplicaSetView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ReplicaSetViewModel : EditorViewModel
    {
        public ReplicaSetViewModel(IMvxNavigationService navigationService, IViewModelMapper<DeploymentSpec, ReplicaSetViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.LabelSelectorForPods = new MvxObservableCollection<Tuple<String, String>>();
            this.ProgressDeadlineSeconds = 600;
            this.Replicas = 1;
        }

        public MvxObservableCollection<Tuple<String, String>> LabelSelectorForPods { get; }
        public Int32 ProgressDeadlineSeconds { get; set; }
        public Int32 Replicas { get; set; }
    }
}
