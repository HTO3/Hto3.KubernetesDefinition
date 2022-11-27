using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public class EvaluationSummaryInfo
    {
        public Int32 ConfigsCount { get; set; }
        public Int32 FilesCount { get; set; }
        public Int32 PassedYamlValidationCount { get; set; }
        public String K8sValidation { get; set; }
        public Int32 PassedPolicyValidationCount { get; set; }
    }
}
