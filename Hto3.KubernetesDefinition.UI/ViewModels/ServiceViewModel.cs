using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Messages;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(ServiceViewModel), "/Views/ServiceView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ServiceViewModel : EditorViewModel
    {
        private readonly MvxSubscriptionToken currentNamespacesSubscriptionToken;

        public ServiceViewModel(IMvxNavigationService navigationService, IViewModelMapper<Service, ServiceViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.currentNamespacesSubscriptionToken = messenger.Subscribe<CurrentNamespacesMessage>(CurrentNamespacesMessage_Subscription);
            this.Selector = new MvxObservableCollection<Tuple<String, String>>();
            this.ServicePorts = new MvxObservableCollection<ServicePortSetup>();
            this.Type = "ClusterIP";
        }

        public String Name { get; set; }
        public String Namespace { get; set; }
        public String Type { get; set; }
        public MvxObservableCollection<Tuple<String, String>> Selector { get; }
        public MvxObservableCollection<ServicePortSetup> ServicePorts { get; }
        public MvxObservableCollection<String> LocalNamespacesList { get; set; }
        public String[] ServiceTypesList => new[] { "ExternalName", "ClusterIP", "NodePort", "LoadBalancer" };

        private void CurrentNamespacesMessage_Subscription(CurrentNamespacesMessage message)
        {
            this.LocalNamespacesList = new MvxObservableCollection<String>(message.Namespaces);
        }

        public override void Prepare()
        {
            base.Prepare();
            this.messenger.Publish(new NamespacesSignalMessage(this));
        }

        public override void ViewDisappeared()
        {
            this.currentNamespacesSubscriptionToken.Dispose();
        }
    }
}
