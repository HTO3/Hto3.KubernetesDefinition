using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.Messages;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(CronJobViewModel), "/Views/CronJobView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class CronJobViewModel : EditorViewModel
    {
        private readonly MvxSubscriptionToken currentNamespacesSubscriptionToken;

        public CronJobViewModel(IMvxNavigationService navigationService, IViewModelMapper<CronJob, CronJobViewModel> viewModelMapper, IMvxMessenger messenger)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.currentNamespacesSubscriptionToken = messenger.Subscribe<CurrentNamespacesMessage>(CurrentNamespacesMessage_Subscription);
            this.SuccessfulJobsHistoryLimit = 3;
            this.FailedJobsHistoryLimit = 1;
            this.Month = 1;
            this.IsCurrentScheduleClockIsCompatible = true;
        }

        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public DayOfWeek DayOfWeek { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Boolean UseDayOfWeek { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Int32 Month { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Boolean UseMonth { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Int32 DayOfMonth { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Boolean UseDayOfMonth { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Int32 Hour { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Boolean UseHour { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Int32 Minute { get; set; }
        [OnChangedMethod(nameof(UpdateAdvancedExpression))]
        public Boolean UseMinute { get; set; }
        public String Name { get; set; }
        public String Namespace { get; set; }
        public Int32 FailedJobsHistoryLimit { get; set; }
        public Int32 SuccessfulJobsHistoryLimit { get; set; }
        public ConcurrencyPolicy ConcurrencyPolicyOption { get; set; }
        [OnChangedMethod(nameof(UpdateBasicFields))]
        public String Schedule { get; set; }
        public Boolean IsCurrentScheduleClockIsCompatible { get; set; }
        public ScheduleInputMode InputMode { get; set; }

        public MvxObservableCollection<String> LocalNamespacesList { get; set; }

        public IReadOnlyDictionary<Int32, String> Months => DateTimeFormatInfo.CurrentInfo.MonthNames
            .Take(12)
            .Select((mn, index) => new { Index = index + 1, Name = CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(mn) })
            .ToDictionary(a => a.Index, a => a.Name);

        public MvxCommand TemplateYearlyCommand => new MvxCommand(() =>
        {
            this.UseMinute = true;
            this.Minute = 0;
            this.UseHour = true;
            this.Hour = 0;
            this.UseDayOfMonth = true;
            this.DayOfMonth = 1;
            this.UseMonth = true;
            this.Month = 1;
            this.UseDayOfWeek = false;
        });

        public MvxCommand TemplateMonthlyCommand => new MvxCommand(() =>
        {
            this.UseMinute = true;
            this.Minute = 0;
            this.UseHour = true;
            this.Hour = 0;
            this.UseDayOfMonth = true;
            this.DayOfMonth = 1;
            this.UseMonth = false;
            this.UseDayOfWeek = false;
        });

        public MvxCommand TemplateWeeklyCommand => new MvxCommand(() =>
        {
            this.UseMinute = true;
            this.Minute = 0;
            this.UseHour = true;
            this.Hour = 0;
            this.UseDayOfMonth = false;
            this.UseMonth = false;
            this.UseDayOfWeek = true;
            this.DayOfWeek = DayOfWeek.Sunday;
        });

        public MvxCommand TemplateDailyCommand => new MvxCommand(() =>
        {
            this.UseMinute = true;
            this.Minute = 0;
            this.UseHour = true;
            this.Hour = 0;
            this.UseDayOfMonth = false;
            this.UseMonth = false;
            this.UseDayOfWeek = false;
        });

        public MvxCommand TemplateHourlyCommand => new MvxCommand(() =>
        {
            this.UseMinute = true;
            this.Minute = 0;
            this.UseHour = false;
            this.UseDayOfMonth = false;
            this.UseMonth = false;
            this.UseDayOfWeek = false;
        });

        private void UpdateAdvancedExpression()
        {
            if (this.InputMode == ScheduleInputMode.Advanced)
                return;

            this.Schedule = (this.UseMinute ? this.Minute.ToString() : "*") + " ";
            this.Schedule += (this.UseHour ? this.Hour.ToString() : "*") + " ";
            this.Schedule += (this.UseDayOfMonth ? this.DayOfMonth.ToString() : "*") + " ";
            this.Schedule += (this.UseMonth ? this.Month.ToString() : "*") + " ";
            this.Schedule += (this.UseDayOfWeek ? ((Int32)this.DayOfWeek).ToString() : "*");
        }

        private void UpdateBasicFields()
        {
            if (this.InputMode == ScheduleInputMode.Basic)
                return;

            try
            {
                var scheduleParts = this.Schedule?.Trim()?.Split(' ') ?? new[] { "*", "*", "*", "*", "*" };

                if (scheduleParts.Length <= 0 || scheduleParts[0] == "*")
                    this.UseMinute = false;
                else
                {
                    this.UseMinute = true;
                    this.Minute = Int32.Parse(scheduleParts[0]);
                }

                if (scheduleParts.Length <= 1 || scheduleParts[1] == "*")
                    this.UseHour = false;
                else
                {
                    this.UseHour = true;
                    this.Hour = Int32.Parse(scheduleParts[1]);
                }

                if (scheduleParts.Length <= 2 || scheduleParts[2] == "*")
                    this.UseDayOfMonth = false;
                else
                {
                    this.UseDayOfMonth = true;
                    this.DayOfMonth = Int32.Parse(scheduleParts[2]);
                }

                if (scheduleParts.Length <= 3 || scheduleParts[3] == "*")
                    this.UseMonth = false;
                else
                {
                    this.UseMonth = true;
                    this.Month = Int32.Parse(scheduleParts[3]);
                }

                if (scheduleParts.Length <= 4 || scheduleParts[4] == "*")
                    this.UseDayOfWeek = false;
                else
                {
                    var dayOfWeekNumber = Int32.Parse(scheduleParts[4]);
                    if (!Enum.IsDefined(typeof(DayOfWeek), dayOfWeekNumber))
                        throw new InvalidCastException("Unrecognizable DayOfWeek");
                    this.UseDayOfWeek = true;
                    this.DayOfWeek = (DayOfWeek)dayOfWeekNumber;
                }

                this.IsCurrentScheduleClockIsCompatible = true;
            }
            catch
            {
                this.IsCurrentScheduleClockIsCompatible = false;
            }            
        }

        private void CurrentNamespacesMessage_Subscription(CurrentNamespacesMessage message)
        {
            this.LocalNamespacesList = new MvxObservableCollection<String>(message.Namespaces);
        }

        public override void Prepare()
        {
            base.Prepare();
            base.messenger.Publish(new NamespacesSignalMessage(this));
        }

        public enum ScheduleInputMode
        {
            Basic,
            Advanced
        }

        public enum ConcurrencyPolicy
        {
            Allow,
            Forbid,
            Replace
        }
    }
}
