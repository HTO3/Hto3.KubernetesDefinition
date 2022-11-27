using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models
{
    public enum VolumeType
    {
        [Description("")]
        unknown = 0,
        [Description("AWS Elastic Block Store")]
        awsElasticBlockStore,
        [Description("Azure Disk")]
        azureDisk,
        [Description("Azure File")]
        azureFile,
        [Description("CephFS")]
        cephfs,
        [Description("Cinder")]
        cinder,
        [Description("Configuration Map")]
        configMap,
        [Description("Downward API")]
        downwardAPI,
        [Description("Empty Directory")]
        emptyDir,
        [Description("FC (Fibre Channel)")]
        fc,
        [Description("Google Compute Engine (GCE) persistent disk (PD)")]
        gcePersistentDisk,
        [Description("Gluster FS")]
        glusterfs,
        [Description("Host Path")]
        hostPath,
        [Description("iSCSI (SCSI over IP)")]
        iscsi,
        [Description("NFS (Network File System)")]
        nfs,
        [Description("Persistent Volume Claim")]
        persistentVolumeClaim,
        [Description("Portworx Volume")]
        portworxVolume,
        [Description("Projected Volume")]
        projected,
        [Description("Rados Block Device (RBD)")]
        rbd,
        [Description("Secret")]
        secret
    }
}
