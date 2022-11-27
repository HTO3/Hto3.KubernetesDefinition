using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.Contracts
{
    public interface IAnalyzeService
    {
        ValidationOutput ValidateBestPractices(IEnumerable<IObjectGraph> graph);
    }
}
