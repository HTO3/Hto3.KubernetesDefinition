using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
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
    /// Interaction logic for VolumeView.xaml
    /// </summary>
    [MvxWindowPresentation]
    [MvxViewFor(typeof(VolumeViewModel))]
    public partial class VolumeView : EditorViewBaseWindow
    {
        public VolumeView()
        {
            InitializeComponent();
        }

        private void DesiredVolumeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var allControls = grdVolumeEditors.Children.OfType<UserControl>();
            foreach (var c in allControls)
                c.Visibility = Visibility.Collapsed;

            if (e.AddedItems.Count == 0)
                return;

            var item = (KeyValuePair<Object, String>)e.AddedItems[0];
            var volumeTypeInternalName = item.Key.ToString();

            var visibilityCandidate = allControls
                .SingleOrDefault(c => c.GetType().Name.IndexOf(volumeTypeInternalName, StringComparison.OrdinalIgnoreCase) != -1);

            if (visibilityCandidate != null)
            {
                visibilityCandidate.Visibility = Visibility.Visible;
                brdEmptyInformation.Visibility = Visibility.Collapsed;
            }
            else
                brdEmptyInformation.Visibility = Visibility.Visible;
        }
    }
}
