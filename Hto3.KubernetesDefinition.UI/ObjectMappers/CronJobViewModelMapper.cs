using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class CronJobViewModelMapper : IViewModelMapper<CronJob, CronJobViewModel>
    {
        public CronJob ConvertBack(CronJobViewModel source)
        {
            var cronJob = new CronJob();
            cronJob.ApiVersion = "batch/v1";
            cronJob.Kind = CronJobKind.CronJob;
            cronJob.Metadata = new ObjectMeta();
            cronJob.Metadata.Name = source.Name;
            cronJob.Metadata.Namespace = source.Namespace;
            cronJob.Spec = new CronJobSpec();
            cronJob.Spec.Schedule = source.Schedule;
            cronJob.Spec.SuccessfulJobsHistoryLimit = source.SuccessfulJobsHistoryLimit;
            cronJob.Spec.FailedJobsHistoryLimit = source.FailedJobsHistoryLimit;
            cronJob.Spec.ConcurrencyPolicy = source.ConcurrencyPolicyOption.ToString();
            return cronJob;
        }

        public void Fill(CronJob source, CronJobViewModel target)
        {
            target.Name = source.Metadata?.Name;
            target.Namespace = source.Metadata?.Namespace;
            if (source.Spec?.ConcurrencyPolicy == "Allow" || source.Spec?.ConcurrencyPolicy == null)
                target.ConcurrencyPolicyOption = CronJobViewModel.ConcurrencyPolicy.Allow;
            else if (source.Spec?.ConcurrencyPolicy == "Forbid")
                target.ConcurrencyPolicyOption = CronJobViewModel.ConcurrencyPolicy.Forbid;
            else
                target.ConcurrencyPolicyOption = CronJobViewModel.ConcurrencyPolicy.Replace;
            target.SuccessfulJobsHistoryLimit = source.Spec?.SuccessfulJobsHistoryLimit ?? 3;
            target.FailedJobsHistoryLimit = source.Spec?.FailedJobsHistoryLimit ?? 1;

            target.InputMode = CronJobViewModel.ScheduleInputMode.Advanced;
            target.Schedule = source.Spec?.Schedule;

            switch (target.Schedule)
            {
                case "@yearly":
                case "@annually":
                    target.TemplateYearlyCommand.Execute();
                    break;
                case "@monthly":
                    target.TemplateMonthlyCommand.Execute();
                    break;
                case "@weekly":
                    target.TemplateWeeklyCommand.Execute();
                    break;
                case "@daily":
                case "@midnight":
                    target.TemplateDailyCommand.Execute();
                    break;
                case "@hourly":
                    target.TemplateHourlyCommand.Execute();
                    break;
            }

            target.InputMode = target.IsCurrentScheduleClockIsCompatible ? CronJobViewModel.ScheduleInputMode.Basic : CronJobViewModel.ScheduleInputMode.Advanced;
        }

        public Object ConvertBack(Object source) => ConvertBack((CronJobViewModel)source);
        public void Fill(Object source, Object target) => Fill((CronJob)source, (CronJobViewModel)target);
    }
}
