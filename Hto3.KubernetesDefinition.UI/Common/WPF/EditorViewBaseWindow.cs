using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hto3.KubernetesDefinition.UI.Common.WPF
{
    public class EditorViewBaseWindow : MvxWindow
    {
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            FixWindowSize();
            SetDefaultStyle();

            base.DataContextChanged += EditorViewBaseWindow_DataContextChanged;
            this.Closed += EditorViewBaseWindow_Closed;
        }

        private void EditorViewBaseWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue == null || !(e.NewValue is EditorViewModel))
                return;
            
            SetWin32NativeActions();
        }

        private void EditorViewBaseWindow_Closed(object sender, EventArgs e)
        {
            UnsetWin32NativeActions();
            base.DataContextChanged -= EditorViewBaseWindow_DataContextChanged;
            this.Closed -= EditorViewBaseWindow_Closed;
        }

        private void FixWindowSize()
        {
            this.Height += 55;
            this.Width += 16;
        }

        private void SetDefaultStyle()
        {
            this.SetResourceReference(StyleProperty, "EditorStyle");
        }

        private void UnsetWin32NativeActions()
        {
            var viewModel = (EditorViewModel)this.DataContext;
            viewModel.ActivateEditorView = null;
            viewModel.ShowWaningDialog = null;
        }

        private void SetWin32NativeActions()
        {
            var viewModel = (EditorViewModel)this.DataContext;
            viewModel.ActivateEditorView = () =>
            {
                if (this.WindowState == WindowState.Minimized)
                    this.WindowState = WindowState.Normal;

                this.Activate();
            };

            viewModel.ShowWaningDialog = new Action<string>(text => MessageBox.Show(text, "Alert", MessageBoxButton.OK, MessageBoxImage.Exclamation));
        }
    }
}
