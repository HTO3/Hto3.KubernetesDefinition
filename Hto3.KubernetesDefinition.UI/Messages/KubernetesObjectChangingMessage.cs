using MvvmCross.Plugin.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Messages
{
    /// <summary>
    /// This message should be used when a kubernetes object effectively changes, by an Edit, New or Delete operation.
    /// </summary>
    public class KubernetesObjectChangingMessage : MvxMessage
    {
        public KubernetesObjectChangingMessage(Object sender, Int32 previousInstanceHashCode, Object newKubernetesObject) : base(sender)
        {
            this.PreviousInstanceHashCode = previousInstanceHashCode;
            this.NewKubernetesObject = newKubernetesObject;
        }

        public Int32 PreviousInstanceHashCode { get; }
        public Object NewKubernetesObject { get; }
    }
}
