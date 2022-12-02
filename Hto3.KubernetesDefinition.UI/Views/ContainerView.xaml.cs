﻿using Hto3.KubernetesDefinition.UI.Common;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hto3.KubernetesDefinition.UI.Views
{
    /// <summary>
    /// Interaction logic for ContainerView.xaml
    /// </summary>
    [MvxWindowPresentation]
    [MvxViewFor(typeof(ContainerViewModel))]
    public partial class ContainerView : EditorViewBaseWindow
    {
        public ContainerView()
        {
            InitializeComponent();
        }
    }
}