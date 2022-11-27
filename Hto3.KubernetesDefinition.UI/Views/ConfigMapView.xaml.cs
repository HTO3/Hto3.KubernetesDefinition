using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.ViewModels;
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

namespace Hto3.KubernetesDefinition.UI.Views
{
    /// <summary>
    /// Interaction logic for ConfigMapView.xaml
    /// </summary>
    [MvxWindowPresentation]
    [MvxViewFor(typeof(ConfigMapViewModel))]
    public partial class ConfigMapView : EditorViewBaseWindow
    {
        public ConfigMapView()
        {
            InitializeComponent();
        }
    }
}
