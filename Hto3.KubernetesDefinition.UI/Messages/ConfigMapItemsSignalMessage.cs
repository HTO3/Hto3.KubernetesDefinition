using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    public class ConfigMapItemsSignalMessage : MvxMessage
    {
        public ConfigMapItemsSignalMessage(object sender, String configMapName) : base(sender)
        {
            this.ConfigMapName = configMapName;
        }

        public String ConfigMapName { get; }
    }
}
