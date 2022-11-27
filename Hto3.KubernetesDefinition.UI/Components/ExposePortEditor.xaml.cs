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
    public partial class ExposePortEditor : UserControl
    {
        public ExposePortEditor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var datacontext = this.DataContext as ICollection<Tuple<Int32, String>>;

            if (datacontext == null)
                return;
            if (!updownPort.Value.HasValue)
                return;
            if (cmbProtocol.SelectedIndex == -1)
                return;

            datacontext.Add(new Tuple<Int32, String>(Convert.ToInt32(updownPort.Value), cmbProtocol.Text));

            cmbProtocol.SelectedIndex = -1;
            updownPort.Value = 0;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            var item = element.DataContext as Tuple<Int32, String>;

            if (item == null)
                return;

            var datacontext = this.DataContext as ICollection<Tuple<Int32, String>>;

            if (datacontext == null)
                return;

            datacontext.Remove(item);
        }
    }
}
