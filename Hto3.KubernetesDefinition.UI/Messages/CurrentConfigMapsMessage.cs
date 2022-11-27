using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    public class CurrentConfigMapsMessage : MvxMessage
    {
        public CurrentConfigMapsMessage(object sender, string[] configMapNames) : base(sender)
        {
            this.ConfigMapNames = configMapNames;
        }

        public String[] ConfigMapNames { get; }
    }
}
