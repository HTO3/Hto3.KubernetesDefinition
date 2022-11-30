using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.Contracts;
using Hto3.KubernetesDefinition.UI.Common;
using Hto3.KubernetesDefinition.UI.Messages;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ObjectManagerViewModel : MvxViewModel, IObjectGraph
    {
        private readonly IMvxNavigationService navigationService;
        private readonly IMvxViewModelLoader loader;
        private readonly IMvxMessenger messenger;
        private readonly MvxSubscriptionToken kubernetesObjectChangingSubscriptionToken;

        public ObjectManagerViewModel(IMvxNavigationService navigationService, IMvxViewModelLoader loader, IMvxMessenger messenger)
        {
            this.navigationService = navigationService;
            this.loader = loader;
            this.messenger = messenger;
            this.kubernetesObjectChangingSubscriptionToken = messenger.Subscribe<KubernetesObjectChangingMessage>(KubernetesObjectChangingMessage_Subscription);
            this.ChildrenKubernetesDataObjects = new MvxObservableCollection<IObjectGraph>();
            this.OptionsToExecute = new MvxObservableCollection<ExecuteContextMenuOption>();
            this.KubernetesDataObject = new DummyKubernetesObject();
        }

        public Object KubernetesDataObject { get; set; }
        public IObjectMetadataUI Metadata { get; protected set; }
        IObjectMetadata IObjectGraph.Metadata => this.Metadata;
        public ICollection<IObjectGraph> ChildrenKubernetesDataObjects { get; }
        public MvxObservableCollection<ExecuteContextMenuOption> OptionsToExecute { get; }
        public Action<String> ShowWaningDialog { get; set; }

        public MvxAsyncCommand EditCommand => new MvxAsyncCommand(async () =>
        {
            var queryIfEditorAlreadyExists = new QueryFromExistingEditorMessage(this, this.KubernetesDataObject.GetHashCode());
            messenger.Publish(queryIfEditorAlreadyExists);
            if (!queryIfEditorAlreadyExists.IsAnEditorAlive)
                await this.navigationService.Navigate<Object>(this.Metadata.EditorPath, this.KubernetesDataObject);
        });

        public MvxCommand RemoveCommand => new MvxCommand(() =>
        {
            var message = new KubernetesObjectChangingMessage(this, this.KubernetesDataObject.GetHashCode(), null);
            this.messenger.Publish(message);
        });

        public MvxCommand<ExecuteContextMenuOption> AddCommand => new MvxCommand<ExecuteContextMenuOption>((executeContext) =>
        {
            var mustBeUnique =
                executeContext.UniqueChild
                &&
                this.ChildrenKubernetesDataObjects
                    .Any(c => c.Metadata.KubernetesObjectType == executeContext.KubernetesObjectType);

            if (mustBeUnique)
            {
                this.ShowWaningDialog?.Invoke($"You can't \"{executeContext.Name}\" because it needs to be unique.");
                return;
            }

            var newObject = (IObjectGraph)this.loader.LoadViewModel(new MvxViewModelRequest(executeContext.ManagerType), null);
            this.ChildrenKubernetesDataObjects.Add(newObject);
        });

        public override void Prepare()
        {
            this.OptionsToExecute.Add(new ExecuteContextMenuOption() { ExecuteCommand = this.RemoveCommand, Name = "Remove" });
            this.OptionsToExecute.Add(new ExecuteContextMenuOption() { ExecuteCommand = this.EditCommand, Name = "Edit" });
        }

        public virtual void ResolveKubernetesObjectChildren()
        {
        }

        public virtual void ResolveVisualizationChildren()
        {
        }

        public ExecuteContextMenuOption CreateAddMenuOption<T>() where T : IObjectMetadataUI, new()
        {
            var instance = (IObjectMetadataUI)Activator.CreateInstance(typeof(T));

            return new ExecuteContextMenuOption()
            {
                Name = $"Add {instance.Name}",
                IconName = instance.IconName,
                ExecuteCommand = this.AddCommand,
                ManagerType = instance.ManagerType,
                KubernetesObjectType = instance.KubernetesObjectType,
                UniqueChild = instance.Unique
            };
        }

        private void KubernetesObjectChangingMessage_Subscription(KubernetesObjectChangingMessage message)
        {
            if (this.KubernetesDataObject?.GetHashCode() == message.PreviousInstanceHashCode)
                this.KubernetesDataObject = message.NewKubernetesObject;

            if (message.NewKubernetesObject.IsNullOrDummy())
            {
                var objectFound = this.ChildrenKubernetesDataObjects
                    .SingleOrDefault(k => k.KubernetesDataObject.GetHashCode() == message.PreviousInstanceHashCode);

                if (objectFound != null)
                    this.ChildrenKubernetesDataObjects.Remove(objectFound);
            }
        }

        public override void ViewDisappeared()
        {
            this.kubernetesObjectChangingSubscriptionToken.Dispose();
        }
    }
}
