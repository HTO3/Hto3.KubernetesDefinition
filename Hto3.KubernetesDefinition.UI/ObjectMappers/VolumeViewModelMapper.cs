using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.Common.Models;
using Hto3.KubernetesDefinition.UI.ViewModels;
using Hto3.StringHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class VolumeViewModelMapper : IViewModelMapper<Volume, VolumeViewModel>
    {
        public Volume ConvertBack(VolumeViewModel source)
        {
            var volume = new Volume();

            foreach (var p in typeof(Volume).GetProperties())
                p.SetValue(volume, null);

            volume.Name = source.Name;

            switch (source.DesiredVolumeType)
            {
                case VolumeType.unknown:
                    break;
                case VolumeType.awsElasticBlockStore:
                    break;
                case VolumeType.azureDisk:
                    break;
                case VolumeType.azureFile:
                    break;
                case VolumeType.cephfs:
                    break;
                case VolumeType.cinder:
                    break;
                case VolumeType.configMap:
                    volume.ConfigMap = new ConfigMapVolumeSource();
                    volume.ConfigMap.Name = source.ConfigMap.ConfigMapName;
                    if (source.ConfigMap.Items.EmptyIfNull().Any())
                    {
                        volume.ConfigMap.Items = source.ConfigMap.Items
                            .Select(i => new KeyToPath() { Key = i.Key, Path = i.Path })
                            .ToList();
                    }
                    break;
                case VolumeType.downwardAPI:
                    break;
                case VolumeType.emptyDir:
                    volume.EmptyDir = new EmptyDirVolumeSource();
                    volume.EmptyDir.Medium = source.EmptyDir.MediumType == Medium.Memory ? "Memory" : String.Empty;
                    if (source.EmptyDir.SizeLimit.HasValue)
                        volume.EmptyDir.SizeLimit = $"{source.EmptyDir.SizeLimit}{source.EmptyDir.SizeLimitSize}".TrimEnd('b');
                    break;
                case VolumeType.fc:
                    break;
                case VolumeType.gcePersistentDisk:
                    break;
                case VolumeType.glusterfs:
                    break;
                case VolumeType.hostPath:
                    volume.HostPath = new HostPathVolumeSource();
                    volume.HostPath.Path = source.HostPath.Path;
                    volume.HostPath.Type = source.HostPath.Type.ToString();
                    break;
                case VolumeType.iscsi:
                    break;
                case VolumeType.nfs:
                    break;
                case VolumeType.persistentVolumeClaim:
                    break;
                case VolumeType.portworxVolume:
                    break;
                case VolumeType.projected:
                    break;
                case VolumeType.rbd:
                    break;
                case VolumeType.secret:
                    break;
                default:
                    break;
            }

            return volume;
        }

        public void Fill(Volume source, VolumeViewModel target)
        {
            target.Name = source.Name;

            if (source.AwsElasticBlockStore != null)
                target.DesiredVolumeType = VolumeType.awsElasticBlockStore;
            else if (source.AzureDisk != null)
                target.DesiredVolumeType = VolumeType.azureDisk;
            else if (source.AzureFile != null)
                target.DesiredVolumeType = VolumeType.azureFile;
            else if (source.Cephfs != null)
                target.DesiredVolumeType = VolumeType.cephfs;
            else if (source.Cinder != null)
                target.DesiredVolumeType = VolumeType.cinder;
            else if (source.ConfigMap != null)
            {
                target.DesiredVolumeType = VolumeType.configMap;
                target.ConfigMap.Clear();
                target.ConfigMap.ConfigMapName = source.ConfigMap.Name;
                target.ConfigMap.Items.AddRange
                    (
                        source.ConfigMap?.Items
                            .EmptyIfNull()
                            .Select(i => new ConfigMapVolumeItem(i.Key, i.Path))
                    );
            }
            else if (source.DownwardAPI != null)
                target.DesiredVolumeType = VolumeType.downwardAPI;
            else if (source.EmptyDir != null)
            {
                target.DesiredVolumeType = VolumeType.emptyDir;
                target.EmptyDir.Clear();
                if (source.EmptyDir.Medium == "Memory")
                    target.EmptyDir.MediumType = Medium.Memory;
                if (!String.IsNullOrEmpty(source.EmptyDir.SizeLimit))
                {
                    var memoryNumbersOnly = source.EmptyDir.SizeLimit.NumbersOnly();
                    var memoryLettersOnly = source.EmptyDir.SizeLimit.LettersOnly();

                    if (String.IsNullOrEmpty(memoryLettersOnly))
                        target.EmptyDir.SizeLimitSize = MemorySize.b;
                    else
                        target.EmptyDir.SizeLimitSize = (MemorySize)Enum.Parse(typeof(MemorySize), memoryLettersOnly);

                    target.EmptyDir.SizeLimit = Decimal.Parse(memoryNumbersOnly);
                }
            }
            else if (source.Fc != null)
                target.DesiredVolumeType = VolumeType.fc;
            else if (source.GcePersistentDisk != null)
                target.DesiredVolumeType = VolumeType.gcePersistentDisk;
            else if (source.Glusterfs != null)
                target.DesiredVolumeType = VolumeType.glusterfs;
            else if (source.HostPath != null)
            {
                target.DesiredVolumeType = VolumeType.hostPath;
                target.HostPath.Clear();
                target.HostPath.Path = source.HostPath.Path;
                if (String.IsNullOrEmpty(source.HostPath.Type))
                    target.HostPath.Type = HostPathType.Any;
                else
                    target.HostPath.Type = (HostPathType)Enum.Parse(typeof(HostPathType), source.HostPath.Type);
            }
            else if (source.Iscsi != null)
                target.DesiredVolumeType = VolumeType.iscsi;
            else if (source.Nfs != null)
                target.DesiredVolumeType = VolumeType.nfs;
            else if (source.PersistentVolumeClaim != null)
                target.DesiredVolumeType = VolumeType.persistentVolumeClaim;
            else if (source.PortworxVolume != null)
                target.DesiredVolumeType = VolumeType.portworxVolume;
            else if (source.Projected != null)
                target.DesiredVolumeType = VolumeType.projected;
            else if (source.Rbd != null)
                target.DesiredVolumeType = VolumeType.rbd;
            else if (source.Secret != null)
                target.DesiredVolumeType = VolumeType.secret;
            else
                target.DesiredVolumeType = VolumeType.unknown;
        }

        public Object ConvertBack(Object source) => ConvertBack((VolumeViewModel)source);
        public void Fill(Object source, Object target) => Fill((Volume)source, (VolumeViewModel)target);        
    }
}
