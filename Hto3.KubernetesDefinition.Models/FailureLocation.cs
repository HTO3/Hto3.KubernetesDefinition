using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public class FailureLocation
    {
        public String SchemaPath { get; set; }
        public Int32 FailedErrorLine { get; set; }
        public Int32 FailedErrorColumn { get; set; }
    }
}
