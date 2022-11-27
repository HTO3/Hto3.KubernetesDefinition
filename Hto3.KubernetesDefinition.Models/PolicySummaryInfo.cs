using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public partial class PolicySummaryInfo
    {
        public String PolicyName { get; set; }
        public Int32 TotalRulesInPolicy { get; set; }
        public Int32 TotalSkippedRules { get; set; }
        public Int32 TotalRulesFailed { get; set; }
        public Int32 TotalPassedCount { get; set; }
    }
}
