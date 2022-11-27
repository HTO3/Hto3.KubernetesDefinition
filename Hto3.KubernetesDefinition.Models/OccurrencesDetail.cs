using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public class OccurrencesDetail
    {
        public String MetadataName { get; set; }
        public String Kind { get; set; }
        public String SkipMessage { get; set; }
        public Int32 Occurrences { get; set; }
        public Boolean IsSkipped { get; set; }
    }
}
