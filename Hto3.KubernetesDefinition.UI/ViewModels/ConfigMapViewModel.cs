using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hto3.KubernetesDefinition.UI.Messages;
using MvvmCross.ViewModels;
using MvvmCross.Commands;

[assembly: MvxNavigation(typeof(ConfigMapViewModel), "/Views/ConfigMapView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ConfigMapViewModel : EditorViewModel
    {
        private readonly MvxSubscriptionToken currentNamespacesSubscriptionToken;

        public ConfigMapViewModel(IMvxNavigationService navigationService, IViewModelMapper<ConfigMap, ConfigMapViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.currentNamespacesSubscriptionToken = messenger.Subscribe<CurrentNamespacesMessage>(CurrentNamespacesMessage_Subscription);
            this.KeyValueConfigs = new MvxObservableCollection<Tuple<String, String>>();
            this.KeyFileConfigs = new MvxObservableCollection<ConfigMapFileEntry>();
        }

        public String Name { get; set; }
        public String Namespace { get; set; }
        public MvxObservableCollection<String> LocalNamespacesList { get; set; }
        public MvxObservableCollection<Tuple<String, String>> KeyValueConfigs { get; }
        public MvxObservableCollection<ConfigMapFileEntry> KeyFileConfigs { get; }

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
            base.ViewDisappeared();
            this.currentNamespacesSubscriptionToken.Dispose();
        }
    }
}