using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public class EditorViewBaseUserControl : MvxWpfView
    {
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            base.DataContextChanged += EditorViewBaseUserControl_DataContextChanged;

            this.Unloaded += EditorViewBaseUserControl_Unloaded;
        }

        private void EditorViewBaseUserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            base.ViewModel = (IMvxViewModel)e.NewValue;
        }

        private void EditorViewBaseUserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            base.DataContextChanged -= EditorViewBaseUserControl_DataContextChanged;
            this.Unloaded -= EditorViewBaseUserControl_Unloaded;
        }
    }
}
