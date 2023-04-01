using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(SecretViewModel), "/Views/SecretView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class SecretViewModel : EditorViewModel
    {
        public SecretViewModel(IMvxNavigationService navigationService, IViewModelMapper<Secret, SecretViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
        }

        public String Name { get; set; }
    }
}
