using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public class ValidationOutput
    {
        public PolicyValidationResult[] PolicyValidationResults { get; set; }
        public PolicySummaryInfo PolicySummary { get; set; }
        public EvaluationSummaryInfo EvaluationSummary { get; set; }
    }
}
