using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Common.WPF;
using Hto3.KubernetesDefinition.UI.ViewModels;
using Hto3.KubernetesDefinition.UI.Views;
using MvvmCross;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace Hto3.KubernetesDefinition.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        public App()
        {
            //Register Syncfusion license
            var syncfusionLicense = Assembly.GetExecutingAssembly().GetCustomAttribute<ConfigurationAttribute>()?.SyncfusionLicense ?? Environment.GetEnvironmentVariable("MY_DEV_SYNCFUSION_LICENSE");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncfusionLicense);
        }

        protected override void RegisterSetup()
        {
            this.RegisterSetupType<Startup>();
        }

        private void MvxApplication_Startup(object sender, StartupEventArgs e)
        {
            var startupWindow = new CanvasView();
            var request = new MvvmCross.ViewModels.MvxViewModelInstanceRequest(typeof(CanvasViewModel));
            var vm = Mvx.IoCProvider.Resolve<MvvmCross.ViewModels.IMvxViewModelLoader>().LoadViewModel(request, null);
            startupWindow.ViewModel = vm;
            startupWindow.Show();
        }
    }
}
