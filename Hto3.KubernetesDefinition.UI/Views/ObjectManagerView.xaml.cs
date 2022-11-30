using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Hto3.KubernetesDefinition.UI.Views
{
    public partial class ObjectManagerView : EditorViewBaseUserControl
    {
        public ObjectManagerView()
        {
            InitializeComponent();
        }

        private void MvxWpfView_Loaded(object sender, RoutedEventArgs e)
        {
            //Programatically set binding instead in XAML to avoid Visual Studio XDesProc.exe bug infinite loop
            if (!DesignerProperties.GetIsInDesignMode(this))
                this.InnerItens_ItemsControl.SetBinding(ItemsControl.ItemsSourceProperty, new Binding("ChildrenKubernetesDataObjects"));

            var viewModel = (ObjectManagerViewModel)this.DataContext;
            viewModel.ShowWaningDialog = new Action<string>(text => MessageBox.Show(text, "Alert", MessageBoxButton.OK, MessageBoxImage.Exclamation));
        }

        public Orientation InnerElementsOrientation
        {
            get { return (Orientation)GetValue(InnerElementsOrientationProperty); }
            set { SetValue(InnerElementsOrientationProperty, value); }
        }

        public static readonly DependencyProperty InnerElementsOrientationProperty =
            DependencyProperty.Register("InnerElementsOrientation", typeof(Orientation), typeof(ObjectManagerView), new PropertyMetadata(Orientation.Horizontal));


        public Thickness InnerBorderThickness
        {
            get { return (Thickness)GetValue(InnerBorderThicknessProperty); }
            set { SetValue(InnerBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty InnerBorderThicknessProperty =
            DependencyProperty.Register("InnerBorderThickness", typeof(Thickness), typeof(ObjectManagerView), new PropertyMetadata(new Thickness(1)));
    }
}
