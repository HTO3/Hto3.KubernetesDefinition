using Hto3.KubernetesDefinition.UI.Common.WPF;
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
    [MvxWindowPresentation]
    [MvxViewFor(typeof(PodViewModel))]
    public partial class PodView : EditorViewBaseWindow
    {
        public PodView()
        {
            InitializeComponent();
        }
    }
}
