using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    public class CurrentConfigMapItemsMessage : MvxMessage
    {
        public CurrentConfigMapItemsMessage(object sender, string configMapName, string[] keys) : base(sender)
        {
            this.ConfigMapName = configMapName;
            this.Keys = keys;
        }
        public String ConfigMapName { get; }
        public String[] Keys { get; }
    }
}
