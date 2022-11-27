using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    public class ConfigMapSignalMessage : MvxMessage
    {
        public ConfigMapSignalMessage(object sender): base(sender)
        {
        }
    }
}
