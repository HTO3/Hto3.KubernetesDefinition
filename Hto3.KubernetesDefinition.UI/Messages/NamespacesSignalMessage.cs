using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    /// <summary>
    /// This message should be used to signal when an updated list of namespaces is requested to be broadcasted.
    /// </summary>
    public class NamespacesSignalMessage : MvxMessage
    {
        public NamespacesSignalMessage(Object sender) : base(sender)
        {
        }
    }
}
