using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public class RuleResult
    {
        public String Identifier { get; set; }
        public String Name { get; set; }
        public String MessageOnFailure { get; set; }
        public OccurrencesDetail[] OccurrencesDetails { get; set; }
    }
}
