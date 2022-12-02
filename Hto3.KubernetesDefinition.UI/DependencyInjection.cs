using Hto3.KubernetesDefinition.Models.Contracts;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.Services;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.ObjectMappers;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI
{
    public class DependencyInjection : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterSingleton<IMvxMessenger>(new MvxMessengerHub());
            Mvx.IoCProvider.RegisterType<IOpenService, OpenService>();
            Mvx.IoCProvider.RegisterType<ISaveService, SaveService>();
            Mvx.IoCProvider.RegisterType<IKindResolverService, KindResolverService>();
            Mvx.IoCProvider.RegisterType<IAnalyzeService, AnalyzeService>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<Deployment, DeploymentViewModel>, DeploymentViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<Namespace, NamespaceViewModel>, NamespaceViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<Container, ContainerViewModel>, ContainerViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<DeploymentSpec, ReplicaSetViewModel>, ReplicaSetViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<Volume, VolumeViewModel>, VolumeViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<Service, ServiceViewModel>, ServiceViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<CronJob, CronJobViewModel>, CronJobViewModelMapper>();
            Mvx.IoCProvider.RegisterType<IViewModelMapper<ConfigMap, ConfigMapViewModel>, ConfigMapViewModelMapper>();
        }
    }
}
