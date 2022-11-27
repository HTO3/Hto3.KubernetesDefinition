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
    /// Interaction logic for KeyValueEditor.xaml
    /// </summary>
    public partial class KeyValueEditor : UserControl
    {
        public KeyValueEditor()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var datacontext = this.DataContext as ICollection<Tuple<String, String>>;

            if (datacontext == null)
                return;

            datacontext.Add(new Tuple<String, String>(txtName.Text, txtValue.Text));

            txtName.Text = String.Empty;
            txtValue.Text = String.Empty;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            var item = element.DataContext as Tuple<String, String>;

            if (item == null)
                return;

            var datacontext = this.DataContext as ICollection<Tuple<String, String>>;

            if (datacontext == null)
                return;

            datacontext.Remove(item);
        }
    }
}
