using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.Common.Models;
using Hto3.KubernetesDefinition.UI.Messages;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ConfigMapVolumeViewModel : MvxViewModel, IClearableViewModel
    {
        private readonly IMvxMessenger messenger;
        private readonly MvxSubscriptionToken currentConfigMapItemsMessageSubscriptionToken;
        private readonly MvxSubscriptionToken currentConfigMapsMessageSubscriptionToken;

        public ConfigMapVolumeViewModel(IMvxMessenger messenger)
        {
            this.messenger = messenger;
            this.Items = new MvxObservableCollection<ConfigMapVolumeItem>();
            this.currentConfigMapItemsMessageSubscriptionToken = messenger.Subscribe<CurrentConfigMapItemsMessage>(CurrentConfigMapItemsMessage_Subscription);
            this.currentConfigMapsMessageSubscriptionToken = messenger.Subscribe<CurrentConfigMapsMessage>(CurrentConfigMapsMessage_Subscription);
        }

        public override void Prepare()
        {
            base.Prepare();
            this.messenger.Publish(new ConfigMapSignalMessage(this));
        }

        [OnChangedMethod(nameof(UpdateItemsKeys))]
        public String ConfigMapName { get; set; }

        public MvxObservableCollection<ConfigMapVolumeItem> Items { get; }
        public MvxObservableCollection<String> CurrentConfigMapDataKeys { get; set; }
        public MvxObservableCollection<String> CurrentConfigMapNames { get; set; }

        private void CurrentConfigMapsMessage_Subscription(CurrentConfigMapsMessage obj)
        {
            this.CurrentConfigMapNames = new MvxObservableCollection<String>(obj.ConfigMapNames);
        }

        private void CurrentConfigMapItemsMessage_Subscription(CurrentConfigMapItemsMessage obj)
        {
            this.CurrentConfigMapDataKeys = new MvxObservableCollection<String>(obj.Keys);
        }

        private void UpdateItemsKeys()
        {
            this.CurrentConfigMapDataKeys = null;
            this.messenger.Publish(new ConfigMapItemsSignalMessage(this, this.ConfigMapName));
        }

        public void Clear()
        {
            this.ConfigMapName = null;
            this.Items.Clear();
        }

        public override void ViewDisappeared()
        {
            base.ViewDisappeared();
            this.currentConfigMapItemsMessageSubscriptionToken.Dispose();
            this.currentConfigMapsMessageSubscriptionToken.Dispose();
        }
    }
}
