using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
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

[assembly: MvxNavigation(typeof(DeploymentViewModel), "/Views/DeploymentView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class DeploymentViewModel : EditorViewModel
    {
        private readonly MvxSubscriptionToken currentNamespacesSubscriptionToken;

        public DeploymentViewModel(IMvxNavigationService navigationService, IViewModelMapper<Deployment, DeploymentViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.currentNamespacesSubscriptionToken = messenger.Subscribe<CurrentNamespacesMessage>(CurrentNamespacesMessage_Subscription);
            this.Labels = new MvxObservableCollection<Tuple<String, String>>();
        }

        public String Name { get; set; }
        public String Namespace { get; set; }
        public MvxObservableCollection<Tuple<String, String>> Labels { get; }
        public MvxObservableCollection<String> LocalNamespacesList { get; set; }

        private void CurrentNamespacesMessage_Subscription(CurrentNamespacesMessage message)
        {
            this.LocalNamespacesList = new MvxObservableCollection<String>(message.Namespaces);
        }

        public override void Prepare()
        {
            base.Prepare();
            base.messenger.Publish(new NamespacesSignalMessage(this));
        }

        public override void ViewDisappeared()
        {
            base.ViewDisappeared();
            this.currentNamespacesSubscriptionToken.Dispose();
        }
    }
}
