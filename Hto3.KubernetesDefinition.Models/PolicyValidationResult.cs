using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public class PolicyValidationResult
    {
        public String FileName { get; set; }
        public RuleResult[] RuleResults { get; set; }
    }
}
