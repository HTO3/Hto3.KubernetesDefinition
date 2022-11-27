using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(BestPracticesResultViewModel), "/Views/BestPracticesResultView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class BestPracticesResultViewModel : MvxViewModel<ValidationOutput>
    {
        public BestPracticesResultViewModel()
        {
            this.ValidationResults = new MvxObservableCollection<RuleResult>();
        }

        public MvxObservableCollection<RuleResult> ValidationResults { get; }

        public override void Prepare(ValidationOutput parameter)
        {
            this.ValidationResults.AddRange(parameter.PolicyValidationResults.SelectMany(r => r.RuleResults));
        }
    }
}
