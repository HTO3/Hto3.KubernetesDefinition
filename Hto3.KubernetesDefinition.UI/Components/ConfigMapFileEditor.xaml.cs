using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Common.Models;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hto3.KubernetesDefinition.UI.Components
{
    /// <summary>
    /// Interaction logic for ConfigMapFileEditor.xaml
    /// </summary>
    public partial class ConfigMapFileEditor : UserControl
    {
        public ConfigMapFileEditor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var datacontext = this.DataContext as ICollection<ConfigMapFileEntry>;

            if (datacontext == null)
                return;
            if (String.IsNullOrWhiteSpace(txtName.Text))
                return;
            if (String.IsNullOrWhiteSpace(txtFilePath.Text))
                return;
            if (!File.Exists(txtFilePath.Text))
                return;

            datacontext.Add(new ConfigMapFileEntry(txtName.Text, Convert.ToBase64String(File.ReadAllBytes(txtFilePath.Text))));

            txtName.Text = String.Empty;
            txtFilePath.Text = String.Empty;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            var item = element.DataContext as ConfigMapFileEntry;

            if (item == null)
                return;

            var datacontext = this.DataContext as ICollection<ConfigMapFileEntry>;

            if (datacontext == null)
                return;

            datacontext.Remove(item);
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new VistaOpenFileDialog();
            openFileDialog.Title = "Open File";

            if (openFileDialog.ShowDialog() == true)
                txtFilePath.Text = openFileDialog.FileName;
        }
    }
}
