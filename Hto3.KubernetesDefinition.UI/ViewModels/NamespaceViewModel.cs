using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.Messages;
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

[assembly: MvxNavigation(typeof(NamespaceViewModel), "/Views/NamespaceView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class NamespaceViewModel : EditorViewModel
    {
        public NamespaceViewModel(IMvxNavigationService navigationService, IViewModelMapper<Namespace, NamespaceViewModel> viewModelMapper, IMvxMessenger messenger)
            : base (navigationService, viewModelMapper, messenger)
        {
        }

        public String Name { get; set; }

        protected override void KubernetesObjectChanged() => this.messenger.Publish(new NamespacesSignalMessage(this));
    }
}
