using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Messages;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: MvxNavigation(typeof(VolumeViewModel), "/Views/VolumeView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class VolumeViewModel : EditorViewModel
    {
        public VolumeViewModel(IMvxNavigationService navigationService, IViewModelMapper<Volume, VolumeViewModel> viewModelMapper, IMvxMessenger messenger, IMvxViewModelLoader viewModelLoader)
            : base(navigationService, viewModelMapper, messenger)
        {
            this.HostPath = (HostPathViewModel)viewModelLoader.LoadViewModel(new MvxViewModelRequest(typeof(HostPathViewModel)), null);
            this.EmptyDir = (EmptyDirViewModel)viewModelLoader.LoadViewModel(new MvxViewModelRequest(typeof(EmptyDirViewModel)), null);
            this.ConfigMap = (ConfigMapVolumeViewModel)viewModelLoader.LoadViewModel(new MvxViewModelRequest(typeof(ConfigMapVolumeViewModel)), null);
        }        

        public String Name { get; set; }
        public VolumeType DesiredVolumeType { get; set; }
        public HostPathViewModel HostPath { get; }
        public EmptyDirViewModel EmptyDir { get; }
        public ConfigMapVolumeViewModel ConfigMap { get; }
    }
}
