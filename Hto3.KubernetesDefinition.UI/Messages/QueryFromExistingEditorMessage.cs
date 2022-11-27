using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    /// <summary>
    /// This message should be used when someone wants to ask if an editor of a particular KubernetesInstanceObject view exists, if so, the <i>IsAnEditorAlive</i> will be true.
    /// </summary>
    public class QueryFromExistingEditorMessage : MvxMessage
    {
        public QueryFromExistingEditorMessage(object sender, Int32 kubernetesObjectInstanceHashCode) : base(sender)
        {
            this.KubernetesObjectInstanceHashCode = kubernetesObjectInstanceHashCode;
        }
        public Int32 KubernetesObjectInstanceHashCode { get; }
        public Boolean IsAnEditorAlive { get; set; }
    }
}
