using Hto3.KubernetesDefinition.UI.Common;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hto3.KubernetesDefinition.UI.Components
{
    /// <summary>
    /// Interaction logic for ExposePortEditor.xaml
    /// </summary>
    public partial class ServicePortEditor : UserControl
    {
        public ServicePortEditor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var datacontext = this.DataContext as ICollection<ServicePortSetup>;

            if (datacontext == null)
                return;
            if (!updownExposedPort.Value.HasValue)
                return;
            if (!updownInternalPort.Value.HasValue)
                return;
            if (String.IsNullOrWhiteSpace(txtName.Text))
                return;
            if (cmbProtocol.SelectedIndex == -1)
                return;

            datacontext.Add(new ServicePortSetup(txtName.Text, (Int32)updownExposedPort.Value, updownInternalPort.Value.ToString(), cmbProtocol.Text));

            cmbProtocol.SelectedIndex = -1;
            updownExposedPort.Value = 0;
            updownInternalPort.Value = 0;
            txtName.Text = String.Empty;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            var item = element.DataContext as ServicePortSetup;

            if (item == null)
                return;

            var datacontext = this.DataContext as ICollection<ServicePortSetup>;

            if (datacontext == null)
                return;

            datacontext.Remove(item);
        }
    }
}
