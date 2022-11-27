using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    /// <summary>
    /// This message should be used to broadcast the current list of namespaces.
    /// </summary>
    public class CurrentNamespacesMessage : MvxMessage
    {
        public CurrentNamespacesMessage(Object sender, String[] namespaces) : base(sender)
        {
            this.Namespaces = namespaces;
        }

        public String[] Namespaces { get; }
    }
}
