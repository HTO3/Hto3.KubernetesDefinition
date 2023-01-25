using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using Ookii.Dialogs.Wpf;
using Hto3.KubernetesDefinition.UI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Hto3.KubernetesDefinition.UI.Common.WPF;

namespace Hto3.KubernetesDefinition.UI.Views
{
    /// <summary>
    /// Interaction logic for CanvasView.xaml
    /// </summary>
    [MvxWindowPresentation]
    [MvxViewFor(typeof(CanvasViewModel))]
    public partial class CanvasView : MvxWindow
    {
        public CanvasView()
        {
            InitializeComponent();

            this.Height = Settings.Default.InitialWindowSize.Height;
            this.Width = Settings.Default.InitialWindowSize.Width;
            this.WindowState = Settings.Default.InitialWindowState;
        }

        private void MvxWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var datacontext = (CanvasViewModel)this.DataContext;
            datacontext.OpenYmlOpenFileDialog = () =>
            {
                var openFileDialog = new VistaOpenFileDialog();
                openFileDialog.Filter = "YAML Ain't Markup Language (*.yml;*.yaml)|*.yml;*.yaml";
                openFileDialog.Title = "Open Kubernetes Object Definition";
                openFileDialog.DefaultExt = ".yml";

                var result = new OpenFileDialogResult();
                result.Cancel = openFileDialog.ShowDialog() != true;
                result.ChosenFileName = openFileDialog.FileName;

                return result;
            };

            datacontext.SaveYmlSaveFileDialog = () =>
            {
                var saveFileDialog = new VistaSaveFileDialog();
                saveFileDialog.Filter = "YAML Ain't Markup Language (*.yml;*.yaml)|*.yml;*.yaml";
                saveFileDialog.Title = "Save Kubernetes Object Definition";
                saveFileDialog.DefaultExt = ".yml";

                var result = new SaveFileDialogResult();
                result.Cancel = saveFileDialog.ShowDialog() != true;
                result.ChosenPath = saveFileDialog.FileName;

                return result;
            };
        }

        private void MvxWindow_Closed(object sender, EventArgs e)
        {
            Settings.Default.InitialWindowState = this.WindowState;
            Settings.Default.Save();
        }

        private void MvxWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.IsLoaded && this.WindowState == WindowState.Normal)
                Settings.Default.InitialWindowSize = new System.Drawing.Size((Int32)e.NewSize.Width, (Int32)e.NewSize.Height);
        }
    }
}
