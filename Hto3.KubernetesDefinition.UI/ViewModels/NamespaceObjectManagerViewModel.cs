using Hto3.KubernetesDefinition.UI.ObjectMetadata;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class NamespaceObjectManagerViewModel : ObjectManagerViewModel
    {
        public NamespaceObjectManagerViewModel(IMvxNavigationService navigationService, IMvxViewModelLoader loader, IMvxMessenger messenger)
            : base(navigationService, loader, messenger)
        {
            base.Metadata = new NamespaceMetadata();
        }
    }
}
