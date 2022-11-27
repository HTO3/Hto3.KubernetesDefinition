using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public static class ExtensionMethods
    {
        public static Boolean IsNullOrDummy(this Object obj)
        {
            return obj == null || obj is DummyKubernetesObject;
        }
    }
}
