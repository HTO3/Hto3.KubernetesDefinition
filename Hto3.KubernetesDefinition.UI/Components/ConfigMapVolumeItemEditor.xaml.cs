using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Common.Models;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hto3.KubernetesDefinition.UI.Components
{
    /// <summary>
    /// Interaction logic for ConfigMapFileEditor.xaml
    /// </summary>
    public partial class ConfigMapVolumeItemEditor : UserControl
    {
        public ConfigMapVolumeItemEditor()
        {
            InitializeComponent();
        }

        public IEnumerable Keys
        {
            get { return (IEnumerable)GetValue(KeysProperty); }
            set { SetValue(KeysProperty, value); }
        }

        public static readonly DependencyProperty KeysProperty =
            DependencyProperty.Register("Keys", typeof(IEnumerable), typeof(ConfigMapVolumeItemEditor), new PropertyMetadata(null));

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var datacontext = this.DataContext as ICollection<ConfigMapVolumeItem>;

            if (datacontext == null)
                return;
            if (String.IsNullOrWhiteSpace(cmbKey.Text))
                return;
            if (String.IsNullOrWhiteSpace(txtFilePath.Text))
                return;

            datacontext.Add(new ConfigMapVolumeItem(cmbKey.Text, txtFilePath.Text));

            cmbKey.SelectedIndex = -1;
            cmbKey.Text = String.Empty;
            txtFilePath.Text = String.Empty;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            var item = element.DataContext as ConfigMapVolumeItem;

            if (item == null)
                return;

            var datacontext = this.DataContext as ICollection<ConfigMapVolumeItem>;

            if (datacontext == null)
                return;

            datacontext.Remove(item);
        }
    }
}
