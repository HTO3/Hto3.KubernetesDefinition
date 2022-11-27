using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hto3.KubernetesDefinition.Models;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.Models.Contracts;
using System.Windows;
using Hto3.KubernetesDefinition.UI.ViewModels;
using Hto3.KubernetesDefinition.UI.Messages;
using MvvmCross;
using Hto3.KubernetesDefinition.UI.ObjectMetadata;
using System.Collections.Specialized;
using PropertyChanged;
using Hto3.StringHelpers;
using Hto3.CollectionHelpers;

[assembly: MvxNavigation(typeof(CanvasViewModel), "/Views/CanvasView")]
namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class CanvasViewModel : MvxViewModel
    {
        private readonly IOpenService openService;
        private readonly ISaveService saveService;
        private readonly IAnalyzeService analyzeService;
        private readonly IMvxMessenger messenger;
        private readonly IMvxNavigationService navigationService;
        private readonly MvxSubscriptionToken namespacesSignalSubscriptionToken;
        private readonly MvxSubscriptionToken configMapSignalMessageSubscriptionToken;
        private readonly MvxSubscriptionToken configMapItemsSignalMessageSubscriptionToken;
        private readonly MvxSubscriptionToken kubernetesObjectChangingSubscriptionToken;

        public CanvasViewModel
            (
                IOpenService openService,
                ISaveService saveService,
                IMvxMessenger messenger,
                IAnalyzeService analyzeService,
                IMvxNavigationService navigationService
            )
        {
            this.openService = openService;
            this.saveService = saveService;
            this.analyzeService = analyzeService;
            this.navigationService = navigationService;
            this.messenger = messenger;
            this.namespacesSignalSubscriptionToken = messenger.Subscribe<NamespacesSignalMessage>(NamespacesSignalMessage_Subscription);
            this.configMapSignalMessageSubscriptionToken = messenger.Subscribe<ConfigMapSignalMessage>(ConfigMapSignalMessage_Subscription);
            this.configMapItemsSignalMessageSubscriptionToken = messenger.Subscribe<ConfigMapItemsSignalMessage>(ConfigMapItemsSignalMessage_Subscription);
            this.kubernetesObjectChangingSubscriptionToken = messenger.Subscribe<KubernetesObjectChangingMessage>(KubernetesObjectChangingMessage_Subscription);
            this.RootObjectManager = Mvx.IoCProvider.IoCConstruct<ObjectManagerViewModel>();
            this.ZoomCurrentScale = 1;
            this.ShowTutorial = true;
        }

        public Func<SaveFileDialogResult> SaveYmlSaveFileDialog { get; set; }
        public Func<OpenFileDialogResult> OpenYmlOpenFileDialog { get; set; }
        public Double ZoomCurrentScale { get; set; }
        public Double ZoomTargetSize { get; set; }
        public ObjectManagerViewModel RootObjectManager { get; }
        public Boolean ShowTutorial { get; set; }
        [AlsoNotifyFor(nameof(Title))]
        public String CurrentFilePath { get; set; }
        [AlsoNotifyFor(nameof(Title))]
        public Boolean UnsavedChanges { get; set; }
        public String Title => $"Kubernetes Definition {(String.IsNullOrEmpty(this.CurrentFilePath) ? "" : "-")} {this.CurrentFilePath} {(this.UnsavedChanges ? "*" : "")}".TrimExtraSpaces();

        public MvxCommand NewCommand => new MvxCommand(() =>
        {
            this.RootObjectManager.ChildrenKubernetesDataObjects.Clear();
            this.CurrentFilePath = null;
            this.UnsavedChanges = false;
        });

        public MvxCommand SaveCommand => new MvxCommand(() =>
        {
            if (String.IsNullOrEmpty(this.CurrentFilePath))
            {
                var result = SaveYmlSaveFileDialog?.Invoke();
                if (result.Cancel)
                    return;
                this.CurrentFilePath = result.ChosenPath;
            }

            this.saveService.WriteYml(this.RootObjectManager.ChildrenKubernetesDataObjects, this.CurrentFilePath);
            this.UnsavedChanges = false;
        });

        public MvxCommand SaveAsCommand => new MvxCommand(() =>
        {
            var result = SaveYmlSaveFileDialog?.Invoke();
            if (result.Cancel)
                return;
            this.saveService.WriteYml(this.RootObjectManager.ChildrenKubernetesDataObjects, result.ChosenPath);
            this.CurrentFilePath = result.ChosenPath;
            this.UnsavedChanges = false;
        });

        public MvxCommand OpenCommand => new MvxCommand(() =>
        {
            var result = OpenYmlOpenFileDialog?.Invoke();
            if (result.Cancel)
                return;

            this.NewCommand.Execute();

            var kubernetesDataObjects = this.openService.ReadYml(result.ChosenFileName);

            foreach (var kubernetesDataObject in kubernetesDataObjects)
            {
                var addMetadata =
                    this.RootObjectManager.OptionsToExecute
                        .SingleOrDefault(o => o.KubernetesObjectType == kubernetesDataObject.GetType());

                this.RootObjectManager.AddCommand.Execute(addMetadata);
                var recentlyAdded = this.RootObjectManager.ChildrenKubernetesDataObjects.Last();
                recentlyAdded.KubernetesDataObject = kubernetesDataObject;
                recentlyAdded.ResolveVisualizationChildren();
            }

            this.CurrentFilePath = result.ChosenFileName;
            this.UnsavedChanges = false;
        });                

        public MvxCommand CopyYmlCommand => new MvxCommand(() =>
        {
            var toClipboard = saveService.WriteYml(this.RootObjectManager.ChildrenKubernetesDataObjects);
            Clipboard.SetText(toClipboard);
        });

        public MvxAsyncCommand ValidateCommand => new MvxAsyncCommand(async () =>
        {
            var result = this.analyzeService.ValidateBestPractices(this.RootObjectManager.ChildrenKubernetesDataObjects);
            if (result.PolicyValidationResults != null)
                await navigationService.Navigate<BestPracticesResultViewModel, ValidationOutput>(result);
        });

        public MvxCommand<Double> ZoomCommand => new MvxCommand<Double>((reference) =>
        {
            this.ZoomTargetSize = reference * this.ZoomCurrentScale;
        });

        public override void Prepare()
        {
            this.RootObjectManager.OptionsToExecute.Add(this.RootObjectManager.CreateAddMenuOption<DeploymentMetadata>());
            this.RootObjectManager.OptionsToExecute.Add(this.RootObjectManager.CreateAddMenuOption<ServiceMetadata>());
            this.RootObjectManager.OptionsToExecute.Add(this.RootObjectManager.CreateAddMenuOption<NamespaceMetadata>());
            this.RootObjectManager.OptionsToExecute.Add(this.RootObjectManager.CreateAddMenuOption<CronJobMetadata>());
            this.RootObjectManager.OptionsToExecute.Add(this.RootObjectManager.CreateAddMenuOption<ConfigMapMetadata>());

            ((INotifyCollectionChanged)this.RootObjectManager.ChildrenKubernetesDataObjects).CollectionChanged += NotifiableCollection_CollectionChanged;
        }

        private void NotifiableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.ShowTutorial = this.RootObjectManager.ChildrenKubernetesDataObjects.Count == 0;
        }

        private void NamespacesSignalMessage_Subscription(NamespacesSignalMessage message)
        {
            var namespaces =
                this.RootObjectManager.ChildrenKubernetesDataObjects
                    .Select(r => r.KubernetesDataObject)
                    .OfType<Models.KubernetesObjects.Namespace>()
                    .Select(n => n.Metadata?.Name)
                    .Where(n => !String.IsNullOrWhiteSpace(n))
                    .ToArray();

            this.messenger.Publish(new CurrentNamespacesMessage(this, namespaces));
        }

        private void ConfigMapSignalMessage_Subscription(ConfigMapSignalMessage message)
        {
            var configMapNames =
                this.RootObjectManager.ChildrenKubernetesDataObjects
                    .Select(r => r.KubernetesDataObject)
                    .OfType<Models.KubernetesObjects.ConfigMap>()
                    .Select(n => n.Metadata?.Name)
                    .Where(n => !String.IsNullOrWhiteSpace(n))
                    .ToArray();

            this.messenger.Publish(new CurrentConfigMapsMessage(this, configMapNames));
        }

        private void ConfigMapItemsSignalMessage_Subscription(ConfigMapItemsSignalMessage message)
        {
            var configMap =
                this.RootObjectManager.ChildrenKubernetesDataObjects
                    .Select(r => r.KubernetesDataObject)
                    .OfType<Models.KubernetesObjects.ConfigMap>()
                    .FirstOrDefault(n => n.Metadata?.Name == message.ConfigMapName);

            if (configMap == null)
                return;

            var keys = configMap.BinaryData?.Keys.EmptyIfNull()
                .Union(configMap.Data?.Keys.EmptyIfNull())
                .ToArray();

            this.messenger.Publish(new CurrentConfigMapItemsMessage(this, message.ConfigMapName, keys));
        }

        private void KubernetesObjectChangingMessage_Subscription(KubernetesObjectChangingMessage message)
        {
            this.UnsavedChanges = true;
        }

        public override void ViewDisappeared()
        {
            this.namespacesSignalSubscriptionToken.Dispose();
            this.kubernetesObjectChangingSubscriptionToken.Dispose();
            this.configMapSignalMessageSubscriptionToken.Dispose();
            this.configMapItemsSignalMessageSubscriptionToken.Dispose();
            ((INotifyCollectionChanged)this.RootObjectManager.ChildrenKubernetesDataObjects).CollectionChanged -= NotifiableCollection_CollectionChanged;
        }
    }
}