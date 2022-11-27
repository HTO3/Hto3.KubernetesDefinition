using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Models.KubernetesObjects
{
    /// <summary>MutatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and may change the Object.</summary>

    public partial class MutatingWebhookConfiguration
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public MutatingWebhookConfigurationKind? Kind { get; set; }

        /// <summary>Standard Object metadata; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Webhooks is a list of webhooks and the affected resources and operations.</summary>
        public ICollection<Webhook> Webhooks { get; set; }
    }

    /// <summary>MutatingWebhookConfigurationList is a list of MutatingWebhookConfiguration.</summary>

    public partial class MutatingWebhookConfigurationList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>List of MutatingWebhookConfiguration.</summary>
        [Required]
        public ICollection<MutatingWebhookConfiguration> Items { get; set; } = new Collection<MutatingWebhookConfiguration>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public MutatingWebhookConfigurationListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RuleWithOperations is a tuple of Operations and Resources. It is recommended to make sure that all the tuple expansions are valid.</summary>

    public partial class RuleWithOperations
    {
        /// <summary>APIGroups is the API groups the resources belong to. '*' is all groups. If '*' is present, the length of the slice must be one. Required.</summary>
        public ICollection<String> ApiGroups { get; set; }

        /// <summary>APIVersions is the API versions the resources belong to. '*' is all versions. If '*' is present, the length of the slice must be one. Required.</summary>
        public ICollection<String> ApiVersions { get; set; }

        /// <summary>Operations is the operations the admission hook cares about - CREATE, UPDATE, or * for all operations. If '*' is present, the length of the slice must be one. Required.</summary>
        public ICollection<String> Operations { get; set; }

        /// <summary>Resources is a list of resources this rule applies to.
        /// <br/>
        /// <br/>For example: 'pods' means pods. 'pods/log' means the log subresource of pods. '*' means all resources, but not subresources. 'pods/*' means all subresources of pods. '*/scale' means all scale subresources. '*/*' means all resources and their subresources.
        /// <br/>
        /// <br/>If wildcard is present, the validation rule will ensure resources do not overlap with each other.
        /// <br/>
        /// <br/>Depending on the enclosing Object, subresources might not be allowed. Required.</summary>
        public ICollection<String> Resources { get; set; }

        /// <summary>scope specifies the scope of this rule. Valid values are "Cluster", "Namespaced", and "*" "Cluster" means that only cluster-scoped resources will match this rule. Namespace API objects are cluster-scoped. "Namespaced" means that only namespaced resources will match this rule. "*" means that there are no scope restrictions. Subresources match the scope of their parent resource. Default is "*".</summary>
        public String Scope { get; set; }
    }

    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io</summary>

    public partial class ServiceReference
    {
        /// <summary>`name` is the name of the service. Required</summary>
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>`namespace` is the namespace of the service. Required</summary>
        [Required(AllowEmptyStrings = true)]
        public String Namespace { get; set; }

        /// <summary>`path` is an optional URL path which will be sent in any request to this service.</summary>
        public String Path { get; set; }
    }

    /// <summary>ValidatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and Object without changing it.</summary>

    public partial class ValidatingWebhookConfiguration
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public ValidatingWebhookConfigurationKind? Kind { get; set; }

        /// <summary>Standard Object metadata; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Webhooks is a list of webhooks and the affected resources and operations.</summary>
        public ICollection<Webhook> Webhooks { get; set; }
    }

    /// <summary>ValidatingWebhookConfigurationList is a list of ValidatingWebhookConfiguration.</summary>

    public partial class ValidatingWebhookConfigurationList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>List of ValidatingWebhookConfiguration.</summary>
        [Required]
        public ICollection<ValidatingWebhookConfiguration> Items { get; set; } = new Collection<ValidatingWebhookConfiguration>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public ValidatingWebhookConfigurationListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public ListMeta Metadata { get; set; }
    }

    /// <summary>Webhook describes an admission webhook and the resources and operations it applies to.</summary>
    public partial class Webhook
    {
        /// <summary>AdmissionReviewVersions is an ordered list of preferred `AdmissionReview` versions the Webhook expects. API server will try to use first version in the list which it supports. If none of the versions specified in this list supported by API server, validation will fail for this Object. If a persisted webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail and be subject to the failure policy. Default to `['v1beta1']`.</summary>
        public ICollection<String> AdmissionReviewVersions { get; set; }

        /// <summary>ClientConfig defines how to communicate with the hook. Required</summary>
        [Required]
        public WebhookClientConfig ClientConfig { get; set; } = new WebhookClientConfig();

        /// <summary>FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail. Defaults to Ignore.</summary>
        public String FailurePolicy { get; set; }

        /// <summary>The name of the admission webhook. Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where "imagepolicy" is the name of the webhook, and kubernetes.io is the name of the organization. Required.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>NamespaceSelector decides whether to run the webhook on an Object based on whether the namespace for that Object matches the selector. If the Object itself is a namespace, the matching is performed on Object.metadata.labels. If the Object is another cluster scoped resource, it never skips the webhook.
        /// <br/>
        /// <br/>For example, to run the webhook on any objects whose namespace is not associated with "runlevel" of "0" or "1";  you will set the selector as follows: "namespaceSelector": {
        /// <br/>  "matchExpressions": [
        /// <br/>    {
        /// <br/>      "key": "runlevel",
        /// <br/>      "operator": "NotIn",
        /// <br/>      "values": [
        /// <br/>        "0",
        /// <br/>        "1"
        /// <br/>      ]
        /// <br/>    }
        /// <br/>  ]
        /// <br/>}
        /// <br/>
        /// <br/>If instead you want to only run the webhook on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
        /// <br/>  "matchExpressions": [
        /// <br/>    {
        /// <br/>      "key": "environment",
        /// <br/>      "operator": "In",
        /// <br/>      "values": [
        /// <br/>        "prod",
        /// <br/>        "staging"
        /// <br/>      ]
        /// <br/>    }
        /// <br/>  ]
        /// <br/>}
        /// <br/>
        /// <br/>See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/ for more examples of label selectors.
        /// <br/>
        /// <br/>Default to the empty LabelSelector, which matches everything.</summary>
        public LabelSelector NamespaceSelector { get; set; }

        /// <summary>Rules describes what operations on what resources/subresources the webhook cares about. The webhook cares about an operation if it matches _any_ Rule. However, in order to prevent ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks from putting the cluster in a state which cannot be recovered from without completely disabling the plugin, ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks are never called on admission requests for ValidatingWebhookConfiguration and MutatingWebhookConfiguration objects.</summary>
        public ICollection<RuleWithOperations> Rules { get; set; }

        /// <summary>SideEffects states whether this webhookk has side effects. Acceptable values are: Unknown, None, Some, NoneOnDryRun Webhooks with side effects MUST implement a reconciliation system, since a request may be rejected by a future step in the admission change and the side effects therefore need to be undone. Requests with the dryRun attribute will be auto-rejected if they match a webhook with sideEffects == Unknown or Some. Defaults to Unknown.</summary>
        public String SideEffects { get; set; }

        /// <summary>TimeoutSeconds specifies the timeout for this webhook. After the timeout passes, the webhook call will be ignored or the API call will fail based on the failure policy. The timeout value must be between 1 and 30 seconds. Default to 30 seconds.</summary>
        public int? TimeoutSeconds { get; set; }
    }

    /// <summary>WebhookClientConfig contains the information to make a TLS connection with the webhook</summary>

    public partial class WebhookClientConfig
    {
        /// <summary>`caBundle` is a PEM encoded CA bundle which will be used to validate the webhook's server certificate. If unspecified, system trust roots on the apiserver are used.</summary>
        public byte[] CaBundle { get; set; }

        /// <summary>`service` is a reference to the service for this webhook. Either `service` or `url` must be specified.
        /// <br/>
        /// <br/>If the webhook is running within the cluster, then you should use `service`.
        /// <br/>
        /// <br/>Port 443 will be used if it is open, otherwise it is an error.</summary>
        public ServiceReference Service { get; set; }

        /// <summary>`url` gives the location of the webhook, in standard URL form (`scheme://host:port/path`). Exactly one of `url` or `service` must be specified.
        /// <br/>
        /// <br/>The `host` should not refer to a service running in the cluster; use the `service` field instead. The host might be resolved via external DNS in some apiservers (e.g., `kube-apiserver` cannot resolve in-cluster DNS as that would be a layering violation). `host` may also be an IP address.
        /// <br/>
        /// <br/>Please note that using `localhost` or `127.0.0.1` as a `host` is risky unless you take great care to run this webhook on all hosts which run an apiserver which might need to make calls to this webhook. Such installs are likely to be non-portable, i.e., not easy to turn up in a new cluster.
        /// <br/>
        /// <br/>The scheme must be "https"; the URL must begin with "https://".
        /// <br/>
        /// <br/>A path is optional, and if present may be any String permissible in a URL. You may use the path to pass an arbitrary String to the webhook, for example, a cluster identifier.
        /// <br/>
        /// <br/>Attempting to use a user or basic auth e.g. "user:password@" is not allowed. Fragments ("#...") and query parameters ("?...") are not allowed, either.</summary>
        public String Url { get; set; }
    }

    /// <summary>ControllerRevision implements an immutable snapshot of state data. Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this Object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.</summary>

    public partial class ControllerRevision
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Data is the serialized representation of the state.</summary>
        public RawExtension Data { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public ControllerRevisionKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Revision indicates the revision of the state represented by Data.</summary>
        public long Revision { get; set; }
    }

    /// <summary>ControllerRevisionList is a resource containing a list of ControllerRevision objects.</summary>

    public partial class ControllerRevisionList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of ControllerRevisions</summary>
        [Required]
        public ICollection<ControllerRevision> Items { get; set; } = new Collection<ControllerRevision>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public ControllerRevisionListKind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DaemonSet represents the configuration of a daemon set.</summary>

    public partial class DaemonSet
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public DaemonSetKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The desired behavior of this daemon set. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public DaemonSetSpec Spec { get; set; }

        /// <summary>The current status of this daemon set. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public DaemonSetStatus Status { get; set; }
    }

    /// <summary>DaemonSetCondition describes the state of a DaemonSet at a certain point.</summary>

    public partial class DaemonSetCondition
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of DaemonSet condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DaemonSetList is a collection of daemon sets.</summary>

    public partial class DaemonSetList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>A list of daemon sets.</summary>
        
        [Required]
        public ICollection<DaemonSet> Items { get; set; } = new Collection<DaemonSet>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DaemonSetListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DaemonSetSpec is the specification of a daemon set.</summary>

    public partial class DaemonSetSpec
    {
        /// <summary>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>A label query over pods that are managed by the daemon set. Must match in order to be controlled. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>An Object that describes the pod that will be created. The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>An update strategy to replace existing DaemonSet pods with new pods.</summary>
        
        public DaemonSetUpdateStrategy UpdateStrategy { get; set; }
    }

    /// <summary>DaemonSetStatus represents the current status of a daemon set.</summary>

    public partial class DaemonSetStatus
    {
        /// <summary>Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a DaemonSet's current state.</summary>
        
        public ICollection<DaemonSetCondition> Conditions { get; set; }

        /// <summary>The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int CurrentNumberScheduled { get; set; }

        /// <summary>The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int DesiredNumberScheduled { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary>
        
        public int? NumberAvailable { get; set; }

        /// <summary>The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int NumberMisscheduled { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready.</summary>
        
        public int NumberReady { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary>
        
        public int? NumberUnavailable { get; set; }

        /// <summary>The most recent generation observed by the daemon set controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The total number of nodes that are running updated daemon pod</summary>
        
        public int? UpdatedNumberScheduled { get; set; }
    }

    /// <summary>DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.</summary>

    public partial class DaemonSetUpdateStrategy
    {
        /// <summary>Rolling update config params. Present only if type = "RollingUpdate".</summary>
        
        public RollingUpdateDaemonSet RollingUpdate { get; set; }

        /// <summary>Type of daemon set update. Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>Deployment enables declarative updates for Pods and ReplicaSets.</summary>

    public partial class Deployment
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentKind? Kind { get; set; }

        /// <summary>Standard Object metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the Deployment.</summary>
        
        public DeploymentSpec Spec { get; set; }

        /// <summary>Most recently observed status of the Deployment.</summary>
        
        public DeploymentStatus Status { get; set; }
    }

    /// <summary>DeploymentCondition describes the state of a deployment at a certain point.</summary>

    public partial class DeploymentCondition
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>The last time this condition was updated.</summary>
        
        public DateTimeOffset? LastUpdateTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of deployment condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DeploymentList is a list of Deployments.</summary>

    public partial class DeploymentList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Deployments.</summary>
        
        [Required]
        public ICollection<Deployment> Items { get; set; } = new Collection<Deployment>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentListKind? Kind { get; set; }

        /// <summary>Standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DeploymentSpec is the specification of the desired behavior of the Deployment.</summary>

    public partial class DeploymentSpec
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Indicates that the deployment is paused.</summary>
        
        public Boolean? Paused { get; set; }

        /// <summary>The maximum time in seconds for a deployment to make progress before it is considered to be failed. The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. Defaults to 600s.</summary>
        
        public int? ProgressDeadlineSeconds { get; set; }

        /// <summary>Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment. It must match the pod template's labels.</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
        
        public DeploymentStrategy Strategy { get; set; }

        /// <summary>Template describes the pods that will be created.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();
    }

    /// <summary>DeploymentStatus is the most recently observed status of the Deployment.</summary>

    public partial class DeploymentStatus
    {
        /// <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a deployment's current state.</summary>
        
        public ICollection<DeploymentCondition> Conditions { get; set; }

        /// <summary>The generation observed by the deployment controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>Total number of ready pods targeted by this deployment.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.</summary>
        
        public int? UnavailableReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>

    public partial class DeploymentStrategy
    {
        /// <summary>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.</summary>
        
        public RollingUpdateDeployment RollingUpdate { get; set; }

        /// <summary>Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>ReplicaSet ensures that a specified number of pod replicas are running at any given time.</summary>

    public partial class ReplicaSet
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicaSetKind? Kind { get; set; }

        /// <summary>If the Labels of a ReplicaSet are empty, they are defaulted to be the same as the Pod(s) that the ReplicaSet manages. Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the specification of the desired behavior of the ReplicaSet. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ReplicaSetSpec Spec { get; set; }

        /// <summary>Status is the most recently observed status of the ReplicaSet. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ReplicaSetStatus Status { get; set; }
    }

    /// <summary>ReplicaSetCondition describes the state of a replica set at a certain point.</summary>

    public partial class ReplicaSetCondition
    {
        /// <summary>The last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of replica set condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>ReplicaSetList is a collection of ReplicaSets.</summary>

    public partial class ReplicaSetList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of ReplicaSets. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller</summary>
        
        [Required]
        public ICollection<ReplicaSet> Items { get; set; } = new Collection<ReplicaSet>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicaSetListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ReplicaSetSpec is the specification of a ReplicaSet.</summary>

    public partial class ReplicaSetSpec
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Selector is a label query over pods that should match the replica count. Label keys and values that must match in order to be controlled by this replica set. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>Template is the Object that describes the pod that will be created if insufficient replicas are detected. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        public PodTemplateSpec Template { get; set; }
    }

    /// <summary>ReplicaSetStatus represents the current status of a ReplicaSet.</summary>

    public partial class ReplicaSetStatus
    {
        /// <summary>The number of available replicas (ready for at least minReadySeconds) for this replica set.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Represents the latest available observations of a replica set's current state.</summary>
        
        public ICollection<ReplicaSetCondition> Conditions { get; set; }

        /// <summary>The number of pods that have labels matching the labels of the pod template of the replicaset.</summary>
        
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>ObservedGeneration reflects the generation of the most recently observed ReplicaSet.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The number of ready replicas for this replica set.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary>
        
        public int Replicas { get; set; }
    }

    /// <summary>Spec to control the desired behavior of daemon set rolling update.</summary>

    public partial class RollingUpdateDaemonSet
    {
        /// <summary>The maximum number of DaemonSet pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of total number of DaemonSet pods at the start of the update (ex: 10%). Absolute number is calculated from percentage by rounding up. This cannot be 0. Default value is 1. Example: when this is set to 30%, at most 30% of the total number of nodes that should be running the daemon pod (i.e. status.desiredNumberScheduled) can have their pods stopped for an update at any given time. The update starts by stopping at most 30% of those DaemonSet pods and then brings up new DaemonSet pods in their place. Once the new pods are available, it then proceeds onto other DaemonSet pods, thus ensuring that at least 70% of original number of DaemonSet pods are available at all times during the update.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>Spec to control the desired behavior of rolling update.</summary>

    public partial class RollingUpdateDeployment
    {
        /// <summary>The maximum number of pods that can be scheduled above the desired number of pods. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.</summary>
        
        public String MaxSurge { get; set; }

        /// <summary>The maximum number of pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.</summary>

    public partial class RollingUpdateStatefulSetStrategy
    {
        /// <summary>Partition indicates the ordinal at which the StatefulSet should be partitioned. Default value is 0.</summary>
        
        public int? Partition { get; set; }
    }

    /// <summary>StatefulSet represents a set of pods with consistent identities. Identities are defined as:
    /// <br/> - Network: A single stable DNS and hostname.
    /// <br/> - Storage: As many VolumeClaims as requested.
    /// <br/>The StatefulSet guarantees that a given network identity will always map to the same storage identity.</summary>
    public partial class StatefulSet
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StatefulSetKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the desired identities of pods in this set.</summary>
        
        public StatefulSetSpec Spec { get; set; }

        /// <summary>Status is the current status of Pods in this StatefulSet. This data may be out of date by some window of time.</summary>
        
        public StatefulSetStatus Status { get; set; }
    }

    /// <summary>StatefulSetCondition describes the state of a statefulset at a certain point.</summary>

    public partial class StatefulSetCondition
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of statefulset condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>StatefulSetList is a collection of StatefulSets.</summary>
    public partial class StatefulSetList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        
        [Required]
        public ICollection<StatefulSet> Items { get; set; } = new Collection<StatefulSet>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public StatefulSetListKind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>A StatefulSetSpec is the specification of a StatefulSet.</summary>

    public partial class StatefulSetSpec
    {
        /// <summary>podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.</summary>
        
        public String PodManagementPolicy { get; set; }

        /// <summary>replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>selector is a label query over pods that should match the replica count. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-String.serviceName.default.svc.cluster.local where "pod-specific-String" is managed by the StatefulSet controller.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServiceName { get; set; }

        /// <summary>template is the Object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.</summary>
        
        public StatefulSetUpdateStrategy UpdateStrategy { get; set; }

        /// <summary>volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.</summary>
        
        public ICollection<PersistentVolumeClaim> VolumeClaimTemplates { get; set; }
    }

    /// <summary>StatefulSetStatus represents the current state of a StatefulSet.</summary>

    public partial class StatefulSetStatus
    {
        /// <summary>collisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a statefulset's current state.</summary>
        
        public ICollection<StatefulSetCondition> Conditions { get; set; }

        /// <summary>currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.</summary>
        
        public int? CurrentReplicas { get; set; }

        /// <summary>currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).</summary>
        
        public String CurrentRevision { get; set; }

        /// <summary>observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>replicas is the number of Pods created by the StatefulSet controller.</summary>
        
        public int Replicas { get; set; }

        /// <summary>updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)</summary>
        
        public String UpdateRevision { get; set; }

        /// <summary>updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates. It includes any additional parameters necessary to perform the update for the indicated strategy.</summary>

    public partial class StatefulSetUpdateStrategy
    {
        /// <summary>RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.</summary>
        
        public RollingUpdateStatefulSetStrategy RollingUpdate { get; set; }

        /// <summary>Type indicates the type of the StatefulSetUpdateStrategy. Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>DEPRECATED - This group version of ControllerRevision is deprecated by apps/v1beta2/ControllerRevision. See the release notes for more information. ControllerRevision implements an immutable snapshot of state data. Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this Object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.</summary>

    public partial class ControllerRevision2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Data is the serialized representation of the state.</summary>
        
        public RawExtension Data { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ControllerRevision2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Revision indicates the revision of the state represented by Data.</summary>
        
        public long Revision { get; set; }
    }

    /// <summary>ControllerRevisionList is a resource containing a list of ControllerRevision objects.</summary>

    public partial class ControllerRevisionList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of ControllerRevisions</summary>
        
        [Required]
        public ICollection<ControllerRevision2> Items { get; set; } = new Collection<ControllerRevision2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ControllerRevisionList2Kind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED - This group version of Deployment is deprecated by apps/v1beta2/Deployment. See the release notes for more information. Deployment enables declarative updates for Pods and ReplicaSets.</summary>

    public partial class Deployment2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Deployment2Kind? Kind { get; set; }

        /// <summary>Standard Object metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the Deployment.</summary>
        
        public DeploymentSpec2 Spec { get; set; }

        /// <summary>Most recently observed status of the Deployment.</summary>
        
        public DeploymentStatus2 Status { get; set; }
    }

    /// <summary>DeploymentCondition describes the state of a deployment at a certain point.</summary>

    public partial class DeploymentCondition2
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>The last time this condition was updated.</summary>
        
        public DateTimeOffset? LastUpdateTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of deployment condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DeploymentList is a list of Deployments.</summary>

    public partial class DeploymentList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Deployments.</summary>
        
        [Required]
        public ICollection<Deployment2> Items { get; set; } = new Collection<Deployment2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED. DeploymentRollback stores the information required to rollback a deployment.</summary>

    public partial class DeploymentRollback
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentRollbackKind? Kind { get; set; }

        /// <summary>Required: This must match the Name of a deployment.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>The config of this deployment rollback.</summary>
        
        [Required]
        public RollbackConfig RollbackTo { get; set; } = new RollbackConfig();

        /// <summary>The annotations to be updated to a deployment</summary>
        
        public IDictionary<String, String> UpdatedAnnotations { get; set; }
    }

    /// <summary>DeploymentSpec is the specification of the desired behavior of the Deployment.</summary>

    public partial class DeploymentSpec2
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Indicates that the deployment is paused.</summary>
        
        public Boolean? Paused { get; set; }

        /// <summary>The maximum time in seconds for a deployment to make progress before it is considered to be failed. The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. Defaults to 600s.</summary>
        
        public int? ProgressDeadlineSeconds { get; set; }

        /// <summary>Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 2.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>DEPRECATED. The config this deployment is rolling back to. Will be cleared after rollback is done.</summary>
        
        public RollbackConfig RollbackTo { get; set; }

        /// <summary>Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
        
        public DeploymentStrategy2 Strategy { get; set; }

        /// <summary>Template describes the pods that will be created.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();
    }

    /// <summary>DeploymentStatus is the most recently observed status of the Deployment.</summary>

    public partial class DeploymentStatus2
    {
        /// <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a deployment's current state.</summary>
        
        public ICollection<DeploymentCondition2> Conditions { get; set; }

        /// <summary>The generation observed by the deployment controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>Total number of ready pods targeted by this deployment.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.</summary>
        
        public int? UnavailableReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>

    public partial class DeploymentStrategy2
    {
        /// <summary>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.</summary>
        
        public RollingUpdateDeployment2 RollingUpdate { get; set; }

        /// <summary>Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>DEPRECATED.</summary>

    public partial class RollbackConfig
    {
        /// <summary>The revision to rollback to. If set to 0, rollback to the last revision.</summary>
        
        public long? Revision { get; set; }
    }

    /// <summary>Spec to control the desired behavior of rolling update.</summary>

    public partial class RollingUpdateDeployment2
    {
        /// <summary>The maximum number of pods that can be scheduled above the desired number of pods. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.</summary>
        
        public String MaxSurge { get; set; }

        /// <summary>The maximum number of pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.</summary>

    public partial class RollingUpdateStatefulSetStrategy2
    {
        /// <summary>Partition indicates the ordinal at which the StatefulSet should be partitioned.</summary>
        
        public int? Partition { get; set; }
    }

    /// <summary>Scale represents a scaling request for a resource.</summary>

    public partial class Scale
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ScaleKind? Kind { get; set; }

        /// <summary>Standard Object metadata; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>defines the behavior of the scale. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status.</summary>
        
        public ScaleSpec Spec { get; set; }

        /// <summary>current status of the scale. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status. Read-only.</summary>
        
        public ScaleStatus Status { get; set; }
    }

    /// <summary>ScaleSpec describes the attributes of a scale subresource</summary>

    public partial class ScaleSpec
    {
        /// <summary>desired number of instances for the scaled Object.</summary>
        
        public int? Replicas { get; set; }
    }

    /// <summary>ScaleStatus represents the current status of a scale subresource.</summary>

    public partial class ScaleStatus
    {
        /// <summary>actual number of observed instances of the scaled Object.</summary>
        
        public int Replicas { get; set; }

        /// <summary>label query over pods that should match the replicas count. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors</summary>
        
        public IDictionary<String, String> Selector { get; set; }

        /// <summary>label selector for pods that should match the replicas count. This is a serializated version of both map-based and more expressive set-based selectors. This is done to avoid introspection in the clients. The String will be in the same format as the query-param syntax. If the target type only supports map-based selectors, both this field and map-based selector field are populated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public String TargetSelector { get; set; }
    }

    /// <summary>DEPRECATED - This group version of StatefulSet is deprecated by apps/v1beta2/StatefulSet. See the release notes for more information. StatefulSet represents a set of pods with consistent identities. Identities are defined as:
    /// <br/> - Network: A single stable DNS and hostname.
    /// <br/> - Storage: As many VolumeClaims as requested.
    /// <br/>The StatefulSet guarantees that a given network identity will always map to the same storage identity.</summary>
    public partial class StatefulSet2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StatefulSet2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the desired identities of pods in this set.</summary>
        
        public StatefulSetSpec2 Spec { get; set; }

        /// <summary>Status is the current status of Pods in this StatefulSet. This data may be out of date by some window of time.</summary>
        
        public StatefulSetStatus2 Status { get; set; }
    }

    /// <summary>StatefulSetCondition describes the state of a statefulset at a certain point.</summary>

    public partial class StatefulSetCondition2
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of statefulset condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>StatefulSetList is a collection of StatefulSets.</summary>

    public partial class StatefulSetList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        
        [Required]
        public ICollection<StatefulSet2> Items { get; set; } = new Collection<StatefulSet2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StatefulSetList2Kind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>A StatefulSetSpec is the specification of a StatefulSet.</summary>

    public partial class StatefulSetSpec2
    {
        /// <summary>podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.</summary>
        
        public String PodManagementPolicy { get; set; }

        /// <summary>replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>selector is a label query over pods that should match the replica count. If empty, defaulted to labels on the pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-String.serviceName.default.svc.cluster.local where "pod-specific-String" is managed by the StatefulSet controller.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServiceName { get; set; }

        /// <summary>template is the Object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.</summary>
        
        public StatefulSetUpdateStrategy2 UpdateStrategy { get; set; }

        /// <summary>volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.</summary>
        
        public ICollection<PersistentVolumeClaim> VolumeClaimTemplates { get; set; }
    }

    /// <summary>StatefulSetStatus represents the current state of a StatefulSet.</summary>

    public partial class StatefulSetStatus2
    {
        /// <summary>collisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a statefulset's current state.</summary>
        
        public ICollection<StatefulSetCondition2> Conditions { get; set; }

        /// <summary>currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.</summary>
        
        public int? CurrentReplicas { get; set; }

        /// <summary>currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).</summary>
        
        public String CurrentRevision { get; set; }

        /// <summary>observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>replicas is the number of Pods created by the StatefulSet controller.</summary>
        
        public int Replicas { get; set; }

        /// <summary>updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)</summary>
        
        public String UpdateRevision { get; set; }

        /// <summary>updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates. It includes any additional parameters necessary to perform the update for the indicated strategy.</summary>

    public partial class StatefulSetUpdateStrategy2
    {
        /// <summary>RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.</summary>
        
        public RollingUpdateStatefulSetStrategy2 RollingUpdate { get; set; }

        /// <summary>Type indicates the type of the StatefulSetUpdateStrategy.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>DEPRECATED - This group version of ControllerRevision is deprecated by apps/v1/ControllerRevision. See the release notes for more information. ControllerRevision implements an immutable snapshot of state data. Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this Object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.</summary>

    public partial class ControllerRevision3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Data is the serialized representation of the state.</summary>
        
        public RawExtension Data { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ControllerRevision3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Revision indicates the revision of the state represented by Data.</summary>
        
        public long Revision { get; set; }
    }

    /// <summary>ControllerRevisionList is a resource containing a list of ControllerRevision objects.</summary>

    public partial class ControllerRevisionList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of ControllerRevisions</summary>
        
        [Required]
        public ICollection<ControllerRevision3> Items { get; set; } = new Collection<ControllerRevision3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ControllerRevisionList3Kind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED - This group version of DaemonSet is deprecated by apps/v1/DaemonSet. See the release notes for more information. DaemonSet represents the configuration of a daemon set.</summary>

    public partial class DaemonSet2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DaemonSet2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The desired behavior of this daemon set. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public DaemonSetSpec2 Spec { get; set; }

        /// <summary>The current status of this daemon set. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public DaemonSetStatus2 Status { get; set; }
    }

    /// <summary>DaemonSetCondition describes the state of a DaemonSet at a certain point.</summary>

    public partial class DaemonSetCondition2
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of DaemonSet condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DaemonSetList is a collection of daemon sets.</summary>

    public partial class DaemonSetList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>A list of daemon sets.</summary>
        
        [Required]
        public ICollection<DaemonSet2> Items { get; set; } = new Collection<DaemonSet2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DaemonSetList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DaemonSetSpec is the specification of a daemon set.</summary>

    public partial class DaemonSetSpec2
    {
        /// <summary>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>A label query over pods that are managed by the daemon set. Must match in order to be controlled. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>An Object that describes the pod that will be created. The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>An update strategy to replace existing DaemonSet pods with new pods.</summary>
        
        public DaemonSetUpdateStrategy2 UpdateStrategy { get; set; }
    }

    /// <summary>DaemonSetStatus represents the current status of a daemon set.</summary>

    public partial class DaemonSetStatus2
    {
        /// <summary>Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a DaemonSet's current state.</summary>
        
        public ICollection<DaemonSetCondition2> Conditions { get; set; }

        /// <summary>The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int CurrentNumberScheduled { get; set; }

        /// <summary>The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int DesiredNumberScheduled { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary>
        
        public int? NumberAvailable { get; set; }

        /// <summary>The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int NumberMisscheduled { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready.</summary>
        
        public int NumberReady { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary>
        
        public int? NumberUnavailable { get; set; }

        /// <summary>The most recent generation observed by the daemon set controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The total number of nodes that are running updated daemon pod</summary>
        
        public int? UpdatedNumberScheduled { get; set; }
    }

    /// <summary>DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.</summary>

    public partial class DaemonSetUpdateStrategy2
    {
        /// <summary>Rolling update config params. Present only if type = "RollingUpdate".</summary>
        
        public RollingUpdateDaemonSet2 RollingUpdate { get; set; }

        /// <summary>Type of daemon set update. Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>DEPRECATED - This group version of Deployment is deprecated by apps/v1/Deployment. See the release notes for more information. Deployment enables declarative updates for Pods and ReplicaSets.</summary>

    public partial class Deployment3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Deployment3Kind? Kind { get; set; }

        /// <summary>Standard Object metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the Deployment.</summary>
        
        public DeploymentSpec3 Spec { get; set; }

        /// <summary>Most recently observed status of the Deployment.</summary>
        
        public DeploymentStatus3 Status { get; set; }
    }

    /// <summary>DeploymentCondition describes the state of a deployment at a certain point.</summary>

    public partial class DeploymentCondition3
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>The last time this condition was updated.</summary>
        
        public DateTimeOffset? LastUpdateTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of deployment condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DeploymentList is a list of Deployments.</summary>

    public partial class DeploymentList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Deployments.</summary>
        
        [Required]
        public ICollection<Deployment3> Items { get; set; } = new Collection<Deployment3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentList3Kind? Kind { get; set; }

        /// <summary>Standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DeploymentSpec is the specification of the desired behavior of the Deployment.</summary>

    public partial class DeploymentSpec3
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Indicates that the deployment is paused.</summary>
        
        public Boolean? Paused { get; set; }

        /// <summary>The maximum time in seconds for a deployment to make progress before it is considered to be failed. The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. Defaults to 600s.</summary>
        
        public int? ProgressDeadlineSeconds { get; set; }

        /// <summary>Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment. It must match the pod template's labels.</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
        
        public DeploymentStrategy3 Strategy { get; set; }

        /// <summary>Template describes the pods that will be created.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();
    }

    /// <summary>DeploymentStatus is the most recently observed status of the Deployment.</summary>

    public partial class DeploymentStatus3
    {
        /// <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a deployment's current state.</summary>
        
        public ICollection<DeploymentCondition3> Conditions { get; set; }

        /// <summary>The generation observed by the deployment controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>Total number of ready pods targeted by this deployment.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.</summary>
        
        public int? UnavailableReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>

    public partial class DeploymentStrategy3
    {
        /// <summary>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.</summary>
        
        public RollingUpdateDeployment3 RollingUpdate { get; set; }

        /// <summary>Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>DEPRECATED - This group version of ReplicaSet is deprecated by apps/v1/ReplicaSet. See the release notes for more information. ReplicaSet ensures that a specified number of pod replicas are running at any given time.</summary>

    public partial class ReplicaSet2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicaSet2Kind? Kind { get; set; }

        /// <summary>If the Labels of a ReplicaSet are empty, they are defaulted to be the same as the Pod(s) that the ReplicaSet manages. Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the specification of the desired behavior of the ReplicaSet. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public ReplicaSetSpec2 Spec { get; set; }

        /// <summary>Status is the most recently observed status of the ReplicaSet. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public ReplicaSetStatus2 Status { get; set; }
    }

    /// <summary>ReplicaSetCondition describes the state of a replica set at a certain point.</summary>

    public partial class ReplicaSetCondition2
    {
        /// <summary>The last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of replica set condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>ReplicaSetList is a collection of ReplicaSets.</summary>

    public partial class ReplicaSetList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of ReplicaSets. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller</summary>
        
        [Required]
        public ICollection<ReplicaSet2> Items { get; set; } = new Collection<ReplicaSet2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicaSetList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ReplicaSetSpec is the specification of a ReplicaSet.</summary>

    public partial class ReplicaSetSpec2
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Selector is a label query over pods that should match the replica count. Label keys and values that must match in order to be controlled by this replica set. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>Template is the Object that describes the pod that will be created if insufficient replicas are detected. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        public PodTemplateSpec Template { get; set; }
    }

    /// <summary>ReplicaSetStatus represents the current status of a ReplicaSet.</summary>

    public partial class ReplicaSetStatus2
    {
        /// <summary>The number of available replicas (ready for at least minReadySeconds) for this replica set.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Represents the latest available observations of a replica set's current state.</summary>
        
        public ICollection<ReplicaSetCondition2> Conditions { get; set; }

        /// <summary>The number of pods that have labels matching the labels of the pod template of the replicaset.</summary>
        
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>ObservedGeneration reflects the generation of the most recently observed ReplicaSet.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The number of ready replicas for this replica set.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary>
        
        public int Replicas { get; set; }
    }

    /// <summary>Spec to control the desired behavior of daemon set rolling update.</summary>

    public partial class RollingUpdateDaemonSet2
    {
        /// <summary>The maximum number of DaemonSet pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of total number of DaemonSet pods at the start of the update (ex: 10%). Absolute number is calculated from percentage by rounding up. This cannot be 0. Default value is 1. Example: when this is set to 30%, at most 30% of the total number of nodes that should be running the daemon pod (i.e. status.desiredNumberScheduled) can have their pods stopped for an update at any given time. The update starts by stopping at most 30% of those DaemonSet pods and then brings up new DaemonSet pods in their place. Once the new pods are available, it then proceeds onto other DaemonSet pods, thus ensuring that at least 70% of original number of DaemonSet pods are available at all times during the update.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>Spec to control the desired behavior of rolling update.</summary>

    public partial class RollingUpdateDeployment3
    {
        /// <summary>The maximum number of pods that can be scheduled above the desired number of pods. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. Defaults to 25%. Example: when this is set to 30%, the new ReplicaSet can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new ReplicaSet can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.</summary>
        
        public String MaxSurge { get; set; }

        /// <summary>The maximum number of pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%, the old ReplicaSet can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old ReplicaSet can be scaled down further, followed by scaling up the new ReplicaSet, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.</summary>

    public partial class RollingUpdateStatefulSetStrategy3
    {
        /// <summary>Partition indicates the ordinal at which the StatefulSet should be partitioned. Default value is 0.</summary>
        
        public int? Partition { get; set; }
    }

    /// <summary>Scale represents a scaling request for a resource.</summary>

    public partial class Scale2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Scale2Kind? Kind { get; set; }

        /// <summary>Standard Object metadata; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>defines the behavior of the scale. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.</summary>
        
        public ScaleSpec2 Spec { get; set; }

        /// <summary>current status of the scale. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status. Read-only.</summary>
        
        public ScaleStatus2 Status { get; set; }
    }

    /// <summary>ScaleSpec describes the attributes of a scale subresource</summary>

    public partial class ScaleSpec2
    {
        /// <summary>desired number of instances for the scaled Object.</summary>
        
        public int? Replicas { get; set; }
    }

    /// <summary>ScaleStatus represents the current status of a scale subresource.</summary>

    public partial class ScaleStatus2
    {
        /// <summary>actual number of observed instances of the scaled Object.</summary>
        
        public int Replicas { get; set; }

        /// <summary>label query over pods that should match the replicas count. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors</summary>
        
        public IDictionary<String, String> Selector { get; set; }

        /// <summary>label selector for pods that should match the replicas count. This is a serializated version of both map-based and more expressive set-based selectors. This is done to avoid introspection in the clients. The String will be in the same format as the query-param syntax. If the target type only supports map-based selectors, both this field and map-based selector field are populated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public String TargetSelector { get; set; }
    }

    /// <summary>DEPRECATED - This group version of StatefulSet is deprecated by apps/v1/StatefulSet. See the release notes for more information. StatefulSet represents a set of pods with consistent identities. Identities are defined as:
    /// <br/> - Network: A single stable DNS and hostname.
    /// <br/> - Storage: As many VolumeClaims as requested.
    /// <br/>The StatefulSet guarantees that a given network identity will always map to the same storage identity.</summary>
    public partial class StatefulSet3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StatefulSet3Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the desired identities of pods in this set.</summary>
        
        public StatefulSetSpec3 Spec { get; set; }

        /// <summary>Status is the current status of Pods in this StatefulSet. This data may be out of date by some window of time.</summary>
        
        public StatefulSetStatus3 Status { get; set; }
    }

    /// <summary>StatefulSetCondition describes the state of a statefulset at a certain point.</summary>

    public partial class StatefulSetCondition3
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of statefulset condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>StatefulSetList is a collection of StatefulSets.</summary>

    public partial class StatefulSetList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        
        [Required]
        public ICollection<StatefulSet3> Items { get; set; } = new Collection<StatefulSet3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StatefulSetList3Kind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>A StatefulSetSpec is the specification of a StatefulSet.</summary>

    public partial class StatefulSetSpec3
    {
        /// <summary>podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down. The default policy is `OrderedReady`, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is `Parallel` which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.</summary>
        
        public String PodManagementPolicy { get; set; }

        /// <summary>replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history. The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>selector is a label query over pods that should match the replica count. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        [Required]
        public LabelSelector Selector { get; set; } = new LabelSelector();

        /// <summary>serviceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-String.serviceName.default.svc.cluster.local where "pod-specific-String" is managed by the StatefulSet controller.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServiceName { get; set; }

        /// <summary>template is the Object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.</summary>
        
        public StatefulSetUpdateStrategy3 UpdateStrategy { get; set; }

        /// <summary>volumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.</summary>
        
        public ICollection<PersistentVolumeClaim> VolumeClaimTemplates { get; set; }
    }

    /// <summary>StatefulSetStatus represents the current state of a StatefulSet.</summary>

    public partial class StatefulSetStatus3
    {
        /// <summary>collisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a statefulset's current state.</summary>
        
        public ICollection<StatefulSetCondition3> Conditions { get; set; }

        /// <summary>currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.</summary>
        
        public int? CurrentReplicas { get; set; }

        /// <summary>currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).</summary>
        
        public String CurrentRevision { get; set; }

        /// <summary>observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>replicas is the number of Pods created by the StatefulSet controller.</summary>
        
        public int Replicas { get; set; }

        /// <summary>updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)</summary>
        
        public String UpdateRevision { get; set; }

        /// <summary>updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates. It includes any additional parameters necessary to perform the update for the indicated strategy.</summary>

    public partial class StatefulSetUpdateStrategy3
    {
        /// <summary>RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.</summary>
        
        public RollingUpdateStatefulSetStrategy3 RollingUpdate { get; set; }

        /// <summary>Type indicates the type of the StatefulSetUpdateStrategy. Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>AuditSink represents a cluster level audit sink</summary>

    public partial class AuditSink
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public AuditSinkKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the audit configuration spec</summary>
        
        public AuditSinkSpec Spec { get; set; }
    }

    /// <summary>AuditSinkList is a list of AuditSink items.</summary>

    public partial class AuditSinkList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of audit configurations.</summary>
        
        [Required]
        public ICollection<AuditSink> Items { get; set; } = new Collection<AuditSink>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public AuditSinkListKind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>AuditSinkSpec holds the spec for the audit sink</summary>

    public partial class AuditSinkSpec
    {
        /// <summary>Policy defines the policy for selecting which events should be sent to the webhook required</summary>
        
        [Required]
        public Policy Policy { get; set; } = new Policy();

        /// <summary>Webhook to send events required</summary>
        
        [Required]
        public Webhook2 Webhook { get; set; } = new Webhook2();
    }

    /// <summary>Policy defines the configuration of how audit events are logged</summary>

    public partial class Policy
    {
        /// <summary>The Level that all requests are recorded at. available options: None, Metadata, Request, RequestResponse required</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Level { get; set; }

        /// <summary>Stages is a list of stages for which events are created.</summary>
        
        public ICollection<String> Stages { get; set; }
    }

    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io</summary>

    public partial class ServiceReference2
    {
        /// <summary>`name` is the name of the service. Required</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>`namespace` is the namespace of the service. Required</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Namespace { get; set; }

        /// <summary>`path` is an optional URL path which will be sent in any request to this service.</summary>
        
        public String Path { get; set; }
    }

    /// <summary>Webhook holds the configuration of the webhook</summary>

    public partial class Webhook2
    {
        /// <summary>ClientConfig holds the connection parameters for the webhook required</summary>
        
        [Required]
        public WebhookClientConfig2 ClientConfig { get; set; } = new WebhookClientConfig2();

        /// <summary>Throttle holds the options for throttling the webhook</summary>
        
        public WebhookThrottleConfig Throttle { get; set; }
    }

    /// <summary>WebhookClientConfig contains the information to make a connection with the webhook</summary>

    public partial class WebhookClientConfig2
    {
        /// <summary>`caBundle` is a PEM encoded CA bundle which will be used to validate the webhook's server certificate. If unspecified, system trust roots on the apiserver are used.</summary>
        
        public byte[] CaBundle { get; set; }

        /// <summary>`service` is a reference to the service for this webhook. Either `service` or `url` must be specified.
        /// <br/>
        /// <br/>If the webhook is running within the cluster, then you should use `service`.
        /// <br/>
        /// <br/>Port 443 will be used if it is open, otherwise it is an error.</summary>
        
        public ServiceReference2 Service { get; set; }

        /// <summary>`url` gives the location of the webhook, in standard URL form (`scheme://host:port/path`). Exactly one of `url` or `service` must be specified.
        /// <br/>
        /// <br/>The `host` should not refer to a service running in the cluster; use the `service` field instead. The host might be resolved via external DNS in some apiservers (e.g., `kube-apiserver` cannot resolve in-cluster DNS as that would be a layering violation). `host` may also be an IP address.
        /// <br/>
        /// <br/>Please note that using `localhost` or `127.0.0.1` as a `host` is risky unless you take great care to run this webhook on all hosts which run an apiserver which might need to make calls to this webhook. Such installs are likely to be non-portable, i.e., not easy to turn up in a new cluster.
        /// <br/>
        /// <br/>The scheme must be "https"; the URL must begin with "https://".
        /// <br/>
        /// <br/>A path is optional, and if present may be any String permissible in a URL. You may use the path to pass an arbitrary String to the webhook, for example, a cluster identifier.
        /// <br/>
        /// <br/>Attempting to use a user or basic auth e.g. "user:password@" is not allowed. Fragments ("#...") and query parameters ("?...") are not allowed, either.</summary>
        
        public String Url { get; set; }
    }

    /// <summary>WebhookThrottleConfig holds the configuration for throttling events</summary>

    public partial class WebhookThrottleConfig
    {
        /// <summary>ThrottleBurst is the maximum number of events sent at the same moment default 15 QPS</summary>
        
        public long? Burst { get; set; }

        /// <summary>ThrottleQPS maximum number of batches per second default 10 QPS</summary>
        
        public long? Qps { get; set; }
    }

    /// <summary>TokenReview attempts to authenticate a token to a known user. Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.</summary>

    public partial class TokenReview
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public TokenReviewKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated</summary>
        
        [Required]
        public TokenReviewSpec Spec { get; set; } = new TokenReviewSpec();

        /// <summary>Status is filled in by the server and indicates whether the request can be authenticated.</summary>
        
        public TokenReviewStatus Status { get; set; }
    }

    /// <summary>TokenReviewSpec is a description of the token authentication request.</summary>

    public partial class TokenReviewSpec
    {
        /// <summary>Audiences is a list of the identifiers that the resource server presented with the token identifies as. Audience-aware token authenticators will verify that the token was intended for at least one of the audiences in this list. If no audiences are provided, the audience will default to the audience of the Kubernetes apiserver.</summary>
        
        public ICollection<String> Audiences { get; set; }

        /// <summary>Token is the opaque bearer token.</summary>
        
        public String Token { get; set; }
    }

    /// <summary>TokenReviewStatus is the result of the token authentication request.</summary>

    public partial class TokenReviewStatus
    {
        /// <summary>Audiences are audience identifiers chosen by the authenticator that are compatible with both the TokenReview and token. An identifier is any identifier in the intersection of the TokenReviewSpec audiences and the token's audiences. A client of the TokenReview API that sets the spec.audiences field should validate that a compatible audience identifier is returned in the status.audiences field to ensure that the TokenReview server is audience aware. If a TokenReview returns an empty status.audience field where status.authenticated is "true", the token is valid against the audience of the Kubernetes API server.</summary>
        
        public ICollection<String> Audiences { get; set; }

        /// <summary>Authenticated indicates that the token was associated with a known user.</summary>
        
        public Boolean? Authenticated { get; set; }

        /// <summary>Error indicates that the token couldn't be checked</summary>
        
        public String Error { get; set; }

        /// <summary>User is the UserInfo associated with the provided token.</summary>
        
        public UserInfo User { get; set; }
    }

    /// <summary>UserInfo holds the information about the user needed to implement the user.Info interface.</summary>

    public partial class UserInfo
    {
        /// <summary>Any additional information provided by the authenticator.</summary>
        
        public IDictionary<String, ICollection<String>> Extra { get; set; }

        /// <summary>The names of groups this user is a part of.</summary>
        
        public ICollection<String> Groups { get; set; }

        /// <summary>A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.</summary>
        
        public String Uid { get; set; }

        /// <summary>The name that uniquely identifies this user among all active users.</summary>
        
        public String Username { get; set; }
    }

    /// <summary>TokenReview attempts to authenticate a token to a known user. Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.</summary>

    public partial class TokenReview2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public TokenReview2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated</summary>
        
        [Required]
        public TokenReviewSpec2 Spec { get; set; } = new TokenReviewSpec2();

        /// <summary>Status is filled in by the server and indicates whether the request can be authenticated.</summary>
        
        public TokenReviewStatus2 Status { get; set; }
    }

    /// <summary>TokenReviewSpec is a description of the token authentication request.</summary>

    public partial class TokenReviewSpec2
    {
        /// <summary>Audiences is a list of the identifiers that the resource server presented with the token identifies as. Audience-aware token authenticators will verify that the token was intended for at least one of the audiences in this list. If no audiences are provided, the audience will default to the audience of the Kubernetes apiserver.</summary>
        
        public ICollection<String> Audiences { get; set; }

        /// <summary>Token is the opaque bearer token.</summary>
        
        public String Token { get; set; }
    }

    /// <summary>TokenReviewStatus is the result of the token authentication request.</summary>

    public partial class TokenReviewStatus2
    {
        /// <summary>Audiences are audience identifiers chosen by the authenticator that are compatible with both the TokenReview and token. An identifier is any identifier in the intersection of the TokenReviewSpec audiences and the token's audiences. A client of the TokenReview API that sets the spec.audiences field should validate that a compatible audience identifier is returned in the status.audiences field to ensure that the TokenReview server is audience aware. If a TokenReview returns an empty status.audience field where status.authenticated is "true", the token is valid against the audience of the Kubernetes API server.</summary>
        
        public ICollection<String> Audiences { get; set; }

        /// <summary>Authenticated indicates that the token was associated with a known user.</summary>
        
        public Boolean? Authenticated { get; set; }

        /// <summary>Error indicates that the token couldn't be checked</summary>
        
        public String Error { get; set; }

        /// <summary>User is the UserInfo associated with the provided token.</summary>
        
        public UserInfo2 User { get; set; }
    }

    /// <summary>UserInfo holds the information about the user needed to implement the user.Info interface.</summary>

    public partial class UserInfo2
    {
        /// <summary>Any additional information provided by the authenticator.</summary>
        
        public IDictionary<String, ICollection<String>> Extra { get; set; }

        /// <summary>The names of groups this user is a part of.</summary>
        
        public ICollection<String> Groups { get; set; }

        /// <summary>A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.</summary>
        
        public String Uid { get; set; }

        /// <summary>The name that uniquely identifies this user among all active users.</summary>
        
        public String Username { get; set; }
    }

    /// <summary>LocalSubjectAccessReview checks whether or not a user or group can perform an action in a given namespace. Having a namespace scoped resource makes it much easier to grant namespace scoped policy that includes permissions checking.</summary>

    public partial class LocalSubjectAccessReview
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LocalSubjectAccessReviewKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.</summary>
        
        [Required]
        public SubjectAccessReviewSpec Spec { get; set; } = new SubjectAccessReviewSpec();

        /// <summary>Status is filled in by the server and indicates whether the request is allowed or not</summary>
        
        public SubjectAccessReviewStatus Status { get; set; }
    }

    /// <summary>NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface</summary>

    public partial class NonResourceAttributes
    {
        /// <summary>Path is the URL path of the request</summary>
        
        public String Path { get; set; }

        /// <summary>Verb is the standard HTTP verb</summary>
        
        public String Verb { get; set; }
    }

    /// <summary>NonResourceRule holds information that describes a rule for the non-resource</summary>

    public partial class NonResourceRule
    {
        /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path.  "*" means all.</summary>
        
        public ICollection<String> NonResourceURLs { get; set; }

        /// <summary>Verb is a list of kubernetes non-resource API verbs, like: get, post, put, delete, patch, head, options.  "*" means all.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface</summary>

    public partial class ResourceAttributes
    {
        /// <summary>Group is the API Group of the Resource.  "*" means all.</summary>
        
        public String Group { get; set; }

        /// <summary>Name is the name of the resource being requested for a "get" or deleted for a "delete". "" (empty) means all.</summary>
        
        public String Name { get; set; }

        /// <summary>Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview</summary>
        
        public String Namespace { get; set; }

        /// <summary>Resource is one of the existing resource types.  "*" means all.</summary>
        
        public String Resource { get; set; }

        /// <summary>Subresource is one of the existing resource types.  "" means none.</summary>
        
        public String Subresource { get; set; }

        /// <summary>Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  "*" means all.</summary>
        
        public String Verb { get; set; }

        /// <summary>Version is the API Version of the Resource.  "*" means all.</summary>
        
        public String Version { get; set; }
    }

    /// <summary>ResourceRule is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary>

    public partial class ResourceRule
    {
        /// <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.  "*" means all.</summary>
        
        public ICollection<String> ApiGroups { get; set; }

        /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.  "*" means all.</summary>
        
        public ICollection<String> ResourceNames { get; set; }

        /// <summary>Resources is a list of resources this rule applies to.  "*" means all in the specified apiGroups.
        /// <br/> "*/foo" represents the subresource 'foo' for all resources in the specified apiGroups.</summary>
        
        public ICollection<String> Resources { get; set; }

        /// <summary>Verb is a list of kubernetes resource API verbs, like: get, list, watch, create, update, delete, proxy.  "*" means all.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>SelfSubjectAccessReview checks whether or the current user can perform an action.  Not filling in a spec.namespace means "in all namespaces".  Self is a special case, because users should always be able to check whether they can perform an action</summary>

    public partial class SelfSubjectAccessReview
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SelfSubjectAccessReviewKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated.  user and groups must be empty</summary>
        
        [Required]
        public SelfSubjectAccessReviewSpec Spec { get; set; } = new SelfSubjectAccessReviewSpec();

        /// <summary>Status is filled in by the server and indicates whether the request is allowed or not</summary>
        
        public SubjectAccessReviewStatus Status { get; set; }
    }

    /// <summary>SelfSubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set</summary>

    public partial class SelfSubjectAccessReviewSpec
    {
        /// <summary>NonResourceAttributes describes information for a non-resource access request</summary>
        
        public NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>ResourceAuthorizationAttributes describes information for a resource access request</summary>
        
        public ResourceAttributes ResourceAttributes { get; set; }
    }

    /// <summary>SelfSubjectRulesReview enumerates the set of actions the current user can perform within a namespace. The returned list of actions may be incomplete depending on the server's authorization mode, and any errors experienced during the evaluation. SelfSubjectRulesReview should be used by UIs to show/hide actions, or to quickly let an end user reason about their permissions. It should NOT Be used by external systems to drive authorization decisions as this raises confused deputy, cache lifetime/revocation, and correctness concerns. SubjectAccessReview, and LocalAccessReview are the correct way to defer authorization decisions to the API server.</summary>

    public partial class SelfSubjectRulesReview
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SelfSubjectRulesReviewKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated.</summary>
        
        [Required]
        public SelfSubjectRulesReviewSpec Spec { get; set; } = new SelfSubjectRulesReviewSpec();

        /// <summary>Status is filled in by the server and indicates the set of actions a user can perform.</summary>
        
        public SubjectRulesReviewStatus Status { get; set; }
    }


    public partial class SelfSubjectRulesReviewSpec
    {
        /// <summary>Namespace to evaluate rules for. Required.</summary>
        
        public String Namespace { get; set; }
    }

    /// <summary>SubjectAccessReview checks whether or not a user or group can perform an action.</summary>

    public partial class SubjectAccessReview
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SubjectAccessReviewKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated</summary>
        
        [Required]
        public SubjectAccessReviewSpec Spec { get; set; } = new SubjectAccessReviewSpec();

        /// <summary>Status is filled in by the server and indicates whether the request is allowed or not</summary>
        
        public SubjectAccessReviewStatus Status { get; set; }
    }

    /// <summary>SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set</summary>

    public partial class SubjectAccessReviewSpec
    {
        /// <summary>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</summary>
        
        public IDictionary<String, ICollection<String>> Extra { get; set; }

        /// <summary>Groups is the groups you're testing for.</summary>
        
        public ICollection<String> Groups { get; set; }

        /// <summary>NonResourceAttributes describes information for a non-resource access request</summary>
        
        public NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>ResourceAuthorizationAttributes describes information for a resource access request</summary>
        
        public ResourceAttributes ResourceAttributes { get; set; }

        /// <summary>UID information about the requesting user.</summary>
        
        public String Uid { get; set; }

        /// <summary>User is the user you're testing for. If you specify "User" but not "Groups", then is it interpreted as "What if User were not a member of any groups</summary>
        
        public String User { get; set; }
    }

    /// <summary>SubjectAccessReviewStatus</summary>

    public partial class SubjectAccessReviewStatus
    {
        /// <summary>Allowed is required. True if the action would be allowed, false otherwise.</summary>
        
        public Boolean Allowed { get; set; }

        /// <summary>Denied is optional. True if the action would be denied, otherwise false. If both allowed is false and denied is false, then the authorizer has no opinion on whether to authorize the action. Denied may not be true if Allowed is true.</summary>
        
        public Boolean? Denied { get; set; }

        /// <summary>EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.</summary>
        
        public String EvaluationError { get; set; }

        /// <summary>Reason is optional.  It indicates why a request was allowed or denied.</summary>
        
        public String Reason { get; set; }
    }

    /// <summary>SubjectRulesReviewStatus contains the result of a rules check. This check can be incomplete depending on the set of authorizers the server is configured with and any errors experienced during evaluation. Because authorization rules are additive, if a rule appears in a list it's safe to assume the subject has that permission, even if that list is incomplete.</summary>

    public partial class SubjectRulesReviewStatus
    {
        /// <summary>EvaluationError can appear in combination with Rules. It indicates an error occurred during rule evaluation, such as an authorizer that doesn't support rule evaluation, and that ResourceRules and/or NonResourceRules may be incomplete.</summary>
        
        public String EvaluationError { get; set; }

        /// <summary>Incomplete is true when the rules returned by this call are incomplete. This is most commonly encountered when an authorizer, such as an external authorizer, doesn't support rules evaluation.</summary>
        
        public Boolean Incomplete { get; set; }

        /// <summary>NonResourceRules is the list of actions the subject is allowed to perform on non-resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary>
        
        [Required]
        public ICollection<NonResourceRule> NonResourceRules { get; set; } = new Collection<NonResourceRule>();

        /// <summary>ResourceRules is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary>
        
        [Required]
        public ICollection<ResourceRule> ResourceRules { get; set; } = new Collection<ResourceRule>();
    }

    /// <summary>LocalSubjectAccessReview checks whether or not a user or group can perform an action in a given namespace. Having a namespace scoped resource makes it much easier to grant namespace scoped policy that includes permissions checking.</summary>

    public partial class LocalSubjectAccessReview2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LocalSubjectAccessReview2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.</summary>
        
        [Required]
        public SubjectAccessReviewSpec2 Spec { get; set; } = new SubjectAccessReviewSpec2();

        /// <summary>Status is filled in by the server and indicates whether the request is allowed or not</summary>
        
        public SubjectAccessReviewStatus2 Status { get; set; }
    }

    /// <summary>NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface</summary>

    public partial class NonResourceAttributes2
    {
        /// <summary>Path is the URL path of the request</summary>
        
        public String Path { get; set; }

        /// <summary>Verb is the standard HTTP verb</summary>
        
        public String Verb { get; set; }
    }

    /// <summary>NonResourceRule holds information that describes a rule for the non-resource</summary>

    public partial class NonResourceRule2
    {
        /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path.  "*" means all.</summary>
        
        public ICollection<String> NonResourceURLs { get; set; }

        /// <summary>Verb is a list of kubernetes non-resource API verbs, like: get, post, put, delete, patch, head, options.  "*" means all.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface</summary>

    public partial class ResourceAttributes2
    {
        /// <summary>Group is the API Group of the Resource.  "*" means all.</summary>
        
        public String Group { get; set; }

        /// <summary>Name is the name of the resource being requested for a "get" or deleted for a "delete". "" (empty) means all.</summary>
        
        public String Name { get; set; }

        /// <summary>Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview</summary>
        
        public String Namespace { get; set; }

        /// <summary>Resource is one of the existing resource types.  "*" means all.</summary>
        
        public String Resource { get; set; }

        /// <summary>Subresource is one of the existing resource types.  "" means none.</summary>
        
        public String Subresource { get; set; }

        /// <summary>Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  "*" means all.</summary>
        
        public String Verb { get; set; }

        /// <summary>Version is the API Version of the Resource.  "*" means all.</summary>
        
        public String Version { get; set; }
    }

    /// <summary>ResourceRule is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary>

    public partial class ResourceRule2
    {
        /// <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.  "*" means all.</summary>
        
        public ICollection<String> ApiGroups { get; set; }

        /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.  "*" means all.</summary>
        
        public ICollection<String> ResourceNames { get; set; }

        /// <summary>Resources is a list of resources this rule applies to.  "*" means all in the specified apiGroups.
        /// <br/> "*/foo" represents the subresource 'foo' for all resources in the specified apiGroups.</summary>
        
        public ICollection<String> Resources { get; set; }

        /// <summary>Verb is a list of kubernetes resource API verbs, like: get, list, watch, create, update, delete, proxy.  "*" means all.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>SelfSubjectAccessReview checks whether or the current user can perform an action.  Not filling in a spec.namespace means "in all namespaces".  Self is a special case, because users should always be able to check whether they can perform an action</summary>

    public partial class SelfSubjectAccessReview2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SelfSubjectAccessReview2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated.  user and groups must be empty</summary>
        
        [Required]
        public SelfSubjectAccessReviewSpec2 Spec { get; set; } = new SelfSubjectAccessReviewSpec2();

        /// <summary>Status is filled in by the server and indicates whether the request is allowed or not</summary>
        
        public SubjectAccessReviewStatus2 Status { get; set; }
    }

    /// <summary>SelfSubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set</summary>

    public partial class SelfSubjectAccessReviewSpec2
    {
        /// <summary>NonResourceAttributes describes information for a non-resource access request</summary>
        
        public NonResourceAttributes2 NonResourceAttributes { get; set; }

        /// <summary>ResourceAuthorizationAttributes describes information for a resource access request</summary>
        
        public ResourceAttributes2 ResourceAttributes { get; set; }
    }

    /// <summary>SelfSubjectRulesReview enumerates the set of actions the current user can perform within a namespace. The returned list of actions may be incomplete depending on the server's authorization mode, and any errors experienced during the evaluation. SelfSubjectRulesReview should be used by UIs to show/hide actions, or to quickly let an end user reason about their permissions. It should NOT Be used by external systems to drive authorization decisions as this raises confused deputy, cache lifetime/revocation, and correctness concerns. SubjectAccessReview, and LocalAccessReview are the correct way to defer authorization decisions to the API server.</summary>

    public partial class SelfSubjectRulesReview2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SelfSubjectRulesReview2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated.</summary>
        
        [Required]
        public SelfSubjectRulesReviewSpec2 Spec { get; set; } = new SelfSubjectRulesReviewSpec2();

        /// <summary>Status is filled in by the server and indicates the set of actions a user can perform.</summary>
        
        public SubjectRulesReviewStatus2 Status { get; set; }
    }


    public partial class SelfSubjectRulesReviewSpec2
    {
        /// <summary>Namespace to evaluate rules for. Required.</summary>
        
        public String Namespace { get; set; }
    }

    /// <summary>SubjectAccessReview checks whether or not a user or group can perform an action.</summary>

    public partial class SubjectAccessReview2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SubjectAccessReview2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec holds information about the request being evaluated</summary>
        
        [Required]
        public SubjectAccessReviewSpec2 Spec { get; set; } = new SubjectAccessReviewSpec2();

        /// <summary>Status is filled in by the server and indicates whether the request is allowed or not</summary>
        
        public SubjectAccessReviewStatus2 Status { get; set; }
    }

    /// <summary>SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set</summary>

    public partial class SubjectAccessReviewSpec2
    {
        /// <summary>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</summary>
        
        public IDictionary<String, ICollection<String>> Extra { get; set; }

        /// <summary>Groups is the groups you're testing for.</summary>
        
        public ICollection<String> Group { get; set; }

        /// <summary>NonResourceAttributes describes information for a non-resource access request</summary>
        
        public NonResourceAttributes2 NonResourceAttributes { get; set; }

        /// <summary>ResourceAuthorizationAttributes describes information for a resource access request</summary>
        
        public ResourceAttributes2 ResourceAttributes { get; set; }

        /// <summary>UID information about the requesting user.</summary>
        
        public String Uid { get; set; }

        /// <summary>User is the user you're testing for. If you specify "User" but not "Group", then is it interpreted as "What if User were not a member of any groups</summary>
        
        public String User { get; set; }
    }

    /// <summary>SubjectAccessReviewStatus</summary>

    public partial class SubjectAccessReviewStatus2
    {
        /// <summary>Allowed is required. True if the action would be allowed, false otherwise.</summary>
        
        public Boolean Allowed { get; set; }

        /// <summary>Denied is optional. True if the action would be denied, otherwise false. If both allowed is false and denied is false, then the authorizer has no opinion on whether to authorize the action. Denied may not be true if Allowed is true.</summary>
        
        public Boolean? Denied { get; set; }

        /// <summary>EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.</summary>
        
        public String EvaluationError { get; set; }

        /// <summary>Reason is optional.  It indicates why a request was allowed or denied.</summary>
        
        public String Reason { get; set; }
    }

    /// <summary>SubjectRulesReviewStatus contains the result of a rules check. This check can be incomplete depending on the set of authorizers the server is configured with and any errors experienced during evaluation. Because authorization rules are additive, if a rule appears in a list it's safe to assume the subject has that permission, even if that list is incomplete.</summary>

    public partial class SubjectRulesReviewStatus2
    {
        /// <summary>EvaluationError can appear in combination with Rules. It indicates an error occurred during rule evaluation, such as an authorizer that doesn't support rule evaluation, and that ResourceRules and/or NonResourceRules may be incomplete.</summary>
        
        public String EvaluationError { get; set; }

        /// <summary>Incomplete is true when the rules returned by this call are incomplete. This is most commonly encountered when an authorizer, such as an external authorizer, doesn't support rules evaluation.</summary>
        
        public Boolean Incomplete { get; set; }

        /// <summary>NonResourceRules is the list of actions the subject is allowed to perform on non-resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary>
        
        [Required]
        public ICollection<NonResourceRule2> NonResourceRules { get; set; } = new Collection<NonResourceRule2>();

        /// <summary>ResourceRules is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.</summary>
        
        [Required]
        public ICollection<ResourceRule2> ResourceRules { get; set; } = new Collection<ResourceRule2>();
    }

    /// <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary>

    public partial class CrossVersionObjectReference
    {
        /// <summary>API version of the referent</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind of the referent; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds"</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>configuration of a horizontal pod autoscaler.</summary>

    public partial class HorizontalPodAutoscaler
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public HorizontalPodAutoscalerKind? Kind { get; set; }

        /// <summary>Standard Object metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>behaviour of autoscaler. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status.</summary>
        
        public HorizontalPodAutoscalerSpec Spec { get; set; }

        /// <summary>current information about the autoscaler.</summary>
        
        public HorizontalPodAutoscalerStatus Status { get; set; }
    }

    /// <summary>list of horizontal pod autoscaler objects.</summary>

    public partial class HorizontalPodAutoscalerList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>list of horizontal pod autoscaler objects.</summary>
        
        [Required]
        public ICollection<HorizontalPodAutoscaler> Items { get; set; } = new Collection<HorizontalPodAutoscaler>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public HorizontalPodAutoscalerListKind? Kind { get; set; }

        /// <summary>Standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>specification of a horizontal pod autoscaler.</summary>

    public partial class HorizontalPodAutoscalerSpec
    {
        /// <summary>upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.</summary>
        
        public int MaxReplicas { get; set; }

        /// <summary>lower limit for the number of pods that can be set by the autoscaler, default 1.</summary>
        
        public int? MinReplicas { get; set; }

        /// <summary>reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.</summary>
        
        [Required]
        public CrossVersionObjectReference ScaleTargetRef { get; set; } = new CrossVersionObjectReference();

        /// <summary>target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.</summary>
        
        public int? TargetCPUUtilizationPercentage { get; set; }
    }

    /// <summary>current status of a horizontal pod autoscaler</summary>

    public partial class HorizontalPodAutoscalerStatus
    {
        /// <summary>current average CPU utilization over all pods, represented as a percentage of requested CPU, e.g. 70 means that an average pod is using now 70% of its requested CPU.</summary>
        
        public int? CurrentCPUUtilizationPercentage { get; set; }

        /// <summary>current number of replicas of pods managed by this autoscaler.</summary>
        
        public int CurrentReplicas { get; set; }

        /// <summary>desired number of replicas of pods managed by this autoscaler.</summary>
        
        public int DesiredReplicas { get; set; }

        /// <summary>last time the HorizontalPodAutoscaler scaled the number of pods; used by the autoscaler to control how often the number of pods is changed.</summary>
        
        public DateTimeOffset? LastScaleTime { get; set; }

        /// <summary>most recent generation observed by this autoscaler.</summary>
        
        public long? ObservedGeneration { get; set; }
    }

    /// <summary>Scale represents a scaling request for a resource.</summary>

    public partial class Scale3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Scale3Kind? Kind { get; set; }

        /// <summary>Standard Object metadata; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>defines the behavior of the scale. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status.</summary>
        
        public ScaleSpec3 Spec { get; set; }

        /// <summary>current status of the scale. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status. Read-only.</summary>
        
        public ScaleStatus3 Status { get; set; }
    }

    /// <summary>ScaleSpec describes the attributes of a scale subresource.</summary>

    public partial class ScaleSpec3
    {
        /// <summary>desired number of instances for the scaled Object.</summary>
        
        public int? Replicas { get; set; }
    }

    /// <summary>ScaleStatus represents the current status of a scale subresource.</summary>

    public partial class ScaleStatus3
    {
        /// <summary>actual number of observed instances of the scaled Object.</summary>
        
        public int Replicas { get; set; }

        /// <summary>label query over pods that should match the replicas count. This is same as the label selector but in the String format to avoid introspection by clients. The String will be in the same format as the query-param syntax. More info about label selectors: http://kubernetes.io/docs/user-guide/labels#label-selectors</summary>
        
        public String Selector { get; set; }
    }

    /// <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary>

    public partial class CrossVersionObjectReference2
    {
        /// <summary>API version of the referent</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind of the referent; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds"</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes Object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster). Exactly one "target" type should be set.</summary>

    public partial class ExternalMetricSource
    {
        /// <summary>metricName is the name of the metric in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MetricName { get; set; }

        /// <summary>metricSelector is used to identify a specific time series within a given metric.</summary>
        
        public LabelSelector MetricSelector { get; set; }

        /// <summary>targetAverageValue is the target per-pod value of global metric (as a quantity). Mutually exclusive with TargetValue.</summary>
        
        public String TargetAverageValue { get; set; }

        /// <summary>targetValue is the target value of the metric (as a quantity). Mutually exclusive with TargetAverageValue.</summary>
        
        public String TargetValue { get; set; }
    }

    /// <summary>ExternalMetricStatus indicates the current value of a global metric not associated with any Kubernetes Object.</summary>

    public partial class ExternalMetricStatus
    {
        /// <summary>currentAverageValue is the current value of metric averaged over autoscaled pods.</summary>
        
        public String CurrentAverageValue { get; set; }

        /// <summary>currentValue is the current value of the metric (as a quantity)</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String CurrentValue { get; set; }

        /// <summary>metricName is the name of a metric used for autoscaling in metric system.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MetricName { get; set; }

        /// <summary>metricSelector is used to identify a specific time series within a given metric.</summary>
        
        public LabelSelector MetricSelector { get; set; }
    }

    /// <summary>HorizontalPodAutoscaler is the configuration for a horizontal pod autoscaler, which automatically manages the replica count of any resource implementing the scale subresource based on the metrics specified.</summary>

    public partial class HorizontalPodAutoscaler2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public HorizontalPodAutoscaler2Kind? Kind { get; set; }

        /// <summary>metadata is the standard Object metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>spec is the specification for the behaviour of the autoscaler. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status.</summary>
        
        public HorizontalPodAutoscalerSpec2 Spec { get; set; }

        /// <summary>status is the current information about the autoscaler.</summary>
        
        public HorizontalPodAutoscalerStatus2 Status { get; set; }
    }

    /// <summary>HorizontalPodAutoscalerCondition describes the state of a HorizontalPodAutoscaler at a certain point.</summary>

    public partial class HorizontalPodAutoscalerCondition
    {
        /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>message is a human-readable explanation containing details about the transition</summary>
        
        public String Message { get; set; }

        /// <summary>reason is the reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>status is the status of the condition (True, False, Unknown)</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>type describes the current condition</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>HorizontalPodAutoscaler is a list of horizontal pod autoscaler objects.</summary>

    public partial class HorizontalPodAutoscalerList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
        
        [Required]
        public ICollection<HorizontalPodAutoscaler2> Items { get; set; } = new Collection<HorizontalPodAutoscaler2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public HorizontalPodAutoscalerList2Kind? Kind { get; set; }

        /// <summary>metadata is the standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.</summary>

    public partial class HorizontalPodAutoscalerSpec2
    {
        /// <summary>maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.</summary>
        
        public int MaxReplicas { get; set; }

        /// <summary>metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond.</summary>
        
        public ICollection<MetricSpec> Metrics { get; set; }

        /// <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down. It defaults to 1 pod.</summary>
        
        public int? MinReplicas { get; set; }

        /// <summary>scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.</summary>
        
        [Required]
        public CrossVersionObjectReference2 ScaleTargetRef { get; set; } = new CrossVersionObjectReference2();
    }

    /// <summary>HorizontalPodAutoscalerStatus describes the current status of a horizontal pod autoscaler.</summary>

    public partial class HorizontalPodAutoscalerStatus2
    {
        /// <summary>conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.</summary>
        
        [Required]
        public ICollection<HorizontalPodAutoscalerCondition> Conditions { get; set; } = new Collection<HorizontalPodAutoscalerCondition>();

        /// <summary>currentMetrics is the last read state of the metrics used by this autoscaler.</summary>
        
        public ICollection<MetricStatus> CurrentMetrics { get; set; }

        /// <summary>currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.</summary>
        
        public int CurrentReplicas { get; set; }

        /// <summary>desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.</summary>
        
        public int DesiredReplicas { get; set; }

        /// <summary>lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed.</summary>
        
        public DateTimeOffset? LastScaleTime { get; set; }

        /// <summary>observedGeneration is the most recent generation observed by this autoscaler.</summary>
        
        public long? ObservedGeneration { get; set; }
    }

    /// <summary>MetricSpec specifies how to scale based on a single metric (only `type` and one other matching field should be set at once).</summary>

    public partial class MetricSpec
    {
        /// <summary>external refers to a global metric that is not associated with any Kubernetes Object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
        
        public ExternalMetricSource External { get; set; }

        /// <summary>Object refers to a metric describing a single kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>
        
        public ObjectMetricSource Object { get; set; }

        /// <summary>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.</summary>
        
        public PodsMetricSource Pods { get; set; }

        /// <summary>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>
        
        public ResourceMetricSource Resource { get; set; }

        /// <summary>type is the type of metric source.  It should be one of "Object", "Pods" or "Resource", each mapping to a matching field in the Object.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>MetricStatus describes the last-read state of a single metric.</summary>

    public partial class MetricStatus
    {
        /// <summary>external refers to a global metric that is not associated with any Kubernetes Object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
        
        public ExternalMetricStatus External { get; set; }

        /// <summary>Object refers to a metric describing a single kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>
        
        public ObjectMetricStatus Object { get; set; }

        /// <summary>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.</summary>
        
        public PodsMetricStatus Pods { get; set; }

        /// <summary>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>
        
        public ResourceMetricStatus Resource { get; set; }

        /// <summary>type is the type of metric source.  It will be one of "Object", "Pods" or "Resource", each corresponds to a matching field in the Object.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>ObjectMetricSource indicates how to scale on a metric describing a kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>

    public partial class ObjectMetricSource
    {
        /// <summary>averageValue is the target value of the average of the metric across all relevant pods (as a quantity)</summary>
        
        public String AverageValue { get; set; }

        /// <summary>metricName is the name of the metric in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MetricName { get; set; }

        /// <summary>selector is the String-encoded form of a standard kubernetes label selector for the given metric When set, it is passed as an additional parameter to the metrics server for more specific metrics scoping When unset, just the metricName will be used to gather metrics.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>target is the described Kubernetes Object.</summary>
        
        [Required]
        public CrossVersionObjectReference2 Target { get; set; } = new CrossVersionObjectReference2();

        /// <summary>targetValue is the target value of the metric (as a quantity).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String TargetValue { get; set; }
    }

    /// <summary>ObjectMetricStatus indicates the current value of a metric describing a kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>

    public partial class ObjectMetricStatus
    {
        /// <summary>averageValue is the current value of the average of the metric across all relevant pods (as a quantity)</summary>
        
        public String AverageValue { get; set; }

        /// <summary>currentValue is the current value of the metric (as a quantity).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String CurrentValue { get; set; }

        /// <summary>metricName is the name of the metric in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MetricName { get; set; }

        /// <summary>selector is the String-encoded form of a standard kubernetes label selector for the given metric When set in the ObjectMetricSource, it is passed as an additional parameter to the metrics server for more specific metrics scoping. When unset, just the metricName will be used to gather metrics.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>target is the described Kubernetes Object.</summary>
        
        [Required]
        public CrossVersionObjectReference2 Target { get; set; } = new CrossVersionObjectReference2();
    }

    /// <summary>PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second). The values will be averaged together before being compared to the target value.</summary>

    public partial class PodsMetricSource
    {
        /// <summary>metricName is the name of the metric in question</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MetricName { get; set; }

        /// <summary>selector is the String-encoded form of a standard kubernetes label selector for the given metric When set, it is passed as an additional parameter to the metrics server for more specific metrics scoping When unset, just the metricName will be used to gather metrics.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>targetAverageValue is the target value of the average of the metric across all relevant pods (as a quantity)</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String TargetAverageValue { get; set; }
    }

    /// <summary>PodsMetricStatus indicates the current value of a metric describing each pod in the current scale target (for example, transactions-processed-per-second).</summary>

    public partial class PodsMetricStatus
    {
        /// <summary>currentAverageValue is the current value of the average of the metric across all relevant pods (as a quantity)</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String CurrentAverageValue { get; set; }

        /// <summary>metricName is the name of the metric in question</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MetricName { get; set; }

        /// <summary>selector is the String-encoded form of a standard kubernetes label selector for the given metric When set in the PodsMetricSource, it is passed as an additional parameter to the metrics server for more specific metrics scoping. When unset, just the metricName will be used to gather metrics.</summary>
        
        public LabelSelector Selector { get; set; }
    }

    /// <summary>ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.</summary>

    public partial class ResourceMetricSource
    {
        /// <summary>name is the name of the resource in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>targetAverageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.</summary>
        
        public int? TargetAverageUtilization { get; set; }

        /// <summary>targetAverageValue is the target value of the average of the resource metric across all relevant pods, as a raw value (instead of as a percentage of the request), similar to the "pods" metric source type.</summary>
        
        public String TargetAverageValue { get; set; }
    }

    /// <summary>ResourceMetricStatus indicates the current value of a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>

    public partial class ResourceMetricStatus
    {
        /// <summary>currentAverageUtilization is the current value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.  It will only be present if `targetAverageValue` was set in the corresponding metric specification.</summary>
        
        public int? CurrentAverageUtilization { get; set; }

        /// <summary>currentAverageValue is the current value of the average of the resource metric across all relevant pods, as a raw value (instead of as a percentage of the request), similar to the "pods" metric source type. It will always be set, regardless of the corresponding metric specification.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String CurrentAverageValue { get; set; }

        /// <summary>name is the name of the resource in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>CrossVersionObjectReference contains enough information to let you identify the referred resource.</summary>

    public partial class CrossVersionObjectReference3
    {
        /// <summary>API version of the referent</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind of the referent; More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds"</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes Object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>

    public partial class ExternalMetricSource2
    {
        /// <summary>metric identifies the target metric by name and selector</summary>
        
        [Required]
        public MetricIdentifier Metric { get; set; } = new MetricIdentifier();

        /// <summary>target specifies the target value for the given metric</summary>
        
        [Required]
        public MetricTarget Target { get; set; } = new MetricTarget();
    }

    /// <summary>ExternalMetricStatus indicates the current value of a global metric not associated with any Kubernetes Object.</summary>

    public partial class ExternalMetricStatus2
    {
        /// <summary>current contains the current value for the given metric</summary>
        
        [Required]
        public MetricValueStatus Current { get; set; } = new MetricValueStatus();

        /// <summary>metric identifies the target metric by name and selector</summary>
        
        [Required]
        public MetricIdentifier Metric { get; set; } = new MetricIdentifier();
    }

    /// <summary>HorizontalPodAutoscaler is the configuration for a horizontal pod autoscaler, which automatically manages the replica count of any resource implementing the scale subresource based on the metrics specified.</summary>

    public partial class HorizontalPodAutoscaler3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public HorizontalPodAutoscaler3Kind? Kind { get; set; }

        /// <summary>metadata is the standard Object metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>spec is the specification for the behaviour of the autoscaler. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status.</summary>
        
        public HorizontalPodAutoscalerSpec3 Spec { get; set; }

        /// <summary>status is the current information about the autoscaler.</summary>
        
        public HorizontalPodAutoscalerStatus3 Status { get; set; }
    }

    /// <summary>HorizontalPodAutoscalerCondition describes the state of a HorizontalPodAutoscaler at a certain point.</summary>

    public partial class HorizontalPodAutoscalerCondition2
    {
        /// <summary>lastTransitionTime is the last time the condition transitioned from one status to another</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>message is a human-readable explanation containing details about the transition</summary>
        
        public String Message { get; set; }

        /// <summary>reason is the reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>status is the status of the condition (True, False, Unknown)</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>type describes the current condition</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>HorizontalPodAutoscalerList is a list of horizontal pod autoscaler objects.</summary>

    public partial class HorizontalPodAutoscalerList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
        
        [Required]
        public ICollection<HorizontalPodAutoscaler3> Items { get; set; } = new Collection<HorizontalPodAutoscaler3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public HorizontalPodAutoscalerList3Kind? Kind { get; set; }

        /// <summary>metadata is the standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.</summary>

    public partial class HorizontalPodAutoscalerSpec3
    {
        /// <summary>maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.</summary>
        
        public int MaxReplicas { get; set; }

        /// <summary>metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond. If not set, the default metric will be set to 80% average CPU utilization.</summary>
        
        public ICollection<MetricSpec2> Metrics { get; set; }

        /// <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down. It defaults to 1 pod.</summary>
        
        public int? MinReplicas { get; set; }

        /// <summary>scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.</summary>
        
        [Required]
        public CrossVersionObjectReference3 ScaleTargetRef { get; set; } = new CrossVersionObjectReference3();
    }

    /// <summary>HorizontalPodAutoscalerStatus describes the current status of a horizontal pod autoscaler.</summary>

    public partial class HorizontalPodAutoscalerStatus3
    {
        /// <summary>conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.</summary>
        
        [Required]
        public ICollection<HorizontalPodAutoscalerCondition2> Conditions { get; set; } = new Collection<HorizontalPodAutoscalerCondition2>();

        /// <summary>currentMetrics is the last read state of the metrics used by this autoscaler.</summary>
        
        public ICollection<MetricStatus2> CurrentMetrics { get; set; }

        /// <summary>currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.</summary>
        
        public int CurrentReplicas { get; set; }

        /// <summary>desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.</summary>
        
        public int DesiredReplicas { get; set; }

        /// <summary>lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed.</summary>
        
        public DateTimeOffset? LastScaleTime { get; set; }

        /// <summary>observedGeneration is the most recent generation observed by this autoscaler.</summary>
        
        public long? ObservedGeneration { get; set; }
    }

    /// <summary>MetricIdentifier defines the name and optionally selector for a metric</summary>

    public partial class MetricIdentifier
    {
        /// <summary>name is the name of the given metric</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>selector is the String-encoded form of a standard kubernetes label selector for the given metric When set, it is passed as an additional parameter to the metrics server for more specific metrics scoping. When unset, just the metricName will be used to gather metrics.</summary>
        
        public LabelSelector Selector { get; set; }
    }

    /// <summary>MetricSpec specifies how to scale based on a single metric (only `type` and one other matching field should be set at once).</summary>

    public partial class MetricSpec2
    {
        /// <summary>external refers to a global metric that is not associated with any Kubernetes Object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
        
        public ExternalMetricSource2 External { get; set; }

        /// <summary>Object refers to a metric describing a single kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>
        
        public ObjectMetricSource2 Object { get; set; }

        /// <summary>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.</summary>
        
        public PodsMetricSource2 Pods { get; set; }

        /// <summary>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>
        
        public ResourceMetricSource2 Resource { get; set; }

        /// <summary>type is the type of metric source.  It should be one of "Object", "Pods" or "Resource", each mapping to a matching field in the Object.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>MetricStatus describes the last-read state of a single metric.</summary>

    public partial class MetricStatus2
    {
        /// <summary>external refers to a global metric that is not associated with any Kubernetes Object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
        
        public ExternalMetricStatus2 External { get; set; }

        /// <summary>Object refers to a metric describing a single kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>
        
        public ObjectMetricStatus2 Object { get; set; }

        /// <summary>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.</summary>
        
        public PodsMetricStatus2 Pods { get; set; }

        /// <summary>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>
        
        public ResourceMetricStatus2 Resource { get; set; }

        /// <summary>type is the type of metric source.  It will be one of "Object", "Pods" or "Resource", each corresponds to a matching field in the Object.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>MetricTarget defines the target value, average value, or average utilization of a specific metric</summary>

    public partial class MetricTarget
    {
        /// <summary>averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. Currently only valid for Resource metric source type</summary>
        
        public int? AverageUtilization { get; set; }

        /// <summary>averageValue is the target value of the average of the metric across all relevant pods (as a quantity)</summary>
        
        public String AverageValue { get; set; }

        /// <summary>type represents whether the metric type is Utilization, Value, or AverageValue</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }

        /// <summary>value is the target value of the metric (as a quantity).</summary>
        
        public String Value { get; set; }
    }

    /// <summary>MetricValueStatus holds the current value for a metric</summary>

    public partial class MetricValueStatus
    {
        /// <summary>currentAverageUtilization is the current value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.</summary>
        
        public int? AverageUtilization { get; set; }

        /// <summary>averageValue is the current value of the average of the metric across all relevant pods (as a quantity)</summary>
        
        public String AverageValue { get; set; }

        /// <summary>value is the current value of the metric (as a quantity).</summary>
        
        public String Value { get; set; }
    }

    /// <summary>ObjectMetricSource indicates how to scale on a metric describing a kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>

    public partial class ObjectMetricSource2
    {
        
        [Required]
        public CrossVersionObjectReference3 DescribedObject { get; set; } = new CrossVersionObjectReference3();

        /// <summary>metric identifies the target metric by name and selector</summary>
        
        [Required]
        public MetricIdentifier Metric { get; set; } = new MetricIdentifier();

        /// <summary>target specifies the target value for the given metric</summary>
        
        [Required]
        public MetricTarget Target { get; set; } = new MetricTarget();
    }

    /// <summary>ObjectMetricStatus indicates the current value of a metric describing a kubernetes Object (for example, hits-per-second on an Ingress Object).</summary>

    public partial class ObjectMetricStatus2
    {
        /// <summary>current contains the current value for the given metric</summary>
        
        [Required]
        public MetricValueStatus Current { get; set; } = new MetricValueStatus();

        
        [Required]
        public CrossVersionObjectReference3 DescribedObject { get; set; } = new CrossVersionObjectReference3();

        /// <summary>metric identifies the target metric by name and selector</summary>
        
        [Required]
        public MetricIdentifier Metric { get; set; } = new MetricIdentifier();
    }

    /// <summary>PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second). The values will be averaged together before being compared to the target value.</summary>

    public partial class PodsMetricSource2
    {
        /// <summary>metric identifies the target metric by name and selector</summary>
        
        [Required]
        public MetricIdentifier Metric { get; set; } = new MetricIdentifier();

        /// <summary>target specifies the target value for the given metric</summary>
        
        [Required]
        public MetricTarget Target { get; set; } = new MetricTarget();
    }

    /// <summary>PodsMetricStatus indicates the current value of a metric describing each pod in the current scale target (for example, transactions-processed-per-second).</summary>

    public partial class PodsMetricStatus2
    {
        /// <summary>current contains the current value for the given metric</summary>
        
        [Required]
        public MetricValueStatus Current { get; set; } = new MetricValueStatus();

        /// <summary>metric identifies the target metric by name and selector</summary>
        
        [Required]
        public MetricIdentifier Metric { get; set; } = new MetricIdentifier();
    }

    /// <summary>ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.</summary>

    public partial class ResourceMetricSource2
    {
        /// <summary>name is the name of the resource in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>target specifies the target value for the given metric</summary>
        
        [Required]
        public MetricTarget Target { get; set; } = new MetricTarget();
    }

    /// <summary>ResourceMetricStatus indicates the current value of a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>
    public partial class ResourceMetricStatus2
    {
        /// <summary>current contains the current value for the given metric</summary>
        
        [Required]
        public MetricValueStatus Current { get; set; } = new MetricValueStatus();

        /// <summary>Name is the name of the resource in question.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>Job represents the configuration of a single job.</summary>
    public partial class Job
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public JobKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of a job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public JobSpec Spec { get; set; }

        /// <summary>Current status of a job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public JobStatus Status { get; set; }
    }

    /// <summary>JobCondition describes current state of a job.</summary>
    public partial class JobCondition
    {
        /// <summary>Last time the condition was checked.</summary>
        public DateTimeOffset? LastProbeTime { get; set; }

        /// <summary>Last time the condition transit from one status to another.</summary>
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human readable message indicating details about last transition.</summary>
        public String Message { get; set; }

        /// <summary>(brief) reason for the condition's last transition.</summary>
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of job condition, Complete or Failed.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>JobList is a collection of jobs.</summary>
    public partial class JobList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>items is the list of Jobs.</summary>
        [Required]
        public ICollection<Job> Items { get; set; } = new Collection<Job>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public JobListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ListMeta Metadata { get; set; }
    }

    /// <summary>JobSpec describes how the job execution will look like.</summary>
    public partial class JobSpec
    {
        /// <summary>Specifies the duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer</summary>
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>Specifies the number of retries before marking this job failed. Defaults to 6</summary>
        public int? BackoffLimit { get; set; }

        /// <summary>Specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
        public int? Completions { get; set; }

        /// <summary>manualSelector controls generation of pod labels and pod selectors. Leave `manualSelector` unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see `manualSelector=true` in jobs that were created with the old `extensions/v1beta1` API. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/#specifying-your-own-pod-selector</summary>
        public Boolean? ManualSelector { get; set; }

        /// <summary>Specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) &lt; .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
        public int? Parallelism { get; set; }

        /// <summary>A label query over pods that should match the pod count. Normally, the system sets this field for you. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        public LabelSelector Selector { get; set; }

        /// <summary>Describes the pod that will be created when executing a job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>ttlSecondsAfterFinished limits the lifetime of a Job that has finished execution (either Complete or Failed). If this field is set, ttlSecondsAfterFinished after the Job finishes, it is eligible to be automatically deleted. When the Job is being deleted, its lifecycle guarantees (e.g. finalizers) will be honored. If this field is unset, the Job won't be automatically deleted. If this field is set to zero, the Job becomes eligible to be deleted immediately after it finishes. This field is alpha-level and is only honored by servers that enable the TTLAfterFinished feature.</summary>
        public int? TtlSecondsAfterFinished { get; set; }
    }

    /// <summary>JobStatus represents the current state of a Job.</summary>
    public partial class JobStatus
    {
        /// <summary>The number of actively running pods.</summary>
        public int? Active { get; set; }

        /// <summary>Represents time when the job was completed. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.</summary>
        public DateTimeOffset? CompletionTime { get; set; }

        /// <summary>The latest available observations of an Object's current state. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/</summary>
        public ICollection<JobCondition> Conditions { get; set; }

        /// <summary>The number of pods which reached phase Failed.</summary>
        public int? Failed { get; set; }

        /// <summary>Represents time when the job was acknowledged by the job controller. It is not guaranteed to be set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.</summary>
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>The number of pods which reached phase Succeeded.</summary>
        public int? Succeeded { get; set; }
    }

    /// <summary>CronJob represents the configuration of a single cron job.</summary>
    public partial class CronJob
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public CronJobKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of a cron job, including the schedule. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public CronJobSpec Spec { get; set; }

        /// <summary>Current status of a cron job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public CronJobStatus Status { get; set; }
    }

    /// <summary>CronJobList is a collection of cron jobs.</summary>
    public partial class CronJobList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>items is the list of CronJobs.</summary>
        [Required]
        public ICollection<CronJob> Items { get; set; } = new Collection<CronJob>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public CronJobListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ListMeta Metadata { get; set; }
    }

    /// <summary>CronJobSpec describes how the job execution will look like and when it will actually run.</summary>
    public partial class CronJobSpec
    {
        /// <summary>Specifies how to treat concurrent executions of a Job. Valid values are: - "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one</summary>
        public String ConcurrencyPolicy { get; set; }

        /// <summary>The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</summary>
        public int? FailedJobsHistoryLimit { get; set; }

        /// <summary>Specifies the job that will be created when executing a CronJob.</summary>
        [Required]
        public JobTemplateSpec JobTemplate { get; set; } = new JobTemplateSpec();

        /// <summary>The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Schedule { get; set; }

        /// <summary>Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.</summary>
        public long? StartingDeadlineSeconds { get; set; }

        /// <summary>The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified. Defaults to 3.</summary>
        public int? SuccessfulJobsHistoryLimit { get; set; }

        /// <summary>This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.</summary>
        public Boolean? Suspend { get; set; }
    }

    /// <summary>CronJobStatus represents the current state of a cron job.</summary>
    public partial class CronJobStatus
    {
        /// <summary>A list of pointers to currently running jobs.</summary>
        public ICollection<ObjectReference> Active { get; set; }

        /// <summary>Information when was the last time the job was successfully scheduled.</summary>
        public DateTimeOffset? LastScheduleTime { get; set; }
    }

    /// <summary>JobTemplateSpec describes the data a Job should have when created from a template</summary>
    public partial class JobTemplateSpec
    {
        /// <summary>Standard Object's metadata of the jobs created from this template. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public JobSpec Spec { get; set; }
    }

    /// <summary>CronJob represents the configuration of a single cron job.</summary>
    public partial class CronJob2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public CronJob2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of a cron job, including the schedule. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public CronJobSpec2 Spec { get; set; }

        /// <summary>Current status of a cron job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public CronJobStatus2 Status { get; set; }
    }

    /// <summary>CronJobList is a collection of cron jobs.</summary>
    public partial class CronJobList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>items is the list of CronJobs.</summary>
        [Required]
        public ICollection<CronJob2> Items { get; set; } = new Collection<CronJob2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public CronJobList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ListMeta Metadata { get; set; }
    }

    /// <summary>CronJobSpec describes how the job execution will look like and when it will actually run.</summary>
    public partial class CronJobSpec2
    {
        /// <summary>Specifies how to treat concurrent executions of a Job. Valid values are: - "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one</summary>
        public String ConcurrencyPolicy { get; set; }

        /// <summary>The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.</summary>
        public int? FailedJobsHistoryLimit { get; set; }

        /// <summary>Specifies the job that will be created when executing a CronJob.</summary>
        [Required]
        public JobTemplateSpec2 JobTemplate { get; set; } = new JobTemplateSpec2();

        /// <summary>The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Schedule { get; set; }

        /// <summary>Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.</summary>
        public long? StartingDeadlineSeconds { get; set; }

        /// <summary>The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.</summary>
        public int? SuccessfulJobsHistoryLimit { get; set; }

        /// <summary>This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.</summary>
        public Boolean? Suspend { get; set; }
    }

    /// <summary>CronJobStatus represents the current state of a cron job.</summary>
    public partial class CronJobStatus2
    {
        /// <summary>A list of pointers to currently running jobs.</summary>
        public ICollection<ObjectReference> Active { get; set; }

        /// <summary>Information when was the last time the job was successfully scheduled.</summary>
        public DateTimeOffset? LastScheduleTime { get; set; }
    }

    /// <summary>JobTemplateSpec describes the data a Job should have when created from a template</summary>
    public partial class JobTemplateSpec2
    {
        /// <summary>Standard Object's metadata of the jobs created from this template. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the job. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        public JobSpec Spec { get; set; }
    }

    /// <summary>Describes a certificate signing request</summary>

    public partial class CertificateSigningRequest
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public CertificateSigningRequestKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The certificate request itself and any additional information.</summary>
        public CertificateSigningRequestSpec Spec { get; set; }

        /// <summary>Derived information about the request.</summary>
        public CertificateSigningRequestStatus Status { get; set; }
    }

    public partial class CertificateSigningRequestCondition
    {
        /// <summary>timestamp for the last update to this condition</summary>
        
        public DateTimeOffset? LastUpdateTime { get; set; }

        /// <summary>human readable message with details about the request state</summary>
        
        public String Message { get; set; }

        /// <summary>brief reason for the request state</summary>
        
        public String Reason { get; set; }

        /// <summary>request approval state, currently Approved or Denied.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    public partial class CertificateSigningRequestList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        
        [Required]
        public ICollection<CertificateSigningRequest> Items { get; set; } = new Collection<CertificateSigningRequest>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CertificateSigningRequestListKind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>This information is immutable after the request is created. Only the Request and Usages fields can be set on creation, other fields are derived by Kubernetes and cannot be modified by users.</summary>

    public partial class CertificateSigningRequestSpec
    {
        /// <summary>Extra information about the requesting user. See user.Info interface for details.</summary>
        
        public IDictionary<String, ICollection<String>> Extra { get; set; }

        /// <summary>Group information about the requesting user. See user.Info interface for details.</summary>
        
        public ICollection<String> Groups { get; set; }

        /// <summary>Base64-encoded PKCS#10 CSR data</summary>
        
        [Required(AllowEmptyStrings = true)]
        public byte[] Request { get; set; }

        /// <summary>UID information about the requesting user. See user.Info interface for details.</summary>
        
        public String Uid { get; set; }

        /// <summary>allowedUsages specifies a set of usage contexts the key will be valid for. See: https://tools.ietf.org/html/rfc5280#section-4.2.1.3
        /// <br/>     https://tools.ietf.org/html/rfc5280#section-4.2.1.12</summary>
        
        public ICollection<String> Usages { get; set; }

        /// <summary>Information about the requesting user. See user.Info interface for details.</summary>
        
        public String Username { get; set; }
    }


    public partial class CertificateSigningRequestStatus
    {
        /// <summary>If request was approved, the controller will place the issued certificate here.</summary>
        
        public byte[] Certificate { get; set; }

        /// <summary>Conditions applied to the request, such as approval or denial.</summary>
        
        public ICollection<CertificateSigningRequestCondition> Conditions { get; set; }
    }

    /// <summary>Lease defines a lease concept.</summary>

    public partial class Lease
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LeaseKind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the Lease. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public LeaseSpec Spec { get; set; }
    }

    /// <summary>LeaseList is a list of Lease objects.</summary>

    public partial class LeaseList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<Lease> Items { get; set; } = new Collection<Lease>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LeaseListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>LeaseSpec is a specification of a Lease.</summary>

    public partial class LeaseSpec
    {
        /// <summary>acquireTime is a time when the current lease was acquired.</summary>
        
        public DateTimeOffset? AcquireTime { get; set; }

        /// <summary>holderIdentity contains the identity of the holder of a current lease.</summary>
        
        public String HolderIdentity { get; set; }

        /// <summary>leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measure against time of last observed RenewTime.</summary>
        
        public int? LeaseDurationSeconds { get; set; }

        /// <summary>leaseTransitions is the number of transitions of a lease between holders.</summary>
        
        public int? LeaseTransitions { get; set; }

        /// <summary>renewTime is a time when the current holder of a lease has last updated the lease.</summary>
        
        public DateTimeOffset? RenewTime { get; set; }
    }

    /// <summary>Lease defines a lease concept.</summary>

    public partial class Lease2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Lease2Kind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the Lease. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public LeaseSpec2 Spec { get; set; }
    }

    /// <summary>LeaseList is a list of Lease objects.</summary>

    public partial class LeaseList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<Lease2> Items { get; set; } = new Collection<Lease2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LeaseList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>LeaseSpec is a specification of a Lease.</summary>

    public partial class LeaseSpec2
    {
        /// <summary>acquireTime is a time when the current lease was acquired.</summary>
        
        public DateTimeOffset? AcquireTime { get; set; }

        /// <summary>holderIdentity contains the identity of the holder of a current lease.</summary>
        
        public String HolderIdentity { get; set; }

        /// <summary>leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measure against time of last observed RenewTime.</summary>
        
        public int? LeaseDurationSeconds { get; set; }

        /// <summary>leaseTransitions is the number of transitions of a lease between holders.</summary>
        
        public int? LeaseTransitions { get; set; }

        /// <summary>renewTime is a time when the current holder of a lease has last updated the lease.</summary>
        
        public DateTimeOffset? RenewTime { get; set; }
    }

    /// <summary>Represents a Persistent Disk resource in AWS.
    /// <br/>
    /// <br/>An AWS EBS disk must exist before mounting to a container. The disk must also be in the same AWS zone as the kubelet. An AWS EBS disk can only be mounted as read/write once. AWS EBS volumes support ownership management and SELinux relabeling.</summary>

    public partial class AWSElasticBlockStoreVolumeSource
    {
        /// <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
        
        public String FsType { get; set; }

        /// <summary>The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty).</summary>
        
        public int? Partition { get; set; }

        /// <summary>Specify "true" to force and set the ReadOnly property in VolumeMounts to "true". If omitted, the default is "false". More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String VolumeID { get; set; }
    }

    /// <summary>Affinity is a group of affinity scheduling rules.</summary>

    public partial class Affinity
    {
        /// <summary>Describes node affinity scheduling rules for the pod.</summary>
        
        public NodeAffinity NodeAffinity { get; set; }

        /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
        
        public PodAffinity PodAffinity { get; set; }

        /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
        
        public PodAntiAffinity PodAntiAffinity { get; set; }
    }

    /// <summary>AttachedVolume describes a volume attached to a node</summary>

    public partial class AttachedVolume
    {
        /// <summary>DevicePath represents the device path where the volume should be available</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String DevicePath { get; set; }

        /// <summary>Name of the attached volume</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>

    public partial class AzureDiskVolumeSource
    {
        /// <summary>Host Caching mode: None, Read Only, Read Write.</summary>
        
        public String CachingMode { get; set; }

        /// <summary>The Name of the data disk in the blob storage</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String DiskName { get; set; }

        /// <summary>The URI the data disk in the blob storage</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String DiskURI { get; set; }

        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared</summary>
        
        public String Kind { get; set; }

        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>

    public partial class AzureFilePersistentVolumeSource
    {
        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>the name of secret that contains Azure Storage Account Name and Key</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String SecretName { get; set; }

        /// <summary>the namespace of the secret that contains Azure Storage Account Name and Key default is the same as the Pod</summary>
        
        public String SecretNamespace { get; set; }

        /// <summary>Share Name</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ShareName { get; set; }
    }

    /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>

    public partial class AzureFileVolumeSource
    {
        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>the name of secret that contains Azure Storage Account Name and Key</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String SecretName { get; set; }

        /// <summary>Share Name</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ShareName { get; set; }
    }

    /// <summary>Binding ties one Object to another; for example, a pod is bound to a node by a scheduler. Deprecated in 1.7, please use the bindings subresource of pods instead.</summary>

    public partial class Binding
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public BindingKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The target Object that you want to bind to the standard Object.</summary>
        
        [Required]
        public ObjectReference Target { get; set; } = new ObjectReference();
    }

    /// <summary>Represents storage that is managed by an external CSI volume driver (Beta feature)</summary>

    public partial class CSIPersistentVolumeSource
    {
        /// <summary>ControllerPublishSecretRef is a reference to the secret Object containing sensitive information to pass to the CSI driver to complete the CSI ControllerPublishVolume and ControllerUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret Object contains more than one secret, all secrets are passed.</summary>
        
        public SecretReference ControllerPublishSecretRef { get; set; }

        /// <summary>Driver is the name of the driver to use for this volume. Required.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Driver { get; set; }

        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs".</summary>
        
        public String FsType { get; set; }

        /// <summary>NodePublishSecretRef is a reference to the secret Object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret Object contains more than one secret, all secrets are passed.</summary>
        
        public SecretReference NodePublishSecretRef { get; set; }

        /// <summary>NodeStageSecretRef is a reference to the secret Object containing sensitive information to pass to the CSI driver to complete the CSI NodeStageVolume and NodeStageVolume and NodeUnstageVolume calls. This field is optional, and may be empty if no secret is required. If the secret Object contains more than one secret, all secrets are passed.</summary>
        
        public SecretReference NodeStageSecretRef { get; set; }

        /// <summary>Optional: The value to pass to ControllerPublishVolumeRequest. Defaults to false (read/write).</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Attributes of the volume to publish.</summary>
        
        public IDictionary<String, String> VolumeAttributes { get; set; }

        /// <summary>VolumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls. Required.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String VolumeHandle { get; set; }
    }

    /// <summary>Represents a source location of a volume to mount, managed by an external CSI driver</summary>

    public partial class CSIVolumeSource
    {
        /// <summary>Driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Driver { get; set; }

        /// <summary>Filesystem type to mount. Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.</summary>
        
        public String FsType { get; set; }

        /// <summary>NodePublishSecretRef is a reference to the secret Object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and  may be empty if no secret is required. If the secret Object contains more than one secret, all secret references are passed.</summary>
        
        public LocalObjectReference NodePublishSecretRef { get; set; }

        /// <summary>Specifies a read-only configuration for the volume. Defaults to false (read/write).</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>VolumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver's documentation for supported values.</summary>
        
        public IDictionary<String, String> VolumeAttributes { get; set; }
    }

    /// <summary>Adds and removes POSIX capabilities from running containers.</summary>

    public partial class Capabilities
    {
        /// <summary>Added capabilities</summary>
        
        public ICollection<String> Add { get; set; }

        /// <summary>Removed capabilities</summary>
        
        public ICollection<String> Drop { get; set; }
    }

    /// <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class CephFSPersistentVolumeSource
    {
        /// <summary>Required: Monitors is a collection of Ceph monitors More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        [Required]
        public ICollection<String> Monitors { get; set; } = new Collection<String>();

        /// <summary>Optional: Used as the mounted root, rather than the full Ceph tree, default is /</summary>
        
        public String Path { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public String SecretFile { get; set; }

        /// <summary>Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public SecretReference SecretRef { get; set; }

        /// <summary>Optional: User is the rados user name, default is admin More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public String User { get; set; }
    }

    /// <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class CephFSVolumeSource
    {
        /// <summary>Required: Monitors is a collection of Ceph monitors More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        [Required]
        public ICollection<String> Monitors { get; set; } = new Collection<String>();

        /// <summary>Optional: Used as the mounted root, rather than the full Ceph tree, default is /</summary>
        
        public String Path { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public String SecretFile { get; set; }

        /// <summary>Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public LocalObjectReference SecretRef { get; set; }

        /// <summary>Optional: User is the rados user name, default is admin More info: https://releases.k8s.io/HEAD/examples/volumes/cephfs/README.md#how-to-use-it</summary>
        
        public String User { get; set; }
    }

    /// <summary>Represents a cinder volume resource in Openstack. A Cinder volume must exist before mounting to a container. The volume must also be in the same region as the kubelet. Cinder volumes support ownership management and SELinux relabeling.</summary>

    public partial class CinderPersistentVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        public String FsType { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: points to a secret Object containing parameters used to connect to OpenStack.</summary>
        
        public SecretReference SecretRef { get; set; }

        /// <summary>volume id used to identify the volume in cinder More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String VolumeID { get; set; }
    }

    /// <summary>Represents a cinder volume resource in Openstack. A Cinder volume must exist before mounting to a container. The volume must also be in the same region as the kubelet. Cinder volumes support ownership management and SELinux relabeling.</summary>

    public partial class CinderVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        public String FsType { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: points to a secret Object containing parameters used to connect to OpenStack.</summary>
        
        public LocalObjectReference SecretRef { get; set; }

        /// <summary>volume id used to identify the volume in cinder More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String VolumeID { get; set; }
    }

    /// <summary>ClientIPConfig represents the configurations of Client IP based session affinity.</summary>

    public partial class ClientIPConfig
    {
        /// <summary>timeoutSeconds specifies the seconds of ClientIP type session sticky time. The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).</summary>
        
        public int? TimeoutSeconds { get; set; }
    }

    /// <summary>Information about the condition of a component.</summary>

    public partial class ComponentCondition
    {
        /// <summary>Condition error code for a component. For example, a health check error code.</summary>
        
        public String Error { get; set; }

        /// <summary>Message about the condition for a component. For example, information about a health check.</summary>
        
        public String Message { get; set; }

        /// <summary>Status of the condition for a component. Valid values for "Healthy": "True", "False", or "Unknown".</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of condition for a component. Valid value: "Healthy"</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>ComponentStatus (and ComponentStatusList) holds the cluster validation info.</summary>

    public partial class ComponentStatus
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of component conditions observed</summary>
        
        public ICollection<ComponentCondition> Conditions { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ComponentStatusKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }
    }

    /// <summary>Status of all the conditions for the component as a list of ComponentStatus objects.</summary>

    public partial class ComponentStatusList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of ComponentStatus objects.</summary>
        
        [Required]
        public ICollection<ComponentStatus> Items { get; set; } = new Collection<ComponentStatus>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ComponentStatusListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ConfigMap holds configuration data for pods to consume.</summary>

    public partial class ConfigMap
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>BinaryData contains the binary data. Each key must consist of alphanumeric characters, '-', '_' or '.'. BinaryData can contain byte sequences that are not in the UTF-8 range. The keys stored in BinaryData must not overlap with the ones in the Data field, this is enforced during validation process. Using this field will require 1.10+ apiserver and kubelet.</summary>
        
        public IDictionary<String, String> BinaryData { get; set; }

        /// <summary>Data contains the configuration data. Each key must consist of alphanumeric characters, '-', '_' or '.'. Values with non-UTF-8 byte sequences must use the BinaryData field. The keys stored in Data must not overlap with the keys in the BinaryData field, this is enforced during validation process.</summary>
        
        public IDictionary<String, String> Data { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ConfigMapKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }
    }

    /// <summary>ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.
    /// <br/>
    /// <br/>The contents of the target ConfigMap's Data field will represent the key-value pairs as environment variables.</summary>

    public partial class ConfigMapEnvSource
    {
        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the ConfigMap must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>Selects a key from a ConfigMap.</summary>

    public partial class ConfigMapKeySelector
    {
        /// <summary>The key to select.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the ConfigMap or it's key must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>ConfigMapList is a resource containing a list of ConfigMap objects.</summary>

    public partial class ConfigMapList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of ConfigMaps.</summary>
        
        [Required]
        public ICollection<ConfigMap> Items { get; set; } = new Collection<ConfigMap>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ConfigMapListKind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }

    }

    /// <summary>ConfigMapNodeConfigSource contains the information to reference a ConfigMap as a config source for the Node.</summary>

    public partial class ConfigMapNodeConfigSource
    {
        /// <summary>KubeletConfigKey declares which key of the referenced ConfigMap corresponds to the KubeletConfiguration structure This field is required in all cases.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String KubeletConfigKey { get; set; }

        /// <summary>Name is the metadata.name of the referenced ConfigMap. This field is required in all cases.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Namespace is the metadata.namespace of the referenced ConfigMap. This field is required in all cases.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Namespace { get; set; }

        /// <summary>ResourceVersion is the metadata.ResourceVersion of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
        
        public String ResourceVersion { get; set; }

        /// <summary>UID is the metadata.UID of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
        
        public String Uid { get; set; }
    }

    /// <summary>Adapts a ConfigMap into a projected volume.
    /// <br/>
    /// <br/>The contents of the target ConfigMap's Data field will be presented in a projected volume as files using the keys in the Data field as the file names, unless the items element is populated with specific mappings of keys to paths. Note that this is identical to a configmap volume source without the default mode.</summary>

    public partial class ConfigMapProjection
    {
        /// <summary>If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
        
        public ICollection<KeyToPath> Items { get; set; }

        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the ConfigMap or it's keys must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>Adapts a ConfigMap into a volume.
    /// <br/>
    /// <br/>The contents of the target ConfigMap's Data field will be presented in a volume as files using the keys in the Data field as the file names, unless the items element is populated with specific mappings of keys to paths. ConfigMap volumes support ownership management and SELinux relabeling.</summary>

    public partial class ConfigMapVolumeSource
    {
        /// <summary>Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
        
        public int? DefaultMode { get; set; }

        /// <summary>If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
        
        public ICollection<KeyToPath> Items { get; set; }

        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the ConfigMap or it's keys must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>A single application container that you want to run within a pod.</summary>

    public partial class Container
    {
        /// <summary>Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input String will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
        
        public ICollection<String> Args { get; set; }

        /// <summary>Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input String will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</summary>
        
        public ICollection<String> Command { get; set; }

        /// <summary>List of environment variables to set in the container. Cannot be updated.</summary>
        
        public ICollection<EnvVar> Env { get; set; }

        /// <summary>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</summary>
        
        public ICollection<EnvFromSource> EnvFrom { get; set; }

        /// <summary>Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.</summary>
        
        public String Image { get; set; }

        /// <summary>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images</summary>
        
        public String ImagePullPolicy { get; set; }

        /// <summary>Actions that the management system should take in response to container lifecycle events. Cannot be updated.</summary>
        
        public Lifecycle Lifecycle { get; set; }

        /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
        
        public Probe LivenessProbe { get; set; }

        /// <summary>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default "0.0.0.0" address inside a container will be accessible from the network. Cannot be updated.</summary>
        
        public ICollection<ContainerNetworkExpose> Ports { get; set; }

        /// <summary>Periodic probe of container service readiness. Container will be removed from service endpoints if the probe fails. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
        
        public Probe ReadinessProbe { get; set; }

        /// <summary>Compute Resources required by this container. Cannot be updated. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/</summary>
        
        public ResourceRequirements Resources { get; set; }

        /// <summary>Security options the pod should run with. More info: https://kubernetes.io/docs/concepts/policy/security-context/ More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
        
        public SecurityContext SecurityContext { get; set; }

        /// <summary>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</summary>
        
        public Boolean? Stdin { get; set; }

        /// <summary>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</summary>
        
        public Boolean? StdinOnce { get; set; }

        /// <summary>Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</summary>
        
        public String TerminationMessagePath { get; set; }

        /// <summary>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.</summary>
        
        public String TerminationMessagePolicy { get; set; }

        /// <summary>Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.</summary>
        
        public Boolean? Tty { get; set; }

        /// <summary>volumeDevices is the list of block devices to be used by the container. This is a beta feature.</summary>
        
        public ICollection<VolumeDevice> VolumeDevices { get; set; }

        /// <summary>Pod volumes to mount into the container's filesystem. Cannot be updated.</summary>
        
        public ICollection<VolumeMount> VolumeMounts { get; set; }

        /// <summary>Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.</summary>
        
        public String WorkingDir { get; set; }
    }

    /// <summary>Describe a container image</summary>

    public partial class ContainerImage
    {
        /// <summary>Names by which this image is known. e.g. ["k8s.gcr.io/hyperkube:v1.0.7", "dockerhub.io/google_containers/hyperkube:v1.0.7"]</summary>
        
        [Required]
        public ICollection<String> Names { get; set; } = new Collection<String>();

        /// <summary>The size of the image in bytes.</summary>
        
        public long? SizeBytes { get; set; }
    }

    /// <summary>ContainerNetworkExpose represents a network port in a single container.</summary>

    public partial class ContainerNetworkExpose
    {
        /// <summary>Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.</summary>
        
        public int ContainerPort { get; set; }

        /// <summary>What host IP to bind the external port to.</summary>
        
        public String HostIP { get; set; }

        /// <summary>Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.</summary>
        
        public int? HostPort { get; set; }

        /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.</summary>
        
        public String Name { get; set; }

        /// <summary>Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".</summary>
        
        public String Protocol { get; set; }
    }

    /// <summary>ContainerState holds a possible state of container. Only one of its members may be specified. If none of them is specified, the default one is ContainerStateWaiting.</summary>

    public partial class ContainerState
    {
        /// <summary>Details about a running container</summary>
        
        public ContainerStateRunning Running { get; set; }

        /// <summary>Details about a terminated container</summary>
        
        public ContainerStateTerminated Terminated { get; set; }

        /// <summary>Details about a waiting container</summary>
        
        public ContainerStateWaiting Waiting { get; set; }
    }

    /// <summary>ContainerStateRunning is a running state of a container.</summary>

    public partial class ContainerStateRunning
    {
        /// <summary>Time at which the container was last (re-)started</summary>
        
        public DateTimeOffset? StartedAt { get; set; }
    }

    /// <summary>ContainerStateTerminated is a terminated state of a container.</summary>

    public partial class ContainerStateTerminated
    {
        /// <summary>Container's ID in the format 'docker://&lt;container_id&gt;'</summary>
        
        public String ContainerID { get; set; }

        /// <summary>Exit status from the last termination of the container</summary>
        
        public int ExitCode { get; set; }

        /// <summary>Time at which the container last terminated</summary>
        
        public DateTimeOffset? FinishedAt { get; set; }

        /// <summary>Message regarding the last termination of the container</summary>
        
        public String Message { get; set; }

        /// <summary>(brief) reason from the last termination of the container</summary>
        
        public String Reason { get; set; }

        /// <summary>Signal from the last termination of the container</summary>
        
        public int? Signal { get; set; }

        /// <summary>Time at which previous execution of the container started</summary>
        
        public DateTimeOffset? StartedAt { get; set; }
    }

    /// <summary>ContainerStateWaiting is a waiting state of a container.</summary>

    public partial class ContainerStateWaiting
    {
        /// <summary>Message regarding why the container is not yet running.</summary>
        
        public String Message { get; set; }

        /// <summary>(brief) reason the container is not yet running.</summary>
        
        public String Reason { get; set; }
    }

    /// <summary>ContainerStatus contains details for the current status of this container.</summary>

    public partial class ContainerStatus
    {
        /// <summary>Container's ID in the format 'docker://&lt;container_id&gt;'.</summary>
        
        public String ContainerID { get; set; }

        /// <summary>The image the container is running. More info: https://kubernetes.io/docs/concepts/containers/images</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Image { get; set; }

        /// <summary>ImageID of the container's image.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ImageID { get; set; }

        /// <summary>Details about the container's last termination condition.</summary>
        
        public ContainerState LastState { get; set; }

        /// <summary>This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Specifies whether the container has passed its readiness probe.</summary>
        
        public Boolean Ready { get; set; }

        /// <summary>The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.</summary>
        
        public int RestartCount { get; set; }

        /// <summary>Details about the container's current condition.</summary>
        
        public ContainerState State { get; set; }
    }

    /// <summary>DaemonEndpoint contains information about a single Daemon endpoint.</summary>

    public partial class DaemonEndpoint
    {
        /// <summary>Port number of the given endpoint.</summary>
        
        public int Port { get; set; }
    }

    /// <summary>Represents downward API info for projecting into a projected volume. Note that this is identical to a downwardAPI volume source without the default mode.</summary>

    public partial class DownwardAPIProjection
    {
        /// <summary>Items is a list of DownwardAPIVolume file</summary>
        
        public ICollection<DownwardAPIVolumeFile> Items { get; set; }
    }

    /// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field</summary>

    public partial class DownwardAPIVolumeFile
    {
        /// <summary>Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.</summary>
        
        public ObjectFieldSelector FieldRef { get; set; }

        /// <summary>Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
        
        public int? Mode { get; set; }

        /// <summary>Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }

        /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
        
        public ResourceFieldSelector ResourceFieldRef { get; set; }
    }

    /// <summary>DownwardAPIVolumeSource represents a volume containing downward API info. Downward API volumes support ownership management and SELinux relabeling.</summary>

    public partial class DownwardAPIVolumeSource
    {
        /// <summary>Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
        
        public int? DefaultMode { get; set; }

        /// <summary>Items is a list of downward API volume file</summary>
        
        public ICollection<DownwardAPIVolumeFile> Items { get; set; }
    }

    /// <summary>Represents an empty directory for a pod. Empty directory volumes support ownership management and SELinux relabeling.</summary>

    public partial class EmptyDirVolumeSource
    {
        /// <summary>What type of storage medium should back this directory. The default is "" which means to use the node's default medium. Must be an empty String (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</summary>
        
        public String Medium { get; set; }

        /// <summary>Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir</summary>
        
        public String SizeLimit { get; set; }
    }

    /// <summary>EndpointAddress is a tuple that describes single IP address.</summary>

    public partial class EndpointAddress
    {
        /// <summary>The Hostname of this endpoint</summary>
        
        public String Hostname { get; set; }

        /// <summary>The IP of this endpoint. May not be loopback (127.0.0.0/8), link-local (169.254.0.0/16), or link-local multicast ((224.0.0.0/24). IPv6 is also accepted but not fully supported on all platforms. Also, certain kubernetes components, like kube-proxy, are not IPv6 ready.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Ip { get; set; }

        /// <summary>Optional: Node hosting this endpoint. This can be used to determine endpoints local to a node.</summary>
        
        public String NodeName { get; set; }

        /// <summary>Reference to Object providing the endpoint.</summary>
        
        public ObjectReference TargetRef { get; set; }
    }

    /// <summary>EndpointPort is a tuple that describes a single port.</summary>

    public partial class EndpointPort
    {
        /// <summary>The name of this port (corresponds to ServicePort.Name). Must be a DNS_LABEL. Optional only if one port is defined.</summary>
        
        public String Name { get; set; }

        /// <summary>The port number of the endpoint.</summary>
        
        public int Port { get; set; }

        /// <summary>The IP protocol for this port. Must be UDP, TCP, or SCTP. Default is TCP.</summary>
        
        public String Protocol { get; set; }
    }

    /// <summary>EndpointSubset is a group of addresses with a common set of ports. The expanded set of endpoints is the Cartesian product of Addresses x Ports. For example, given:
    /// <br/>  {
    /// <br/>    Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
    /// <br/>    Ports:     [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
    /// <br/>  }
    /// <br/>The resulting set of endpoints can be viewed as:
    /// <br/>    a: [ 10.10.1.1:8675, 10.10.2.2:8675 ],
    /// <br/>    b: [ 10.10.1.1:309, 10.10.2.2:309 ]</summary>

    public partial class EndpointSubset
    {
        /// <summary>IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.</summary>
        
        public ICollection<EndpointAddress> Addresses { get; set; }

        /// <summary>IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.</summary>
        
        public ICollection<EndpointAddress> NotReadyAddresses { get; set; }

        /// <summary>Port numbers available on the related IP addresses.</summary>
        
        public ICollection<EndpointPort> Ports { get; set; }
    }

    /// <summary>Endpoints is a collection of endpoints that implement the actual service. Example:
    /// <br/>  Name: "mysvc",
    /// <br/>  Subsets: [
    /// <br/>    {
    /// <br/>      Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
    /// <br/>      Ports: [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
    /// <br/>    },
    /// <br/>    {
    /// <br/>      Addresses: [{"ip": "10.10.3.3"}],
    /// <br/>      Ports: [{"name": "a", "port": 93}, {"name": "b", "port": 76}]
    /// <br/>    },
    /// <br/> ]</summary>

    public partial class Endpoints
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public EndpointsKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The set of all endpoints is the union of all subsets. Addresses are placed into subsets according to the IPs they share. A single address with multiple ports, some of which are ready and some of which are not (because they come from different containers) will result in the address being displayed in different subsets for the different ports. No address will appear in both Addresses and NotReadyAddresses in the same subset. Sets of addresses and ports that comprise a service.</summary>
        
        public ICollection<EndpointSubset> Subsets { get; set; }
    }

    /// <summary>EndpointsList is a list of endpoints.</summary>

    public partial class EndpointsList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of endpoints.</summary>
        
        [Required]
        public ICollection<Endpoints> Items { get; set; } = new Collection<Endpoints>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public EndpointsListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>EnvFromSource represents the source of a set of ConfigMaps</summary>

    public partial class EnvFromSource
    {
        /// <summary>The ConfigMap to select from</summary>
        
        public ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.</summary>
        
        public String Prefix { get; set; }

        /// <summary>The Secret to select from</summary>
        
        public SecretEnvSource SecretRef { get; set; }
    }

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>

    public partial class EnvVar
    {
        /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input String will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".</summary>
        
        public String Value { get; set; }

        /// <summary>Source for the environment variable's value. Cannot be used if value is not empty.</summary>
        
        public EnvVarSource ValueFrom { get; set; }
    }

    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>

    public partial class EnvVarSource
    {
        /// <summary>Selects a key of a ConfigMap.</summary>
        
        public ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.</summary>
        
        public ObjectFieldSelector FieldRef { get; set; }

        /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.</summary>
        
        public ResourceFieldSelector ResourceFieldRef { get; set; }

        /// <summary>Selects a key of a secret in the pod's namespace</summary>
        
        public SecretKeySelector SecretKeyRef { get; set; }
    }

    /// <summary>Event is a report of an event somewhere in the cluster.</summary>

    public partial class Event
    {
        /// <summary>What action was taken/failed regarding to the Regarding Object.</summary>
        
        public String Action { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>The number of times this event has occurred.</summary>
        
        public int? Count { get; set; }

        /// <summary>Time when this Event was first observed.</summary>
        
        public DateTimeOffset? EventTime { get; set; }

        /// <summary>The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)</summary>
        
        public DateTimeOffset? FirstTimestamp { get; set; }

        /// <summary>The Object that this event is about.</summary>
        
        [Required]
        public ObjectReference InvolvedObject { get; set; } = new ObjectReference();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public EventKind? Kind { get; set; }

        /// <summary>The time at which the most recent occurrence of this event was recorded.</summary>
        
        public DateTimeOffset? LastTimestamp { get; set; }

        /// <summary>A human-readable description of the status of this operation.</summary>
        
        public String Message { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        [Required]
        public ObjectMeta Metadata { get; set; } = new ObjectMeta();

        /// <summary>This should be a short, machine understandable String that gives the reason for the transition into the Object's current status.</summary>
        
        public String Reason { get; set; }

        /// <summary>Optional secondary Object for more complex actions.</summary>
        
        public ObjectReference Related { get; set; }

        /// <summary>Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.</summary>
        
        public String ReportingComponent { get; set; }

        /// <summary>ID of the controller instance, e.g. `kubelet-xyzf`.</summary>
        
        public String ReportingInstance { get; set; }

        /// <summary>Data about the Event series this event represents or nil if it's a singleton Event.</summary>
        
        public EventSeries Series { get; set; }

        /// <summary>The component reporting this event. Should be a short machine understandable String.</summary>
        
        public EventSource Source { get; set; }

        /// <summary>Type of this event (Normal, Warning), new types could be added in the future</summary>
        
        public String Type { get; set; }
    }

    /// <summary>EventList is a list of events.</summary>

    public partial class EventList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of events</summary>
        
        [Required]
        public ICollection<Event> Items { get; set; } = new Collection<Event>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public EventListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.</summary>

    public partial class EventSeries
    {
        /// <summary>Number of occurrences in this series up to the last heartbeat time</summary>
        
        public int? Count { get; set; }

        /// <summary>Time of the last occurrence observed</summary>
        
        public DateTimeOffset? LastObservedTime { get; set; }

        /// <summary>State of this Series: Ongoing or Finished</summary>
        
        public String State { get; set; }
    }

    /// <summary>EventSource contains information for an event.</summary>

    public partial class EventSource
    {
        /// <summary>Component from which the event is generated.</summary>
        
        public String Component { get; set; }

        /// <summary>Node name on which the event is generated.</summary>
        
        public String Host { get; set; }
    }

    /// <summary>ExecAction describes a "run in container" action.</summary>

    public partial class ExecAction
    {
        /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</summary>
        
        public ICollection<String> Command { get; set; }
    }

    /// <summary>Represents a Fibre Channel volume. Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.</summary>

    public partial class FCVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>Optional: FC target lun number</summary>
        
        public int? Lun { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: FC target worldwide names (WWNs)</summary>
        
        public ICollection<String> TargetWWNs { get; set; }

        /// <summary>Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.</summary>
        
        public ICollection<String> Wwids { get; set; }
    }

    /// <summary>FlexPersistentVolumeSource represents a generic persistent volume resource that is provisioned/attached using an exec based plugin.</summary>

    public partial class FlexPersistentVolumeSource
    {
        /// <summary>Driver is the name of the driver to use for this volume.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Driver { get; set; }

        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.</summary>
        
        public String FsType { get; set; }

        /// <summary>Optional: Extra command options if any.</summary>
        
        public IDictionary<String, String> Options { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: SecretRef is reference to the secret Object containing sensitive information to pass to the plugin scripts. This may be empty if no secret Object is specified. If the secret Object contains more than one secret, all secrets are passed to the plugin scripts.</summary>
        
        public SecretReference SecretRef { get; set; }
    }

    /// <summary>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>

    public partial class FlexVolumeSource
    {
        /// <summary>Driver is the name of the driver to use for this volume.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Driver { get; set; }

        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.</summary>
        
        public String FsType { get; set; }

        /// <summary>Optional: Extra command options if any.</summary>
        
        public IDictionary<String, String> Options { get; set; }

        /// <summary>Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Optional: SecretRef is reference to the secret Object containing sensitive information to pass to the plugin scripts. This may be empty if no secret Object is specified. If the secret Object contains more than one secret, all secrets are passed to the plugin scripts.</summary>
        
        public LocalObjectReference SecretRef { get; set; }
    }

    /// <summary>Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class FlockerVolumeSource
    {
        /// <summary>Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated</summary>
        
        public String DatasetName { get; set; }

        /// <summary>UUID of the dataset. This is unique identifier of a Flocker dataset</summary>
        
        public String DatasetUUID { get; set; }
    }

    /// <summary>Represents a Persistent Disk resource in Google Compute Engine.
    /// <br/>
    /// <br/>A GCE PD must exist before mounting to a container. The disk must also be in the same GCE project and zone as the kubelet. A GCE PD can only be mounted as read/write once or read-only many times. GCE PDs support ownership management and SELinux relabeling.</summary>

    public partial class GCEPersistentDiskVolumeSource
    {
        /// <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
        
        public String FsType { get; set; }

        /// <summary>The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
        
        public int? Partition { get; set; }

        /// <summary>Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String PdName { get; set; }

        /// <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>Represents a volume that is populated with the contents of a git repository. Git repo volumes do not support ownership management. Git repo volumes support SELinux relabeling.
    /// <br/>
    /// <br/>DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.</summary>

    public partial class GitRepoVolumeSource
    {
        /// <summary>Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.</summary>
        
        public String Directory { get; set; }

        /// <summary>Repository URL</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Repository { get; set; }

        /// <summary>Commit hash for the specified revision.</summary>
        
        public String Revision { get; set; }
    }

    /// <summary>Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class GlusterfsPersistentVolumeSource
    {
        /// <summary>EndpointsName is the endpoint name that details Glusterfs topology. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Endpoints { get; set; }

        /// <summary>EndpointsNamespace is the namespace that contains Glusterfs endpoint. If this field is empty, the EndpointNamespace defaults to the same namespace as the bound PVC. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        public String EndpointsNamespace { get; set; }

        /// <summary>Path is the Glusterfs volume path. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }

        /// <summary>ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class GlusterfsVolumeSource
    {
        /// <summary>EndpointsName is the endpoint name that details Glusterfs topology. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Endpoints { get; set; }

        /// <summary>Path is the Glusterfs volume path. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }

        /// <summary>ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary>

    public partial class HTTPGetAction
    {
        /// <summary>Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.</summary>
        
        public String Host { get; set; }

        /// <summary>Custom headers to set in the request. HTTP allows repeated headers.</summary>
        
        public ICollection<HTTPHeader> HttpHeaders { get; set; }

        /// <summary>Path to access on the HTTP server.</summary>
        
        public String Path { get; set; }

        /// <summary>Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Port { get; set; }

        /// <summary>Scheme to use for connecting to the host. Defaults to HTTP.</summary>
        
        public String Scheme { get; set; }
    }

    /// <summary>HTTPHeader describes a custom header to be used in HTTP probes</summary>

    public partial class HTTPHeader
    {
        /// <summary>The header field name</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>The header field value</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Value { get; set; }
    }

    /// <summary>Handler defines a specific action that should be taken</summary>

    public partial class Handler
    {
        /// <summary>One and only one of the following should be specified. Exec specifies the action to take.</summary>
        
        public ExecAction Exec { get; set; }

        /// <summary>HTTPGet specifies the http request to perform.</summary>
        
        public HTTPGetAction HttpGet { get; set; }

        /// <summary>TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported</summary>
        
        public TCPSocketAction TcpSocket { get; set; }
    }

    /// <summary>HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.</summary>

    public partial class HostAlias
    {
        /// <summary>Hostnames for the above IP address.</summary>
        
        public ICollection<String> Hostnames { get; set; }

        /// <summary>IP address of the host file entry.</summary>
        
        public String Ip { get; set; }
    }

    /// <summary>Represents a host path mapped into a pod. Host path volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class HostPathVolumeSource
    {
        /// <summary>Path of the directory on the host. If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }

        /// <summary>Type for HostPath Volume Defaults to "" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</summary>
        
        public String Type { get; set; }
    }

    /// <summary>ISCSIPersistentVolumeSource represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.</summary>

    public partial class ISCSIPersistentVolumeSource
    {
        /// <summary>whether support iSCSI Discovery CHAP authentication</summary>
        
        public Boolean? ChapAuthDiscovery { get; set; }

        /// <summary>whether support iSCSI Session CHAP authentication</summary>
        
        public Boolean? ChapAuthSession { get; set; }

        /// <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi</summary>
        
        public String FsType { get; set; }

        /// <summary>Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface &lt;target portal&gt;:&lt;volume name&gt; will be created for the connection.</summary>
        
        public String InitiatorName { get; set; }

        /// <summary>Target iSCSI Qualified Name.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Iqn { get; set; }

        /// <summary>iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).</summary>
        
        public String IscsiInterface { get; set; }

        /// <summary>iSCSI Target Lun number.</summary>
        
        public int Lun { get; set; }

        /// <summary>iSCSI Target Portal List. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary>
        
        public ICollection<String> Portals { get; set; }

        /// <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>CHAP Secret for iSCSI target and initiator authentication</summary>
        
        public SecretReference SecretRef { get; set; }

        /// <summary>iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String TargetPortal { get; set; }
    }

    /// <summary>Represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.</summary>

    public partial class ISCSIVolumeSource
    {
        /// <summary>whether support iSCSI Discovery CHAP authentication</summary>
        
        public Boolean? ChapAuthDiscovery { get; set; }

        /// <summary>whether support iSCSI Session CHAP authentication</summary>
        
        public Boolean? ChapAuthSession { get; set; }

        /// <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi</summary>
        
        public String FsType { get; set; }

        /// <summary>Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface &lt;target portal&gt;:&lt;volume name&gt; will be created for the connection.</summary>
        
        public String InitiatorName { get; set; }

        /// <summary>Target iSCSI Qualified Name.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Iqn { get; set; }

        /// <summary>iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).</summary>
        
        public String IscsiInterface { get; set; }

        /// <summary>iSCSI Target Lun number.</summary>
        
        public int Lun { get; set; }

        /// <summary>iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary>
        
        public ICollection<String> Portals { get; set; }

        /// <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>CHAP Secret for iSCSI target and initiator authentication</summary>
        
        public LocalObjectReference SecretRef { get; set; }

        /// <summary>iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String TargetPortal { get; set; }
    }

    /// <summary>Maps a String key to a path within a volume.</summary>

    public partial class KeyToPath
    {
        /// <summary>The key to project.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
        
        public int? Mode { get; set; }

        /// <summary>The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the String '..'.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }
    }

    /// <summary>Lifecycle describes actions that the management system should take in response to container lifecycle events. For the PostStart and PreStop lifecycle handlers, management of the container blocks until the action is complete, unless the container process fails, in which case the handler is aborted.</summary>

    public partial class Lifecycle
    {
        /// <summary>PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
        
        public Handler PostStart { get; set; }

        /// <summary>PreStop is called immediately before a container is terminated due to an API request or management event such as liveness probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The reason for termination is passed to the handler. The Pod's termination grace period countdown begins before the PreStop hooked is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period. Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks</summary>
        
        public Handler PreStop { get; set; }
    }

    /// <summary>LimitRange sets resource usage limits for each kind of resource in a Namespace.</summary>

    public partial class LimitRange
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LimitRangeKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the limits enforced. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public LimitRangeSpec Spec { get; set; }
    }

    /// <summary>LimitRangeItem defines a min/max usage limit for any resource that matches on kind.</summary>

    public partial class LimitRangeItem
    {
        /// <summary>Default resource requirement limit value by resource name if resource limit is omitted.</summary>
        
        public IDictionary<String, String> Default { get; set; }

        /// <summary>DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.</summary>
        
        public IDictionary<String, String> DefaultRequest { get; set; }

        /// <summary>Max usage constraints on this kind by resource name.</summary>
        
        public IDictionary<String, String> Max { get; set; }

        /// <summary>MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value; this represents the max burst for the named resource.</summary>
        
        public IDictionary<String, String> MaxLimitRequestRatio { get; set; }

        /// <summary>Min usage constraints on this kind by resource name.</summary>
        
        public IDictionary<String, String> Min { get; set; }

        /// <summary>Type of resource that this limit applies to.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>LimitRangeList is a list of LimitRange items.</summary>

    public partial class LimitRangeList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of LimitRange objects. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/</summary>
        
        [Required]
        public ICollection<LimitRange> Items { get; set; } = new Collection<LimitRange>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public LimitRangeListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>LimitRangeSpec defines a min/max usage limit for resources that match on kind.</summary>

    public partial class LimitRangeSpec
    {
        /// <summary>Limits is the list of LimitRangeItem objects that are enforced.</summary>
        
        [Required]
        public ICollection<LimitRangeItem> Limits { get; set; } = new Collection<LimitRangeItem>();
    }

    /// <summary>LoadBalancerIngress represents the status of a load-balancer ingress point: traffic intended for the service should be sent to an ingress point.</summary>

    public partial class LoadBalancerIngress
    {
        /// <summary>Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)</summary>
        
        public String Hostname { get; set; }

        /// <summary>IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)</summary>
        
        public String Ip { get; set; }
    }

    /// <summary>LoadBalancerStatus represents the status of a load-balancer.</summary>

    public partial class LoadBalancerStatus
    {
        /// <summary>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.</summary>
        
        public ICollection<LoadBalancerIngress> Ingress { get; set; }
    }

    /// <summary>LocalObjectReference contains enough information to let you locate the referenced Object inside the same namespace.</summary>

    public partial class LocalObjectReference
    {
        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }
    }

    /// <summary>Local represents directly-attached storage with node affinity (Beta feature)</summary>

    public partial class LocalVolumeSource
    {
        /// <summary>Filesystem type to mount. It applies only when the Path is a block device. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default value is to auto-select a fileystem if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>The full path to the volume on the node. It can be either a directory or block device (disk, partition, ...).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }
    }

    /// <summary>Represents an NFS mount that lasts the lifetime of a pod. NFS volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class NFSVolumeSource
    {
        /// <summary>Path that is exported by the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }

        /// <summary>ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Server is the hostname or IP address of the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Server { get; set; }
    }

    /// <summary>Namespace provides a scope for Names. Use of multiple namespaces is optional.</summary>

    public partial class Namespace
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NamespaceKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the behavior of the Namespace. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public NamespaceSpec Spec { get; set; }

        /// <summary>Status describes the current status of a Namespace. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public NamespaceStatus Status { get; set; }
    }

    /// <summary>NamespaceList is a list of Namespaces.</summary>

    public partial class NamespaceList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Namespace objects in the list. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
        
        [Required]
        public ICollection<Namespace> Items { get; set; } = new Collection<Namespace>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NamespaceListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>NamespaceSpec describes the attributes on a Namespace.</summary>

    public partial class NamespaceSpec
    {
        /// <summary>Finalizers is an opaque list of values that must be empty to permanently remove Object from storage. More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/</summary>
        
        public ICollection<String> Finalizers { get; set; }
    }

    /// <summary>NamespaceStatus is information about the current status of a Namespace.</summary>

    public partial class NamespaceStatus
    {
        /// <summary>Phase is the current lifecycle phase of the namespace. More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/</summary>
        
        public String Phase { get; set; }
    }

    /// <summary>Node is a worker node in Kubernetes. Each node will have a unique identifier in the cache (i.e. in etcd).</summary>

    public partial class Node
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NodeKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the behavior of a node. https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public NodeSpec Spec { get; set; }

        /// <summary>Most recently observed status of the node. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public NodeStatus Status { get; set; }
    }

    /// <summary>NodeAddress contains information for the node's address.</summary>

    public partial class NodeAddress
    {
        /// <summary>The node address.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Address { get; set; }

        /// <summary>Node address type, one of Hostname, ExternalIP or InternalIP.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>Node affinity is a group of node affinity scheduling rules.</summary>

    public partial class NodeAffinity
    {
        /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
        
        public ICollection<PreferredSchedulingTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
        
        public NodeSelector RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }

    /// <summary>NodeCondition contains condition information for a node.</summary>

    public partial class NodeCondition
    {
        /// <summary>Last time we got an update on a given condition.</summary>
        
        public DateTimeOffset? LastHeartbeatTime { get; set; }

        /// <summary>Last time the condition transit from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human readable message indicating details about last transition.</summary>
        
        public String Message { get; set; }

        /// <summary>(brief) reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of node condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>NodeConfigSource specifies a source of node configuration. Exactly one subfield (excluding metadata) must be non-nil.</summary>

    public partial class NodeConfigSource
    {
        /// <summary>ConfigMap is a reference to a Node's ConfigMap</summary>
        
        public ConfigMapNodeConfigSource ConfigMap { get; set; }
    }

    /// <summary>NodeConfigStatus describes the status of the config assigned by Node.Spec.ConfigSource.</summary>

    public partial class NodeConfigStatus
    {
        /// <summary>Active reports the checkpointed config the node is actively using. Active will represent either the current version of the Assigned config, or the current LastKnownGood config, depending on whether attempting to use the Assigned config results in an error.</summary>
        
        public NodeConfigSource Active { get; set; }

        /// <summary>Assigned reports the checkpointed config the node will try to use. When Node.Spec.ConfigSource is updated, the node checkpoints the associated config payload to local disk, along with a record indicating intended config. The node refers to this record to choose its config checkpoint, and reports this record in Assigned. Assigned only updates in the status after the record has been checkpointed to disk. When the Kubelet is restarted, it tries to make the Assigned config the Active config by loading and validating the checkpointed payload identified by Assigned.</summary>
        
        public NodeConfigSource Assigned { get; set; }

        /// <summary>Error describes any problems reconciling the Spec.ConfigSource to the Active config. Errors may occur, for example, attempting to checkpoint Spec.ConfigSource to the local Assigned record, attempting to checkpoint the payload associated with Spec.ConfigSource, attempting to load or validate the Assigned config, etc. Errors may occur at different points while syncing config. Earlier errors (e.g. download or checkpointing errors) will not result in a rollback to LastKnownGood, and may resolve across Kubelet retries. Later errors (e.g. loading or validating a checkpointed config) will result in a rollback to LastKnownGood. In the latter case, it is usually possible to resolve the error by fixing the config assigned in Spec.ConfigSource. You can find additional information for debugging by searching the error message in the Kubelet log. Error is a human-readable description of the error state; machines can check whether or not Error is empty, but should not rely on the stability of the Error text across Kubelet versions.</summary>
        
        public String Error { get; set; }

        /// <summary>LastKnownGood reports the checkpointed config the node will fall back to when it encounters an error attempting to use the Assigned config. The Assigned config becomes the LastKnownGood config when the node determines that the Assigned config is stable and correct. This is currently implemented as a 10-minute soak period starting when the local record of Assigned config is updated. If the Assigned config is Active at the end of this period, it becomes the LastKnownGood. Note that if Spec.ConfigSource is reset to nil (use local defaults), the LastKnownGood is also immediately reset to nil, because the local default config is always assumed good. You should not make assumptions about the node's method of determining config stability and correctness, as this may change or become configurable in the future.</summary>
        
        public NodeConfigSource LastKnownGood { get; set; }
    }

    /// <summary>NodeDaemonEndpoints lists ports opened by daemons running on the Node.</summary>

    public partial class NodeDaemonEndpoints
    {
        /// <summary>Endpoint on which Kubelet is listening.</summary>
        
        public DaemonEndpoint KubeletEndpoint { get; set; }
    }

    /// <summary>NodeList is the whole list of all Nodes which have been registered with master.</summary>

    public partial class NodeList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of nodes</summary>
        
        [Required]
        public ICollection<Node> Items { get; set; } = new Collection<Node>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NodeListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.</summary>

    public partial class NodeSelector
    {
        /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
        
        [Required]
        public ICollection<NodeSelectorTerm> NodeSelectorTerms { get; set; } = new Collection<NodeSelectorTerm>();
    }

    /// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>

    public partial class NodeSelectorRequirement
    {
        /// <summary>The label key that the selector applies to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Operator { get; set; }

        /// <summary>An array of String values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
        
        public ICollection<String> Values { get; set; }
    }

    /// <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary>

    public partial class NodeSelectorTerm
    {
        /// <summary>A list of node selector requirements by node's labels.</summary>
        
        public ICollection<NodeSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>A list of node selector requirements by node's fields.</summary>
        
        public ICollection<NodeSelectorRequirement> MatchFields { get; set; }
    }

    /// <summary>NodeSpec describes the attributes that a node is created with.</summary>

    public partial class NodeSpec
    {
        /// <summary>If specified, the source to get node configuration from The DynamicKubeletConfig feature gate must be enabled for the Kubelet to use this field</summary>
        
        public NodeConfigSource ConfigSource { get; set; }

        /// <summary>Deprecated. Not all kubelets will set this field. Remove field after 1.13. see: https://issues.k8s.io/61966</summary>
        
        public String ExternalID { get; set; }

        /// <summary>PodCIDR represents the pod IP range assigned to the node.</summary>
        
        public String PodCIDR { get; set; }

        /// <summary>ID of the node assigned by the cloud provider in the format: &lt;ProviderName&gt;://&lt;ProviderSpecificNodeID&gt;</summary>
        
        public String ProviderID { get; set; }

        /// <summary>If specified, the node's taints.</summary>
        
        public ICollection<Taint> Taints { get; set; }

        /// <summary>Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration</summary>
        
        public Boolean? Unschedulable { get; set; }
    }

    /// <summary>NodeStatus is information about the current status of a node.</summary>

    public partial class NodeStatus
    {
        /// <summary>List of addresses reachable to the node. Queried from cloud provider, if available. More info: https://kubernetes.io/docs/concepts/nodes/node/#addresses</summary>
        
        public ICollection<NodeAddress> Addresses { get; set; }

        /// <summary>Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.</summary>
        
        public IDictionary<String, String> Allocatable { get; set; }

        /// <summary>Capacity represents the total resources of a node. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</summary>
        
        public IDictionary<String, String> Capacity { get; set; }

        /// <summary>Conditions is an array of current observed node conditions. More info: https://kubernetes.io/docs/concepts/nodes/node/#condition</summary>
        
        public ICollection<NodeCondition> Conditions { get; set; }

        /// <summary>Status of the config assigned to the node via the dynamic Kubelet config feature.</summary>
        
        public NodeConfigStatus Config { get; set; }

        /// <summary>Endpoints of daemons running on the Node.</summary>
        
        public NodeDaemonEndpoints DaemonEndpoints { get; set; }

        /// <summary>List of container images on this node</summary>
        
        public ICollection<ContainerImage> Images { get; set; }

        /// <summary>Set of ids/uuids to uniquely identify the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#info</summary>
        
        public NodeSystemInfo NodeInfo { get; set; }

        /// <summary>NodePhase is the recently observed lifecycle phase of the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#phase The field is never populated, and now is deprecated.</summary>
        
        public String Phase { get; set; }

        /// <summary>List of volumes that are attached to the node.</summary>
        
        public ICollection<AttachedVolume> VolumesAttached { get; set; }

        /// <summary>List of attachable volumes in use (mounted) by the node.</summary>
        
        public ICollection<String> VolumesInUse { get; set; }
    }

    /// <summary>NodeSystemInfo is a set of ids/uuids to uniquely identify the node.</summary>

    public partial class NodeSystemInfo
    {
        /// <summary>The Architecture reported by the node</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Architecture { get; set; }

        /// <summary>Boot ID reported by the node.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String BootID { get; set; }

        /// <summary>ContainerRuntime Version reported by the node through runtime remote API (e.g. docker://1.5.0).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ContainerRuntimeVersion { get; set; }

        /// <summary>Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String KernelVersion { get; set; }

        /// <summary>KubeProxy Version reported by the node.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String KubeProxyVersion { get; set; }

        /// <summary>Kubelet Version reported by the node.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String KubeletVersion { get; set; }

        /// <summary>MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MachineID { get; set; }

        /// <summary>The Operating System reported by the node</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String OperatingSystem { get; set; }

        /// <summary>OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String OsImage { get; set; }

        /// <summary>SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-US/Red_Hat_Subscription_Management/1/html/RHSM/getting-system-uuid.html</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String SystemUUID { get; set; }
    }

    /// <summary>ObjectFieldSelector selects an APIVersioned field of an Object.</summary>

    public partial class ObjectFieldSelector
    {
        /// <summary>Version of the schema the FieldPath is written in terms of, defaults to "v1".</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Path of the field to select in the specified API version.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String FieldPath { get; set; }
    }

    /// <summary>ObjectReference contains enough information to let you inspect or modify the referred Object.</summary>

    public partial class ObjectReference
    {
        /// <summary>API version of the referent.</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>If referring to a piece of an Object instead of an entire Object, this String should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the Object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an Object.</summary>
        
        public String FieldPath { get; set; }

        /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public String Kind { get; set; }

        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
        
        public String Namespace { get; set; }

        /// <summary>Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</summary>
        
        public String ResourceVersion { get; set; }

        /// <summary>UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids</summary>
        
        public String Uid { get; set; }
    }

    /// <summary>PersistentVolume (PV) is a storage resource provisioned by an administrator. It is analogous to a node. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes</summary>

    public partial class PersistentVolume
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PersistentVolumeKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines a specification of a persistent volume owned by the cluster. Provisioned by an administrator. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistent-volumes</summary>
        
        public PersistentVolumeSpec Spec { get; set; }

        /// <summary>Status represents the current information/status for the persistent volume. Populated by the system. Read-only. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistent-volumes</summary>
        
        public PersistentVolumeStatus Status { get; set; }
    }

    /// <summary>PersistentVolumeClaim is a user's request for and claim to a persistent volume</summary>

    public partial class PersistentVolumeClaim
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PersistentVolumeClaimKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the desired characteristics of a volume requested by a pod author. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
        
        public PersistentVolumeClaimSpec Spec { get; set; }

        /// <summary>Status represents the current information/status of a persistent volume claim. Read-only. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
        
        public PersistentVolumeClaimStatus Status { get; set; }
    }

    /// <summary>PersistentVolumeClaimCondition contails details about state of pvc</summary>

    public partial class PersistentVolumeClaimCondition
    {
        /// <summary>Last time we probed the condition.</summary>
        
        public DateTimeOffset? LastProbeTime { get; set; }

        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human-readable message indicating details about last transition.</summary>
        
        public String Message { get; set; }

        /// <summary>Unique, this should be a short, machine understandable String that gives the reason for condition's last transition. If it reports "ResizeStarted" that means the underlying persistent volume is being resized.</summary>
        
        public String Reason { get; set; }

        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>PersistentVolumeClaimList is a list of PersistentVolumeClaim items.</summary>

    public partial class PersistentVolumeClaimList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>A list of persistent volume claims. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
        
        [Required]
        public ICollection<PersistentVolumeClaim> Items { get; set; } = new Collection<PersistentVolumeClaim>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PersistentVolumeClaimListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes</summary>

    public partial class PersistentVolumeClaimSpec
    {
        /// <summary>AccessModes contains the desired access modes the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
        
        public ICollection<String> AccessModes { get; set; }

        /// <summary>This field requires the VolumeSnapshotDataSource alpha feature gate to be enabled and currently VolumeSnapshot is the only supported data source. If the provisioner can support VolumeSnapshot data source, it will create a new volume and data will be restored to the volume at the same time. If the provisioner does not support VolumeSnapshot data source, volume will not be created and the failure will be reported as an event. In the future, we plan to support more data source types and the behavior of the provisioner may change.</summary>
        
        public TypedLocalObjectReference DataSource { get; set; }

        /// <summary>Resources represents the minimum resources the volume should have. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources</summary>
        
        public ResourceRequirements Resources { get; set; }

        /// <summary>A label query over volumes to consider for binding.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>Name of the StorageClass required by the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1</summary>
        
        public String StorageClassName { get; set; }

        /// <summary>volumeMode defines what type of volume is required by the claim. Value of Filesystem is implied when not included in claim spec. This is a beta feature.</summary>
        
        public String VolumeMode { get; set; }

        /// <summary>VolumeName is the binding reference to the PersistentVolume backing this claim.</summary>
        
        public String VolumeName { get; set; }
    }

    /// <summary>PersistentVolumeClaimStatus is the current status of a persistent volume claim.</summary>

    public partial class PersistentVolumeClaimStatus
    {
        /// <summary>AccessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1</summary>
        
        public ICollection<String> AccessModes { get; set; }

        /// <summary>Represents the actual resources of the underlying volume.</summary>
        
        public IDictionary<String, String> Capacity { get; set; }

        /// <summary>Current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to 'ResizeStarted'.</summary>
        
        public ICollection<PersistentVolumeClaimCondition> Conditions { get; set; }

        /// <summary>Phase represents the current phase of PersistentVolumeClaim.</summary>
        
        public String Phase { get; set; }
    }

    /// <summary>PersistentVolumeClaimVolumeSource references the user's PVC in the same namespace. This volume finds the bound PV and mounts that volume for the pod. A PersistentVolumeClaimVolumeSource is, essentially, a wrapper around another type of volume that is owned by someone else (the system).</summary>

    public partial class PersistentVolumeClaimVolumeSource
    {
        /// <summary>ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ClaimName { get; set; }

        /// <summary>Will force the ReadOnly setting in VolumeMounts. Default false.</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>PersistentVolumeList is a list of PersistentVolume items.</summary>

    public partial class PersistentVolumeList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of persistent volumes. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes</summary>
        
        [Required]
        public ICollection<PersistentVolume> Items { get; set; } = new Collection<PersistentVolume>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PersistentVolumeListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PersistentVolumeSpec is the specification of a persistent volume.</summary>

    public partial class PersistentVolumeSpec
    {
        /// <summary>AccessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes</summary>
        
        public ICollection<String> AccessModes { get; set; }

        /// <summary>AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
        
        public AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
        
        public AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
        
        public AzureFilePersistentVolumeSource AzureFile { get; set; }

        /// <summary>A description of the persistent volume's resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</summary>
        
        public IDictionary<String, String> Capacity { get; set; }

        /// <summary>CephFS represents a Ceph FS mount on the host that shares a pod's lifetime</summary>
        
        public CephFSPersistentVolumeSource Cephfs { get; set; }

        /// <summary>Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        public CinderPersistentVolumeSource Cinder { get; set; }

        /// <summary>ClaimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding</summary>
        
        public ObjectReference ClaimRef { get; set; }

        /// <summary>CSI represents storage that is handled by an external CSI driver (Beta feature).</summary>
        
        public CSIPersistentVolumeSource Csi { get; set; }

        /// <summary>FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        
        public FCVolumeSource Fc { get; set; }

        /// <summary>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
        
        public FlexPersistentVolumeSource FlexVolume { get; set; }

        /// <summary>Flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running</summary>
        
        public FlockerVolumeSource Flocker { get; set; }

        /// <summary>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
        
        public GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>Glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md</summary>
        
        public GlusterfsPersistentVolumeSource Glusterfs { get; set; }

        /// <summary>HostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</summary>
        
        public HostPathVolumeSource HostPath { get; set; }

        /// <summary>ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.</summary>
        
        public ISCSIPersistentVolumeSource Iscsi { get; set; }

        /// <summary>Local represents directly-attached storage with node affinity</summary>
        
        public LocalVolumeSource Local { get; set; }

        /// <summary>A list of mount options, e.g. ["ro", "soft"]. Not validated - mount will simply fail if one is invalid. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options</summary>
        
        public ICollection<String> MountOptions { get; set; }

        /// <summary>NFS represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
        
        public NFSVolumeSource Nfs { get; set; }

        /// <summary>NodeAffinity defines constraints that limit what nodes this volume can be accessed from. This field influences the scheduling of pods that use this volume.</summary>
        
        public VolumeNodeAffinity NodeAffinity { get; set; }

        /// <summary>What happens to a persistent volume when released from its claim. Valid options are Retain (default for manually created PersistentVolumes), Delete (default for dynamically provisioned PersistentVolumes), and Recycle (deprecated). Recycle must be supported by the volume plugin underlying this PersistentVolume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming</summary>
        
        public String PersistentVolumeReclaimPolicy { get; set; }

        /// <summary>PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine</summary>
        
        public PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>PortworxVolume represents a portworx volume attached and mounted on kubelets host machine</summary>
        
        public PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>Quobyte represents a Quobyte mount on the host that shares a pod's lifetime</summary>
        
        public QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md</summary>
        
        public RBDPersistentVolumeSource Rbd { get; set; }

        /// <summary>ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
        
        public ScaleIOPersistentVolumeSource ScaleIO { get; set; }

        /// <summary>Name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.</summary>
        
        public String StorageClassName { get; set; }

        /// <summary>StorageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod More info: https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md</summary>
        
        public StorageOSPersistentVolumeSource Storageos { get; set; }

        /// <summary>volumeMode defines if a volume is intended to be used with a formatted filesystem or to remain in raw block state. Value of Filesystem is implied when not included in spec. This is a beta feature.</summary>
        
        public String VolumeMode { get; set; }

        /// <summary>VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine</summary>
        
        public VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }
    }

    /// <summary>PersistentVolumeStatus is the current status of a persistent volume.</summary>

    public partial class PersistentVolumeStatus
    {
        /// <summary>A human-readable message indicating details about why the volume is in this state.</summary>
        
        public String Message { get; set; }

        /// <summary>Phase indicates if a volume is available, bound to a claim, or released by a claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#phase</summary>
        
        public String Phase { get; set; }

        /// <summary>Reason is a brief CamelCase String that describes any failure and is meant for machine parsing and tidy display in the CLI.</summary>
        
        public String Reason { get; set; }
    }

    /// <summary>Represents a Photon Controller persistent disk resource.</summary>

    public partial class PhotonPersistentDiskVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>ID that identifies Photon Controller persistent disk</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String PdID { get; set; }
    }

    /// <summary>Pod is a collection of containers that can run on a host. This resource is created by clients and scheduled onto hosts.</summary>

    public partial class Pod
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the pod. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public PodSpec Spec { get; set; }

        /// <summary>Most recently observed status of the pod. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public PodStatus Status { get; set; }
    }

    /// <summary>Pod affinity is a group of inter pod affinity scheduling rules.</summary>

    public partial class PodAffinity
    {
        /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
        
        public ICollection<WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
        
        public ICollection<PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }

    /// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>

    public partial class PodAffinityTerm
    {
        /// <summary>A label query over a set of resources, in this case pods.</summary>
        
        public LabelSelector LabelSelector { get; set; }

        /// <summary>namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"</summary>
        
        public ICollection<String> Namespaces { get; set; }

        /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String TopologyKey { get; set; }
    }

    /// <summary>Pod anti affinity is a group of inter pod anti affinity scheduling rules.</summary>

    public partial class PodAntiAffinity
    {
        /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
        
        public ICollection<WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
        
        public ICollection<PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
    }

    /// <summary>PodCondition contains details for the current condition of this pod.</summary>

    public partial class PodCondition
    {
        /// <summary>Last time we probed the condition.</summary>
        
        public DateTimeOffset? LastProbeTime { get; set; }

        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human-readable message indicating details about last transition.</summary>
        
        public String Message { get; set; }

        /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status is the status of the condition. Can be True, False, Unknown. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type is the type of the condition. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>PodDNSConfig defines the DNS parameters of a pod in addition to those generated from DNSPolicy.</summary>

    public partial class PodDNSConfig
    {
        /// <summary>A list of DNS name server IP addresses. This will be appended to the base nameservers generated from DNSPolicy. Duplicated nameservers will be removed.</summary>
        
        public ICollection<String> Nameservers { get; set; }

        /// <summary>A list of DNS resolver options. This will be merged with the base options generated from DNSPolicy. Duplicated entries will be removed. Resolution options given in Options will override those that appear in the base DNSPolicy.</summary>
        
        public ICollection<PodDNSConfigOption> Options { get; set; }

        /// <summary>A list of DNS search domains for host-name lookup. This will be appended to the base search paths generated from DNSPolicy. Duplicated search paths will be removed.</summary>
        
        public ICollection<String> Searches { get; set; }
    }

    /// <summary>PodDNSConfigOption defines DNS resolver options of a pod.</summary>

    public partial class PodDNSConfigOption
    {
        /// <summary>Required.</summary>
        
        public String Name { get; set; }

        
        public String Value { get; set; }
    }

    /// <summary>PodList is a list of Pods.</summary>

    public partial class PodList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of pods. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md</summary>
        
        [Required]
        public ICollection<Pod> Items { get; set; } = new Collection<Pod>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodReadinessGate contains the reference to a pod condition</summary>

    public partial class PodReadinessGate
    {
        /// <summary>ConditionType refers to a condition in the pod's condition list with matching type.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ConditionType { get; set; }
    }

    /// <summary>PodSecurityContext holds pod-level security attributes and common container settings. Some fields are also present in container.securityContext.  Field values of container.securityContext take precedence over field values of PodSecurityContext.</summary>

    public partial class PodSecurityContext
    {
        /// <summary>A special supplemental group that applies to all containers in a pod. Some volume types allow the Kubelet to change the ownership of that volume to be owned by the pod:
        /// <br/>
        /// <br/>1. The owning GID will be the FSGroup 2. The setgid bit is set (new files created in the volume will be owned by FSGroup) 3. The permission bits are OR'd with rw-rw----
        /// <br/>
        /// <br/>If unset, the Kubelet will not modify the ownership and permissions of any volume.</summary>
        
        public long? FsGroup { get; set; }

        /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</summary>
        
        public long? RunAsGroup { get; set; }

        /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
        
        public Boolean? RunAsNonRoot { get; set; }

        /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</summary>
        
        public long? RunAsUser { get; set; }

        /// <summary>The SELinux context to be applied to all containers. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in SecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence for that container.</summary>
        
        public SELinuxOptions SeLinuxOptions { get; set; }

        /// <summary>A list of groups applied to the first process run in each container, in addition to the container's primary GID.  If unspecified, no groups will be added to any container.</summary>
        
        public ICollection<long> SupplementalGroups { get; set; }

        /// <summary>Sysctls hold a list of namespaced sysctls used for the pod. Pods with unsupported sysctls (by the container runtime) might fail to launch.</summary>
        
        public ICollection<Sysctl> Sysctls { get; set; }
    }

    /// <summary>PodSpec is a description of a pod.</summary>

    public partial class PodSpec
    {
        /// <summary>Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.</summary>
        
        public long? ActiveDeadlineSeconds { get; set; }

        /// <summary>If specified, the pod's scheduling constraints</summary>
        
        public Affinity Affinity { get; set; }

        /// <summary>AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.</summary>
        
        public Boolean? AutomountServiceAccountToken { get; set; }

        /// <summary>List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.</summary>
        
        [Required]
        public ICollection<Container> Containers { get; set; } = new Collection<Container>();

        /// <summary>Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.</summary>
        
        public PodDNSConfig DnsConfig { get; set; }

        /// <summary>Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.</summary>
        
        public String DnsPolicy { get; set; }

        /// <summary>EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Defaults to true.</summary>
        
        public Boolean? EnableServiceLinks { get; set; }

        /// <summary>HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified. This is only valid for non-hostNetwork pods.</summary>
        
        public ICollection<HostAlias> HostAliases { get; set; }

        /// <summary>Use the host's ipc namespace. Optional: Default to false.</summary>
        
        public Boolean? HostIPC { get; set; }

        /// <summary>Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.</summary>
        
        public Boolean? HostNetwork { get; set; }

        /// <summary>Use the host's pid namespace. Optional: Default to false.</summary>
        
        public Boolean? HostPID { get; set; }

        /// <summary>Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.</summary>
        
        public String Hostname { get; set; }

        /// <summary>ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</summary>
        
        public ICollection<LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, or Liveness probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/</summary>
        
        public ICollection<Container> InitContainers { get; set; }

        /// <summary>NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.</summary>
        
        public String NodeName { get; set; }

        /// <summary>NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</summary>
        
        public IDictionary<String, String> NodeSelector { get; set; }

        /// <summary>The priority value. Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.</summary>
        
        public int? Priority { get; set; }

        /// <summary>If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass Object with that name. If not specified, the pod priority will be default or zero if there is no default.</summary>
        
        public String PriorityClassName { get; set; }

        /// <summary>If specified, all readiness gates will be evaluated for pod readiness. A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md</summary>
        
        public ICollection<PodReadinessGate> ReadinessGates { get; set; }

        /// <summary>Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy</summary>
        
        public String RestartPolicy { get; set; }

        /// <summary>RuntimeClassName refers to a RuntimeClass Object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This is an alpha feature and may change in the future.</summary>
        
        public String RuntimeClassName { get; set; }

        /// <summary>If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.</summary>
        
        public String SchedulerName { get; set; }

        /// <summary>SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.</summary>
        
        public PodSecurityContext SecurityContext { get; set; }

        /// <summary>DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.</summary>
        
        public String ServiceAccount { get; set; }

        /// <summary>ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</summary>
        
        public String ServiceAccountName { get; set; }

        /// <summary>Share a single process namespace between all of the containers in a pod. When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false. This field is beta-level and may be disabled with the PodShareProcessNamespace feature.</summary>
        
        public Boolean? ShareProcessNamespace { get; set; }

        /// <summary>If specified, the fully qualified Pod hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the pod will not have a domainname at all.</summary>
        
        public String Subdomain { get; set; }

        /// <summary>Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.</summary>
        
        public long? TerminationGracePeriodSeconds { get; set; }

        /// <summary>If specified, the pod's tolerations.</summary>
        
        public ICollection<Toleration> Tolerations { get; set; }

        /// <summary>List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes</summary>
        
        public ICollection<Volume> Volumes { get; set; }
    }

    /// <summary>PodStatus represents information about the status of a pod. Status may trail the actual state of a system, especially if the node that hosts the pod cannot contact the control plane.</summary>

    public partial class PodStatus
    {
        /// <summary>Current service state of pod. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</summary>
        
        public ICollection<PodCondition> Conditions { get; set; }

        /// <summary>The list has one entry per container in the manifest. Each entry is currently the output of `docker inspect`. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</summary>
        
        public ICollection<ContainerStatus> ContainerStatuses { get; set; }

        /// <summary>IP address of the host to which the pod is assigned. Empty if not yet scheduled.</summary>
        
        public String HostIP { get; set; }

        /// <summary>The list has one entry per init container in the manifest. The most recent successful init container will have ready = true, the most recently started container will have startTime set. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-and-container-status</summary>
        
        public ICollection<ContainerStatus> InitContainerStatuses { get; set; }

        /// <summary>A human readable message indicating details about why the pod is in this condition.</summary>
        
        public String Message { get; set; }

        /// <summary>nominatedNodeName is set only when this pod preempts other pods on the node, but it cannot be scheduled right away as preemption victims receive their graceful termination periods. This field does not guarantee that the pod will be scheduled on this node. Scheduler may decide to place the pod elsewhere if other nodes become available sooner. Scheduler may also decide to give the resources on this node to a higher priority pod that is created after preemption. As a result, this field may be different than PodSpec.nodeName when the pod is scheduled.</summary>
        
        public String NominatedNodeName { get; set; }

        /// <summary>The phase of a Pod is a simple, high-level summary of where the Pod is in its lifecycle. The conditions array, the reason and message fields, and the individual container status arrays contain more detail about the pod's status. There are five possible phase values:
        /// <br/>
        /// <br/>Pending: The pod has been accepted by the Kubernetes system, but one or more of the container images has not been created. This includes time before being scheduled as well as time spent downloading images over the network, which could take a while. Running: The pod has been bound to a node, and all of the containers have been created. At least one container is still running, or is in the process of starting or restarting. Succeeded: All containers in the pod have terminated in success, and will not be restarted. Failed: All containers in the pod have terminated, and at least one container has terminated in failure. The container either exited with non-zero status or was terminated by the system. Unknown: For some reason the state of the pod could not be obtained, typically due to an error in communicating with the host of the pod.
        /// <br/>
        /// <br/>More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-phase</summary>
        
        public String Phase { get; set; }

        /// <summary>IP address allocated to the pod. Routable at least within the cluster. Empty if not yet allocated.</summary>
        
        public String PodIP { get; set; }

        /// <summary>The Quality of Service (QOS) classification assigned to the pod based on resource requirements See PodQOSClass type for available QOS classes More info: https://git.k8s.io/community/contributors/design-proposals/node/resource-qos.md</summary>
        
        public String QosClass { get; set; }

        /// <summary>A brief CamelCase message indicating details about why the pod is in this state. e.g. 'Evicted'</summary>
        
        public String Reason { get; set; }

        /// <summary>RFC 3339 date and time at which the Object was acknowledged by the Kubelet. This is before the Kubelet pulled the container image(s) for the pod.</summary>
        
        public DateTimeOffset? StartTime { get; set; }
    }

    /// <summary>PodTemplate describes a template for creating copies of a predefined pod.</summary>

    public partial class PodTemplate
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodTemplateKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Template defines the pods that will be created from this pod template. https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public PodTemplateSpec Template { get; set; }
    }

    /// <summary>PodTemplateList is a list of PodTemplates.</summary>

    public partial class PodTemplateList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of pod templates</summary>
        
        [Required]
        public ICollection<PodTemplate> Items { get; set; } = new Collection<PodTemplate>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodTemplateListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodTemplateSpec describes the data a pod should have when created from a template</summary>

    public partial class PodTemplateSpec
    {
        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the pod. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public PodSpec Spec { get; set; }
    }

    /// <summary>PortworxVolumeSource represents a Portworx volume resource.</summary>

    public partial class PortworxVolumeSource
    {
        /// <summary>FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>VolumeID uniquely identifies a Portworx volume</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String VolumeID { get; set; }
    }

    /// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>

    public partial class PreferredSchedulingTerm
    {
        /// <summary>A node selector term, associated with the corresponding weight.</summary>
        
        [Required]
        public NodeSelectorTerm Preference { get; set; } = new NodeSelectorTerm();

        /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
        
        public int Weight { get; set; }
    }

    /// <summary>Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.</summary>

    public partial class Probe
    {
        /// <summary>One and only one of the following should be specified. Exec specifies the action to take.</summary>
        
        public ExecAction Exec { get; set; }

        /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
        
        public int? FailureThreshold { get; set; }

        /// <summary>HTTPGet specifies the http request to perform.</summary>
        
        public HTTPGetAction HttpGet { get; set; }

        /// <summary>Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
        
        public int? InitialDelaySeconds { get; set; }

        /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
        
        public int? PeriodSeconds { get; set; }

        /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
        
        public int? SuccessThreshold { get; set; }

        /// <summary>TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported</summary>
        
        public TCPSocketAction TcpSocket { get; set; }

        /// <summary>Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes</summary>
        
        public int? TimeoutSeconds { get; set; }
    }

    /// <summary>Represents a projected volume source</summary>

    public partial class ProjectedVolumeSource
    {
        /// <summary>Mode bits to use on created files by default. Must be a value between 0 and 0777. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
        
        public int? DefaultMode { get; set; }

        /// <summary>list of volume projections</summary>
        
        [Required]
        public ICollection<VolumeProjection> Sources { get; set; } = new Collection<VolumeProjection>();
    }

    /// <summary>Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.</summary>

    public partial class QuobyteVolumeSource
    {
        /// <summary>Group to map volume access to Default is no group</summary>
        
        public String Group { get; set; }

        /// <summary>ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Registry represents a single or multiple Quobyte Registry services specified as a String as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Registry { get; set; }

        /// <summary>Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin</summary>
        
        public String Tenant { get; set; }

        /// <summary>User to map volume access to Defaults to serivceaccount user</summary>
        
        public String User { get; set; }

        /// <summary>Volume is a String that references an already created Quobyte volume by name.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Volume { get; set; }
    }

    /// <summary>Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.</summary>

    public partial class RBDPersistentVolumeSource
    {
        /// <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd</summary>
        
        public String FsType { get; set; }

        /// <summary>The rados image name. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Image { get; set; }

        /// <summary>Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public String Keyring { get; set; }

        /// <summary>A collection of Ceph monitors. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        [Required]
        public ICollection<String> Monitors { get; set; } = new Collection<String>();

        /// <summary>The rados pool name. Default is rbd. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public String Pool { get; set; }

        /// <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public SecretReference SecretRef { get; set; }

        /// <summary>The rados user name. Default is admin. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public String User { get; set; }
    }

    /// <summary>Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.</summary>

    public partial class RBDVolumeSource
    {
        /// <summary>Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd</summary>
        
        public String FsType { get; set; }

        /// <summary>The rados image name. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Image { get; set; }

        /// <summary>Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public String Keyring { get; set; }

        /// <summary>A collection of Ceph monitors. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        [Required]
        public ICollection<String> Monitors { get; set; } = new Collection<String>();

        /// <summary>The rados pool name. Default is rbd. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public String Pool { get; set; }

        /// <summary>ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public LocalObjectReference SecretRef { get; set; }

        /// <summary>The rados user name. Default is admin. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</summary>
        
        public String User { get; set; }
    }

    /// <summary>ReplicationController represents the configuration of a replication controller.</summary>

    public partial class ReplicationController
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicationControllerKind? Kind { get; set; }

        /// <summary>If the Labels of a ReplicationController are empty, they are defaulted to be the same as the Pod(s) that the replication controller manages. Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the specification of the desired behavior of the replication controller. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ReplicationControllerSpec Spec { get; set; }

        /// <summary>Status is the most recently observed status of the replication controller. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ReplicationControllerStatus Status { get; set; }
    }

    /// <summary>ReplicationControllerCondition describes the state of a replication controller at a certain point.</summary>

    public partial class ReplicationControllerCondition
    {
        /// <summary>The last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of replication controller condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>ReplicationControllerList is a collection of replication controllers.</summary>

    public partial class ReplicationControllerList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of replication controllers. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller</summary>
        
        [Required]
        public ICollection<ReplicationController> Items { get; set; } = new Collection<ReplicationController>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicationControllerListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ReplicationControllerSpec is the specification of a replication controller.</summary>

    public partial class ReplicationControllerSpec
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Selector is a label query over pods that should match the Replicas count. If Selector is empty, it is defaulted to the labels present on the Pod template. Label keys and values that must match in order to be controlled by this replication controller, if empty defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public IDictionary<String, String> Selector { get; set; }

        /// <summary>Template is the Object that describes the pod that will be created if insufficient replicas are detected. This takes precedence over a TemplateRef. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        public PodTemplateSpec Template { get; set; }
    }

    /// <summary>ReplicationControllerStatus represents the current status of a replication controller.</summary>

    public partial class ReplicationControllerStatus
    {
        /// <summary>The number of available replicas (ready for at least minReadySeconds) for this replication controller.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Represents the latest available observations of a replication controller's current state.</summary>
        
        public ICollection<ReplicationControllerCondition> Conditions { get; set; }

        /// <summary>The number of pods that have labels matching the labels of the pod template of the replication controller.</summary>
        
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>ObservedGeneration reflects the generation of the most recently observed replication controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The number of ready replicas for this replication controller.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller</summary>
        
        public int Replicas { get; set; }
    }

    /// <summary>ResourceFieldSelector represents container resources (cpu, memory) and their output format</summary>

    public partial class ResourceFieldSelector
    {
        /// <summary>Container name: required for volumes, optional for env vars</summary>
        
        public String ContainerName { get; set; }

        /// <summary>Specifies the output format of the exposed resources, defaults to "1"</summary>
        
        public String Divisor { get; set; }

        /// <summary>Required: resource to select</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Resource { get; set; }
    }

    /// <summary>ResourceQuota sets aggregate quota restrictions enforced per namespace</summary>

    public partial class ResourceQuota
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ResourceQuotaKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the desired quota. https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ResourceQuotaSpec Spec { get; set; }

        /// <summary>Status defines the actual enforced quota and its current usage. https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ResourceQuotaStatus Status { get; set; }
    }

    /// <summary>ResourceQuotaList is a list of ResourceQuota items.</summary>

    public partial class ResourceQuotaList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ResourceQuota objects. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/</summary>
        
        [Required]
        public ICollection<ResourceQuota> Items { get; set; } = new Collection<ResourceQuota>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ResourceQuotaListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ResourceQuotaSpec defines the desired hard limits to enforce for Quota.</summary>

    public partial class ResourceQuotaSpec
    {
        /// <summary>hard is the set of desired hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/</summary>
        
        public IDictionary<String, String> Hard { get; set; }

        /// <summary>scopeSelector is also a collection of filters like scopes that must match each Object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values. For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched.</summary>
        
        public ScopeSelector ScopeSelector { get; set; }

        /// <summary>A collection of filters that must match each Object tracked by a quota. If not specified, the quota matches all objects.</summary>
        
        public ICollection<String> Scopes { get; set; }
    }

    /// <summary>ResourceQuotaStatus defines the enforced hard limits and observed use.</summary>

    public partial class ResourceQuotaStatus
    {
        /// <summary>Hard is the set of enforced hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/</summary>
        
        public IDictionary<String, String> Hard { get; set; }

        /// <summary>Used is the current observed total usage of the resource in the namespace.</summary>
        
        public IDictionary<String, String> Used { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>

    public partial class ResourceRequirements
    {
        /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/</summary>
        
        public IDictionary<String, String> Limits { get; set; }

        /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/</summary>
        
        public IDictionary<String, String> Requests { get; set; }
    }

    /// <summary>SELinuxOptions are the labels to be applied to the container</summary>

    public partial class SELinuxOptions
    {
        /// <summary>Level is SELinux level label that applies to the container.</summary>
        
        public String Level { get; set; }

        /// <summary>Role is a SELinux role label that applies to the container.</summary>
        
        public String Role { get; set; }

        /// <summary>Type is a SELinux type label that applies to the container.</summary>
        
        public String Type { get; set; }

        /// <summary>User is a SELinux user label that applies to the container.</summary>
        
        public String User { get; set; }
    }

    /// <summary>ScaleIOPersistentVolumeSource represents a persistent ScaleIO volume</summary>

    public partial class ScaleIOPersistentVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs"</summary>
        
        public String FsType { get; set; }

        /// <summary>The host address of the ScaleIO API Gateway.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Gateway { get; set; }

        /// <summary>The name of the ScaleIO Protection Domain for the configured storage.</summary>
        
        public String ProtectionDomain { get; set; }

        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.</summary>
        
        [Required]
        public SecretReference SecretRef { get; set; } = new SecretReference();

        /// <summary>Flag to enable/disable SSL communication with Gateway, default false</summary>
        
        public Boolean? SslEnabled { get; set; }

        /// <summary>Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.</summary>
        
        public String StorageMode { get; set; }

        /// <summary>The ScaleIO Storage Pool associated with the protection domain.</summary>
        
        public String StoragePool { get; set; }

        /// <summary>The name of the storage system as configured in ScaleIO.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String System { get; set; }

        /// <summary>The name of a volume already created in the ScaleIO system that is associated with this volume source.</summary>
        
        public String VolumeName { get; set; }
    }

    /// <summary>ScaleIOVolumeSource represents a persistent ScaleIO volume</summary>

    public partial class ScaleIOVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".</summary>
        
        public String FsType { get; set; }

        /// <summary>The host address of the ScaleIO API Gateway.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Gateway { get; set; }

        /// <summary>The name of the ScaleIO Protection Domain for the configured storage.</summary>
        
        public String ProtectionDomain { get; set; }

        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.</summary>
        
        [Required]
        public LocalObjectReference SecretRef { get; set; } = new LocalObjectReference();

        /// <summary>Flag to enable/disable SSL communication with Gateway, default false</summary>
        
        public Boolean? SslEnabled { get; set; }

        /// <summary>Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.</summary>
        
        public String StorageMode { get; set; }

        /// <summary>The ScaleIO Storage Pool associated with the protection domain.</summary>
        
        public String StoragePool { get; set; }

        /// <summary>The name of the storage system as configured in ScaleIO.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String System { get; set; }

        /// <summary>The name of a volume already created in the ScaleIO system that is associated with this volume source.</summary>
        
        public String VolumeName { get; set; }
    }

    /// <summary>A scope selector represents the AND of the selectors represented by the scoped-resource selector requirements.</summary>

    public partial class ScopeSelector
    {
        /// <summary>A list of scope selector requirements by scope of the resources.</summary>
        
        public ICollection<ScopedResourceSelectorRequirement> MatchExpressions { get; set; }
    }

    /// <summary>A scoped-resource selector requirement is a selector that contains values, a scope name, and an operator that relates the scope name and values.</summary>

    public partial class ScopedResourceSelectorRequirement
    {
        /// <summary>Represents a scope's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Operator { get; set; }

        /// <summary>The name of the scope that the selector applies to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ScopeName { get; set; }

        /// <summary>An array of String values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
        
        public ICollection<String> Values { get; set; }
    }

    /// <summary>Secret holds secret data of a certain type. The total bytes of the values in the Data field must be less than MaxSecretSize bytes.</summary>

    public partial class Secret
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Data contains the secret data. Each key must consist of alphanumeric characters, '-', '_' or '.'. The serialized form of the secret data is a base64 encoded String, representing the arbitrary (possibly non-String) data value here. Described in https://tools.ietf.org/html/rfc4648#section-4</summary>
        
        public IDictionary<String, byte[]> Data { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SecretKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>stringData allows specifying non-binary secret data in String form. It is provided as a write-only convenience method. All keys and values are merged into the data field on write, overwriting any existing values. It is never output when reading from the API.</summary>
        
        public IDictionary<String, String> StringData { get; set; }

        /// <summary>Used to facilitate programmatic handling of secret data.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>SecretEnvSource selects a Secret to populate the environment variables with.
    /// <br/>
    /// <br/>The contents of the target Secret's Data field will represent the key-value pairs as environment variables.</summary>

    public partial class SecretEnvSource
    {
        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the Secret must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>

    public partial class SecretKeySelector
    {
        /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the Secret or it's key must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>SecretList is a list of Secret.</summary>

    public partial class SecretList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of secret objects. More info: https://kubernetes.io/docs/concepts/configuration/secret</summary>
        
        [Required]
        public ICollection<Secret> Items { get; set; } = new Collection<Secret>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public SecretListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>Adapts a secret into a projected volume.
    /// <br/>
    /// <br/>The contents of the target Secret's Data field will be presented in a projected volume as files using the keys in the Data field as the file names. Note that this is identical to a secret volume source without the default mode.</summary>

    public partial class SecretProjection
    {
        /// <summary>If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
        
        public ICollection<KeyToPath> Items { get; set; }

        /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        public String Name { get; set; }

        /// <summary>Specify whether the Secret or its key must be defined</summary>
        
        public Boolean? Optional { get; set; }
    }

    /// <summary>SecretReference represents a Secret Reference. It has enough information to retrieve secret in any namespace</summary>

    public partial class SecretReference
    {
        /// <summary>Name is unique within a namespace to reference a secret resource.</summary>
        
        public String Name { get; set; }

        /// <summary>Namespace defines the space within which the secret name must be unique.</summary>
        
        public String Namespace { get; set; }
    }

    /// <summary>Adapts a Secret into a volume.
    /// <br/>
    /// <br/>The contents of the target Secret's Data field will be presented in a volume as files using the keys in the Data field as the file names. Secret volumes support ownership management and SELinux relabeling.</summary>

    public partial class SecretVolumeSource
    {
        /// <summary>Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.</summary>
        
        public int? DefaultMode { get; set; }

        /// <summary>If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.</summary>
        
        public ICollection<KeyToPath> Items { get; set; }

        /// <summary>Specify whether the Secret or it's keys must be defined</summary>
        
        public Boolean? Optional { get; set; }

        /// <summary>Name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
        
        public String SecretName { get; set; }
    }

    /// <summary>SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.</summary>

    public partial class SecurityContext
    {
        /// <summary>AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This Boolean directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN</summary>
        
        public Boolean? AllowPrivilegeEscalation { get; set; }

        /// <summary>The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.</summary>
        
        public Capabilities Capabilities { get; set; }

        /// <summary>Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.</summary>
        
        public Boolean? Privileged { get; set; }

        /// <summary>procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled.</summary>
        
        public String ProcMount { get; set; }

        /// <summary>Whether this container has a read-only root filesystem. Default is false.</summary>
        
        public Boolean? ReadOnlyRootFilesystem { get; set; }

        /// <summary>The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
        
        public long? RunAsGroup { get; set; }

        /// <summary>Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
        
        public Boolean? RunAsNonRoot { get; set; }

        /// <summary>The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
        
        public long? RunAsUser { get; set; }

        /// <summary>The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.</summary>
        
        public SELinuxOptions SeLinuxOptions { get; set; }
    }

    /// <summary>Service is a named abstraction of software service (for example, mysql) consisting of local port (for example 3306) that the proxy listens on, and the selector that determines which pods will answer requests sent through the proxy.</summary>

    public partial class Service
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ServiceKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the behavior of a service. https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ServiceSpec Spec { get; set; }

        /// <summary>Most recently observed status of the service. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public ServiceStatus Status { get; set; }
    }

    /// <summary>ServiceAccount binds together: * a name, understood by users, and perhaps by peripheral systems, for an identity * a principal that can be authenticated and authorized * a set of secrets</summary>

    public partial class ServiceAccount
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>AutomountServiceAccountToken indicates whether pods running as this service account should have an API token automatically mounted. Can be overridden at the pod level.</summary>
        
        public Boolean? AutomountServiceAccountToken { get; set; }

        /// <summary>ImagePullSecrets is a list of references to secrets in the same namespace to use for pulling any images in pods that reference this ServiceAccount. ImagePullSecrets are distinct from Secrets because Secrets can be mounted in the pod, but ImagePullSecrets are only accessed by the kubelet. More info: https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod</summary>
        
        public ICollection<LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ServiceAccountKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Secrets is the list of secrets allowed to be used by pods running using this ServiceAccount. More info: https://kubernetes.io/docs/concepts/configuration/secret</summary>
        
        public ICollection<ObjectReference> Secrets { get; set; }
    }

    /// <summary>ServiceAccountList is a list of ServiceAccount objects</summary>

    public partial class ServiceAccountList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of ServiceAccounts. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/</summary>
        
        [Required]
        public ICollection<ServiceAccount> Items { get; set; } = new Collection<ServiceAccount>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ServiceAccountListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ServiceAccountTokenProjection represents a projected service account token volume. This projection can be used to insert a service account token into the pods runtime filesystem for use against APIs (Kubernetes API Server or otherwise).</summary>

    public partial class ServiceAccountTokenProjection
    {
        /// <summary>Audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.</summary>
        
        public String Audience { get; set; }

        /// <summary>ExpirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.</summary>
        
        public long? ExpirationSeconds { get; set; }

        /// <summary>Path is the path relative to the mount point of the file to project the token into.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Path { get; set; }
    }

    /// <summary>ServiceList holds a list of services.</summary>

    public partial class ServiceList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of services</summary>
        
        [Required]
        public ICollection<Service> Items { get; set; } = new Collection<Service>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ServiceListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ServicePort contains information on service's port.</summary>

    public partial class ServicePort
    {
        /// <summary>The name of this port within the service. This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. This maps to the 'Name' field in EndpointPort objects. Optional if only one ServicePort is defined on this service.</summary>
        
        public String Name { get; set; }

        /// <summary>The port on each node on which this service is exposed when type=NodePort or LoadBalancer. Usually assigned by the system. If specified, it will be allocated to the service if unused or else creation of the service will fail. Default is to auto-allocate a port if the ServiceType of this Service requires one. More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport</summary>
        
        public int? NodePort { get; set; }

        /// <summary>The port that will be exposed by this service.</summary>
        
        public int Port { get; set; }

        /// <summary>The IP protocol for this port. Supports "TCP", "UDP", and "SCTP". Default is TCP.</summary>
        
        public String Protocol { get; set; }

        /// <summary>Number or name of the port to access on the pods targeted by the service. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a String, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service</summary>
        
        public String TargetPort { get; set; }
    }

    /// <summary>ServiceSpec describes the attributes that a user creates on a service.</summary>

    public partial class ServiceSpec
    {
        /// <summary>clusterIP is the IP address of the service and is usually assigned randomly by the master. If an address is specified manually and is not in use by others, it will be allocated to the service; otherwise, creation of the service will fail. This field can not be changed through updates. Valid values are "None", empty String (""), or a valid IP address. "None" can be specified for headless services when proxying is not required. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
        
        public String ClusterIP { get; set; }

        /// <summary>externalIPs is a list of IP addresses for which nodes in the cluster will also accept traffic for this service.  These IPs are not managed by Kubernetes.  The user is responsible for ensuring that traffic arrives at a node with this IP.  A common example is external load-balancers that are not part of the Kubernetes system.</summary>
        
        public ICollection<String> ExternalIPs { get; set; }

        /// <summary>externalName is the external reference that kubedns or equivalent will return as a CNAME record for this service. No proxying will be involved. Must be a valid RFC-1123 hostname (https://tools.ietf.org/html/rfc1123) and requires Type to be ExternalName.</summary>
        
        public String ExternalName { get; set; }

        /// <summary>externalTrafficPolicy denotes if this Service desires to route external traffic to node-local or cluster-wide endpoints. "Local" preserves the client source IP and avoids a second hop for LoadBalancer and Nodeport type services, but risks potentially imbalanced traffic spreading. "Cluster" obscures the client source IP and may cause a second hop to another node, but should have good overall load-spreading.</summary>
        
        public String ExternalTrafficPolicy { get; set; }

        /// <summary>healthCheckNodePort specifies the healthcheck nodePort for the service. If not specified, HealthCheckNodePort is created by the service api backend with the allocated nodePort. Will use user-specified nodePort value if specified by the client. Only effects when Type is set to LoadBalancer and ExternalTrafficPolicy is set to Local.</summary>
        
        public int? HealthCheckNodePort { get; set; }

        /// <summary>Only applies to Service Type: LoadBalancer LoadBalancer will get created with the IP specified in this field. This feature depends on whether the underlying cloud-provider supports specifying the loadBalancerIP when a load balancer is created. This field will be ignored if the cloud-provider does not support the feature.</summary>
        
        public String LoadBalancerIP { get; set; }

        /// <summary>If specified and supported by the platform, this will restrict traffic through the cloud-provider load-balancer will be restricted to the specified client IPs. This field will be ignored if the cloud-provider does not support the feature." More info: https://kubernetes.io/docs/tasks/access-application-cluster/configure-cloud-provider-firewall/</summary>
        
        public ICollection<String> LoadBalancerSourceRanges { get; set; }

        /// <summary>The list of ports that are exposed by this service. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
        
        public ICollection<ServicePort> Ports { get; set; }

        /// <summary>publishNotReadyAddresses, when set to true, indicates that DNS implementations must publish the notReadyAddresses of subsets for the Endpoints associated with the Service. The default value is false. The primary use case for setting this field is to use a StatefulSet's Headless Service to propagate SRV records for its Pods without respect to their readiness for purpose of peer discovery.</summary>
        
        public Boolean? PublishNotReadyAddresses { get; set; }

        /// <summary>Route service traffic to pods with label keys and values matching this selector. If empty or not present, the service is assumed to have an external process managing its endpoints, which Kubernetes will not modify. Only applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if type is ExternalName. More info: https://kubernetes.io/docs/concepts/services-networking/service/</summary>
        
        public IDictionary<String, String> Selector { get; set; }

        /// <summary>Supports "ClientIP" and "None". Used to maintain session affinity. Enable client IP based session affinity. Must be ClientIP or None. Defaults to None. More info: https://kubernetes.io/docs/concepts/services-networking/service/#virtual-ips-and-service-proxies</summary>
        
        public String SessionAffinity { get; set; }

        /// <summary>sessionAffinityConfig contains the configurations of session affinity.</summary>
        
        public SessionAffinityConfig SessionAffinityConfig { get; set; }

        /// <summary>type determines how the Service is exposed. Defaults to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort, and LoadBalancer. "ExternalName" maps to the specified externalName. "ClusterIP" allocates a cluster-internal IP address for load-balancing to endpoints. Endpoints are determined by the selector or if that is not specified, by manual construction of an Endpoints Object. If clusterIP is "None", no virtual IP is allocated and the endpoints are published as a set of endpoints rather than a stable IP. "NodePort" builds on ClusterIP and allocates a port on every node which routes to the clusterIP. "LoadBalancer" builds on NodePort and creates an external load-balancer (if supported in the current cloud) which routes to the clusterIP. More info: https://kubernetes.io/docs/concepts/services-networking/service/#publishing-services-service-types</summary>
        
        public String Type { get; set; }
    }

    /// <summary>ServiceStatus represents the current status of a service.</summary>

    public partial class ServiceStatus
    {
        /// <summary>LoadBalancer contains the current status of the load-balancer, if one is present.</summary>
        
        public LoadBalancerStatus LoadBalancer { get; set; }
    }

    /// <summary>SessionAffinityConfig represents the configurations of session affinity.</summary>

    public partial class SessionAffinityConfig
    {
        /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
        
        public ClientIPConfig ClientIP { get; set; }
    }

    /// <summary>Represents a StorageOS persistent volume resource.</summary>

    public partial class StorageOSPersistentVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.</summary>
        
        public ObjectReference SecretRef { get; set; }

        /// <summary>VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.</summary>
        
        public String VolumeName { get; set; }

        /// <summary>VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.</summary>
        
        public String VolumeNamespace { get; set; }
    }

    /// <summary>Represents a StorageOS persistent volume resource.</summary>

    public partial class StorageOSVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.</summary>
        
        public LocalObjectReference SecretRef { get; set; }

        /// <summary>VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.</summary>
        
        public String VolumeName { get; set; }

        /// <summary>VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.</summary>
        
        public String VolumeNamespace { get; set; }
    }

    /// <summary>Sysctl defines a kernel parameter to be set</summary>

    public partial class Sysctl
    {
        /// <summary>Name of a property to set</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Value of a property to set</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Value { get; set; }
    }

    /// <summary>TCPSocketAction describes an action based on opening a socket</summary>

    public partial class TCPSocketAction
    {
        /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
        
        public String Host { get; set; }

        /// <summary>Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Port { get; set; }
    }

    /// <summary>The node this Taint is attached to has the "effect" on any pod that does not tolerate the Taint.</summary>

    public partial class Taint
    {
        /// <summary>Required. The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Effect { get; set; }

        /// <summary>Required. The taint key to be applied to a node.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>TimeAdded represents the time at which the taint was added. It is only written for NoExecute taints.</summary>
        
        public DateTimeOffset? TimeAdded { get; set; }

        /// <summary>Required. The taint value corresponding to the taint key.</summary>
        
        public String Value { get; set; }
    }

    /// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>

    public partial class Toleration
    {
        /// <summary>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</summary>
        
        public String Effect { get; set; }

        /// <summary>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</summary>
        
        public String Key { get; set; }

        /// <summary>Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</summary>
        
        public String Operator { get; set; }

        /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</summary>
        
        public long? TolerationSeconds { get; set; }

        /// <summary>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular String.</summary>
        
        public String Value { get; set; }
    }

    /// <summary>A topology selector requirement is a selector that matches given label. This is an alpha feature and may change in the future.</summary>

    public partial class TopologySelectorLabelRequirement
    {
        /// <summary>The label key that the selector applies to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>An array of String values. One value must match the label to be selected. Each entry in Values is ORed.</summary>
        
        [Required]
        public ICollection<String> Values { get; set; } = new Collection<String>();
    }

    /// <summary>A topology selector term represents the result of label queries. A null or empty topology selector term matches no objects. The requirements of them are ANDed. It provides a subset of functionality as NodeSelectorTerm. This is an alpha feature and may change in the future.</summary>

    public partial class TopologySelectorTerm
    {
        /// <summary>A list of topology selector requirements by labels.</summary>
        
        public ICollection<TopologySelectorLabelRequirement> MatchLabelExpressions { get; set; }
    }

    /// <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced Object inside the same namespace.</summary>

    public partial class TypedLocalObjectReference
    {
        /// <summary>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</summary>
        
        public String ApiGroup { get; set; }

        /// <summary>Kind is the type of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name is the name of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>Volume represents a named volume in a pod that may be accessed by any container in the pod.</summary>

    public partial class Volume
    {
        /// <summary>AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</summary>
        
        public AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
        
        public AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
        
        public AzureFileVolumeSource AzureFile { get; set; }

        /// <summary>CephFS represents a Ceph FS mount on the host that shares a pod's lifetime</summary>
        
        public CephFSVolumeSource Cephfs { get; set; }

        /// <summary>Cinder represents a cinder volume attached and mounted on kubelets host machine More info: https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</summary>
        
        public CinderVolumeSource Cinder { get; set; }

        /// <summary>ConfigMap represents a configMap that should populate this volume</summary>
        
        public ConfigMapVolumeSource ConfigMap { get; set; }

        /// <summary>CSI (Container Storage Interface) represents storage that is handled by an external CSI driver (Alpha feature).</summary>
        
        public CSIVolumeSource Csi { get; set; }

        /// <summary>DownwardAPI represents downward API about the pod that should populate this volume</summary>
        
        public DownwardAPIVolumeSource DownwardAPI { get; set; }

        /// <summary>EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir</summary>
        
        public EmptyDirVolumeSource EmptyDir { get; set; }

        /// <summary>FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        
        public FCVolumeSource Fc { get; set; }

        /// <summary>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
        
        public FlexVolumeSource FlexVolume { get; set; }

        /// <summary>Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running</summary>
        
        public FlockerVolumeSource Flocker { get; set; }

        /// <summary>GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</summary>
        
        public GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.</summary>
        
        public GitRepoVolumeSource GitRepo { get; set; }

        /// <summary>Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md</summary>
        
        public GlusterfsVolumeSource Glusterfs { get; set; }

        /// <summary>HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath</summary>
        
        public HostPathVolumeSource HostPath { get; set; }

        /// <summary>ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md</summary>
        
        public ISCSIVolumeSource Iscsi { get; set; }

        /// <summary>Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs</summary>
        
        public NFSVolumeSource Nfs { get; set; }

        /// <summary>PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</summary>
        
        public PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

        /// <summary>PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine</summary>
        
        public PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>PortworxVolume represents a portworx volume attached and mounted on kubelets host machine</summary>
        
        public PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>Items for all in one resources secrets, configmaps, and downward API</summary>
        
        public ProjectedVolumeSource Projected { get; set; }

        /// <summary>Quobyte represents a Quobyte mount on the host that shares a pod's lifetime</summary>
        
        public QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md</summary>
        
        public RBDVolumeSource Rbd { get; set; }

        /// <summary>ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
        
        public ScaleIOVolumeSource ScaleIO { get; set; }

        /// <summary>Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret</summary>
        
        public SecretVolumeSource Secret { get; set; }

        /// <summary>StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.</summary>
        
        public StorageOSVolumeSource Storageos { get; set; }

        /// <summary>VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine</summary>
        
        public VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }
    }

    /// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>

    public partial class VolumeDevice
    {
        /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String DevicePath { get; set; }

        /// <summary>name must match the name of a persistentVolumeClaim in the pod</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>

    public partial class VolumeMount
    {
        /// <summary>Path within the container at which the volume should be mounted.  Must not contain ':'.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String MountPath { get; set; }

        /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.</summary>
        
        public String MountPropagation { get; set; }

        /// <summary>This must match the Name of a Volume.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.</summary>
        
        public Boolean? ReadOnly { get; set; }

        /// <summary>Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).</summary>
        
        public String SubPath { get; set; }

        /// <summary>Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive. This field is alpha in 1.14.</summary>
        
        public String SubPathExpr { get; set; }
    }

    /// <summary>VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary>

    public partial class VolumeNodeAffinity
    {
        /// <summary>Required specifies hard node constraints that must be met.</summary>
        
        public NodeSelector Required { get; set; }
    }

    /// <summary>Projection that may be projected along with other supported volume types</summary>

    public partial class VolumeProjection
    {
        /// <summary>information about the configMap data to project</summary>
        
        public ConfigMapProjection ConfigMap { get; set; }

        /// <summary>information about the downwardAPI data to project</summary>
        
        public DownwardAPIProjection DownwardAPI { get; set; }

        /// <summary>information about the secret data to project</summary>
        
        public SecretProjection Secret { get; set; }

        /// <summary>information about the serviceAccountToken data to project</summary>
        
        public ServiceAccountTokenProjection ServiceAccountToken { get; set; }
    }

    /// <summary>Represents a vSphere volume resource.</summary>

    public partial class VsphereVirtualDiskVolumeSource
    {
        /// <summary>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.</summary>
        
        public String FsType { get; set; }

        /// <summary>Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</summary>
        
        public String StoragePolicyID { get; set; }

        /// <summary>Storage Policy Based Management (SPBM) profile name.</summary>
        
        public String StoragePolicyName { get; set; }

        /// <summary>Path that identifies vSphere volume vmdk</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String VolumePath { get; set; }
    }

    /// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>

    public partial class WeightedPodAffinityTerm
    {
        /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
        
        [Required]
        public PodAffinityTerm PodAffinityTerm { get; set; } = new PodAffinityTerm();

        /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
        
        public int Weight { get; set; }
    }

    /// <summary>Event is a report of an event somewhere in the cluster. It generally denotes some state change in the system.</summary>

    public partial class Event2
    {
        /// <summary>What action was taken/failed regarding to the regarding Object.</summary>
        
        public String Action { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Deprecated field assuring backward compatibility with core.v1 Event type</summary>
        
        public int? DeprecatedCount { get; set; }

        /// <summary>Deprecated field assuring backward compatibility with core.v1 Event type</summary>
        
        public DateTimeOffset? DeprecatedFirstTimestamp { get; set; }

        /// <summary>Deprecated field assuring backward compatibility with core.v1 Event type</summary>
        
        public DateTimeOffset? DeprecatedLastTimestamp { get; set; }

        /// <summary>Deprecated field assuring backward compatibility with core.v1 Event type</summary>
        
        public EventSource DeprecatedSource { get; set; }

        /// <summary>Required. Time when this Event was first observed.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset EventTime { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Event2Kind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Optional. A human-readable description of the status of this operation. Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.</summary>
        
        public String Note { get; set; }

        /// <summary>Why the action was taken.</summary>
        
        public String Reason { get; set; }

        /// <summary>The Object this Event is about. In most cases it's an Object reporting controller implements. E.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet Object.</summary>
        
        public ObjectReference Regarding { get; set; }

        /// <summary>Optional secondary Object for more complex actions. E.g. when regarding Object triggers a creation or deletion of related Object.</summary>
        
        public ObjectReference Related { get; set; }

        /// <summary>Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.</summary>
        
        public String ReportingController { get; set; }

        /// <summary>ID of the controller instance, e.g. `kubelet-xyzf`.</summary>
        
        public String ReportingInstance { get; set; }

        /// <summary>Data about the Event series this event represents or nil if it's a singleton Event.</summary>
        
        public EventSeries2 Series { get; set; }

        /// <summary>Type of this event (Normal, Warning), new types could be added in the future.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>EventList is a list of Event objects.</summary>

    public partial class EventList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<Event2> Items { get; set; } = new Collection<Event2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public EventList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.</summary>

    public partial class EventSeries2
    {
        /// <summary>Number of occurrences in this series up to the last heartbeat time</summary>
        
        public int Count { get; set; }

        /// <summary>Time when last Event from the series was seen before last heartbeat.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public DateTimeOffset LastObservedTime { get; set; }

        /// <summary>Information whether this series is ongoing or finished.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String State { get; set; }
    }

    /// <summary>AllowedCSIDriver represents a single inline CSI Driver that is allowed to be used.</summary>

    public partial class AllowedCSIDriver
    {
        /// <summary>Name is the registered name of the CSI driver</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>AllowedFlexVolume represents a single Flexvolume that is allowed to be used. Deprecated: use AllowedFlexVolume from policy API Group instead.</summary>

    public partial class AllowedFlexVolume
    {
        /// <summary>driver is the name of the Flexvolume driver.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Driver { get; set; }
    }

    /// <summary>AllowedHostPath defines the host volume conditions that will be enabled by a policy for pods to use. It requires the path prefix to be defined. Deprecated: use AllowedHostPath from policy API Group instead.</summary>

    public partial class AllowedHostPath
    {
        /// <summary>pathPrefix is the path prefix that the host volume must match. It does not support `*`. Trailing slashes are trimmed when validating the path prefix with a host path.
        /// <br/>
        /// <br/>Examples: `/foo` would allow `/foo`, `/foo/` and `/foo/bar` `/foo` would not allow `/food` or `/etc/foo`</summary>
        
        public String PathPrefix { get; set; }

        /// <summary>when set to true, will allow host volumes matching the pathPrefix only if all volume mounts are readOnly.</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>DEPRECATED - This group version of DaemonSet is deprecated by apps/v1beta2/DaemonSet. See the release notes for more information. DaemonSet represents the configuration of a daemon set.</summary>

    public partial class DaemonSet3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DaemonSet3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The desired behavior of this daemon set. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public DaemonSetSpec3 Spec { get; set; }

        /// <summary>The current status of this daemon set. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public DaemonSetStatus3 Status { get; set; }
    }

    /// <summary>DaemonSetCondition describes the state of a DaemonSet at a certain point.</summary>

    public partial class DaemonSetCondition3
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of DaemonSet condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DaemonSetList is a collection of daemon sets.</summary>

    public partial class DaemonSetList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>A list of daemon sets.</summary>
        
        [Required]
        public ICollection<DaemonSet3> Items { get; set; } = new Collection<DaemonSet3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DaemonSetList3Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DaemonSetSpec is the specification of a daemon set.</summary>

    public partial class DaemonSetSpec3
    {
        /// <summary>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>A label query over pods that are managed by the daemon set. Must match in order to be controlled. If empty, defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>An Object that describes the pod that will be created. The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

        /// <summary>DEPRECATED. A sequence number representing a specific generation of the template. Populated by the system. It can be set only during the creation.</summary>
        
        public long? TemplateGeneration { get; set; }

        /// <summary>An update strategy to replace existing DaemonSet pods with new pods.</summary>
        
        public DaemonSetUpdateStrategy3 UpdateStrategy { get; set; }
    }

    /// <summary>DaemonSetStatus represents the current status of a daemon set.</summary>

    public partial class DaemonSetStatus3
    {
        /// <summary>Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a DaemonSet's current state.</summary>
        
        public ICollection<DaemonSetCondition3> Conditions { get; set; }

        /// <summary>The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int CurrentNumberScheduled { get; set; }

        /// <summary>The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int DesiredNumberScheduled { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary>
        
        public int? NumberAvailable { get; set; }

        /// <summary>The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/</summary>
        
        public int NumberMisscheduled { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and ready.</summary>
        
        public int NumberReady { get; set; }

        /// <summary>The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)</summary>
        
        public int? NumberUnavailable { get; set; }

        /// <summary>The most recent generation observed by the daemon set controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The total number of nodes that are running updated daemon pod</summary>
        
        public int? UpdatedNumberScheduled { get; set; }
    }


    public partial class DaemonSetUpdateStrategy3
    {
        /// <summary>Rolling update config params. Present only if type = "RollingUpdate".</summary>
        
        public RollingUpdateDaemonSet3 RollingUpdate { get; set; }

        /// <summary>Type of daemon set update. Can be "RollingUpdate" or "OnDelete". Default is OnDelete.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>DEPRECATED - This group version of Deployment is deprecated by apps/v1beta2/Deployment. See the release notes for more information. Deployment enables declarative updates for Pods and ReplicaSets.</summary>

    public partial class Deployment4
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Deployment4Kind? Kind { get; set; }

        /// <summary>Standard Object metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the Deployment.</summary>
        
        public DeploymentSpec4 Spec { get; set; }

        /// <summary>Most recently observed status of the Deployment.</summary>
        
        public DeploymentStatus4 Status { get; set; }
    }

    /// <summary>DeploymentCondition describes the state of a deployment at a certain point.</summary>

    public partial class DeploymentCondition4
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>The last time this condition was updated.</summary>
        
        public DateTimeOffset? LastUpdateTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of deployment condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>DeploymentList is a list of Deployments.</summary>

    public partial class DeploymentList4
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Deployments.</summary>
        
        [Required]
        public ICollection<Deployment4> Items { get; set; } = new Collection<Deployment4>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentList4Kind? Kind { get; set; }

        /// <summary>Standard list metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED. DeploymentRollback stores the information required to rollback a deployment.</summary>

    public partial class DeploymentRollback2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public DeploymentRollback2Kind? Kind { get; set; }

        /// <summary>Required: This must match the Name of a deployment.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>The config of this deployment rollback.</summary>
        
        [Required]
        public RollbackConfig2 RollbackTo { get; set; } = new RollbackConfig2();

        /// <summary>The annotations to be updated to a deployment</summary>
        
        public IDictionary<String, String> UpdatedAnnotations { get; set; }
    }

    /// <summary>DeploymentSpec is the specification of the desired behavior of the Deployment.</summary>

    public partial class DeploymentSpec4
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Indicates that the deployment is paused and will not be processed by the deployment controller.</summary>
        
        public Boolean? Paused { get; set; }

        /// <summary>The maximum time in seconds for a deployment to make progress before it is considered to be failed. The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. This is set to the max value of int32 (i.e. 2147483647) by default, which means "no deadline".</summary>
        
        public int? ProgressDeadlineSeconds { get; set; }

        /// <summary>Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.</summary>
        
        public int? Replicas { get; set; }

        /// <summary>The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. This is set to the max value of int32 (i.e. 2147483647) by default, which means "retaining all old RelicaSets".</summary>
        
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>DEPRECATED. The config this deployment is rolling back to. Will be cleared after rollback is done.</summary>
        
        public RollbackConfig2 RollbackTo { get; set; }

        /// <summary>Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
        
        public DeploymentStrategy4 Strategy { get; set; }

        /// <summary>Template describes the pods that will be created.</summary>
        
        [Required]
        public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();
    }

    /// <summary>DeploymentStatus is the most recently observed status of the Deployment.</summary>

    public partial class DeploymentStatus4
    {
        /// <summary>Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</summary>
        
        public int? CollisionCount { get; set; }

        /// <summary>Represents the latest available observations of a deployment's current state.</summary>
        
        public ICollection<DeploymentCondition4> Conditions { get; set; }

        /// <summary>The generation observed by the deployment controller.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>Total number of ready pods targeted by this deployment.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment (their labels match the selector).</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.</summary>
        
        public int? UnavailableReplicas { get; set; }

        /// <summary>Total number of non-terminated pods targeted by this deployment that have the desired template spec.</summary>
        
        public int? UpdatedReplicas { get; set; }
    }

    /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>

    public partial class DeploymentStrategy4
    {
        /// <summary>Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.</summary>
        
        public RollingUpdateDeployment4 RollingUpdate { get; set; }

        /// <summary>Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.</summary>
        
        public String Type { get; set; }
    }

    /// <summary>FSGroupStrategyOptions defines the strategy type and options used to create the strategy. Deprecated: use FSGroupStrategyOptions from policy API Group instead.</summary>

    public partial class FSGroupStrategyOptions
    {
        /// <summary>ranges are the allowed ranges of fs groups.  If you would like to force a single fs group then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate what FSGroup is used in the SecurityContext.</summary>
        
        public String Rule { get; set; }
    }

    /// <summary>HTTPIngressPath associates a path regex with a backend. Incoming urls matching the path are forwarded to the backend.</summary>

    public partial class HTTPIngressPath
    {
        /// <summary>Backend defines the referenced service endpoint to which the traffic will be forwarded to.</summary>
        
        [Required]
        public IngressBackend Backend { get; set; } = new IngressBackend();

        /// <summary>Path is an extended POSIX regex as defined by IEEE Std 1003.1, (i.e this follows the egrep/unix syntax, not the perl syntax) matched against the path of an incoming request. Currently it can contain characters disallowed from the conventional "path" part of a URL as defined by RFC 3986. Paths must begin with a '/'. If unspecified, the path defaults to a catch all sending traffic to the backend.</summary>
        
        public String Path { get; set; }
    }

    /// <summary>HTTPIngressRuleValue is a list of http selectors pointing to backends. In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt; -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.</summary>

    public partial class HTTPIngressRuleValue
    {
        /// <summary>A collection of paths that map requests to backends.</summary>
        
        [Required]
        public ICollection<HTTPIngressPath> Paths { get; set; } = new Collection<HTTPIngressPath>();
    }

    /// <summary>HostPortRange defines a range of host ports that will be enabled by a policy for pods to use.  It requires both the start and end to be defined. Deprecated: use HostPortRange from policy API Group instead.</summary>

    public partial class HostPortRange
    {
        /// <summary>max is the end of the range, inclusive.</summary>
        
        public int Max { get; set; }

        /// <summary>min is the start of the range, inclusive.</summary>
        
        public int Min { get; set; }
    }

    /// <summary>IDRange provides a min/max of an allowed range of IDs. Deprecated: use IDRange from policy API Group instead.</summary>

    public partial class IDRange
    {
        /// <summary>max is the end of the range, inclusive.</summary>
        
        public long Max { get; set; }

        /// <summary>min is the start of the range, inclusive.</summary>
        
        public long Min { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of IPBlock is deprecated by networking/v1/IPBlock. IPBlock describes a particular CIDR (Ex. "192.168.1.1/24") that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The except entry describes CIDRs that should not be included within this rule.</summary>

    public partial class IPBlock
    {
        /// <summary>CIDR is a String representing the IP Block Valid examples are "192.168.1.1/24"</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Cidr { get; set; }

        /// <summary>Except is a slice of CIDRs that should not be included within an IP Block Valid examples are "192.168.1.1/24" Except values will be rejected if they are outside the CIDR range</summary>
        
        public ICollection<String> Except { get; set; }
    }

    /// <summary>Ingress is a collection of rules that allow inbound connections to reach the endpoints defined by a backend. An Ingress can be configured to give services externally-reachable urls, load balance traffic, terminate SSL, offer name based virtual hosting etc. DEPRECATED - This group version of Ingress is deprecated by networking.k8s.io/v1beta1 Ingress. See the release notes for more information.</summary>

    public partial class Ingress
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public IngressKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec is the desired state of the Ingress. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public IngressSpec Spec { get; set; }

        /// <summary>Status is the current state of the Ingress. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public IngressStatus Status { get; set; }
    }

    /// <summary>IngressBackend describes all endpoints for a given service and port.</summary>

    public partial class IngressBackend
    {
        /// <summary>Specifies the name of the referenced service.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServiceName { get; set; }

        /// <summary>Specifies the port of the referenced service.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServicePort { get; set; }
    }

    /// <summary>IngressList is a collection of Ingress.</summary>

    public partial class IngressList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Ingress.</summary>
        
        [Required]
        public ICollection<Ingress> Items { get; set; } = new Collection<Ingress>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public IngressListKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>IngressRule represents the rules mapping the paths under a specified host to the related backend services. Incoming requests are first evaluated for a host match, then routed to the backend associated with the matching IngressRuleValue.</summary>

    public partial class IngressRule
    {
        /// <summary>Host is the fully qualified domain name of a network host, as defined by RFC 3986. Note the following deviations from the "host" part of the URI as defined in the RFC: 1. IPs are not allowed. Currently an IngressRuleValue can only apply to the
        /// <br/>	  IP in the Spec of the parent Ingress.
        /// <br/>2. The `:` delimiter is not respected because ports are not allowed.
        /// <br/>	  Currently the port of an Ingress is implicitly :80 for http and
        /// <br/>	  :443 for https.
        /// <br/>Both these may change in the future. Incoming requests are matched against the host before the IngressRuleValue. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue.</summary>
        
        public String Host { get; set; }

        
        public HTTPIngressRuleValue Http { get; set; }
    }

    /// <summary>IngressSpec describes the Ingress the user wishes to exist.</summary>

    public partial class IngressSpec
    {
        /// <summary>A default backend capable of servicing requests that don't match any rule. At least one of 'backend' or 'rules' must be specified. This field is optional to allow the loadbalancer controller or defaulting logic to specify a global default.</summary>
        
        public IngressBackend Backend { get; set; }

        /// <summary>A list of host rules used to configure the Ingress. If unspecified, or no rule matches, all traffic is sent to the default backend.</summary>
        
        public ICollection<IngressRule> Rules { get; set; }

        /// <summary>TLS configuration. Currently the Ingress only supports a single TLS port, 443. If multiple members of this list specify different hosts, they will be multiplexed on the same port according to the hostname specified through the SNI TLS extension, if the ingress controller fulfilling the ingress supports SNI.</summary>
        
        public ICollection<IngressTLS> Tls { get; set; }
    }

    /// <summary>IngressStatus describe the current state of the Ingress.</summary>

    public partial class IngressStatus
    {
        /// <summary>LoadBalancer contains the current status of the load-balancer.</summary>
        
        public LoadBalancerStatus LoadBalancer { get; set; }
    }

    /// <summary>IngressTLS describes the transport layer security associated with an Ingress.</summary>

    public partial class IngressTLS
    {
        /// <summary>Hosts are a list of hosts included in the TLS certificate. The values in this list must match the name/s used in the tlsSecret. Defaults to the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.</summary>
        
        public ICollection<String> Hosts { get; set; }

        /// <summary>SecretName is the name of the secret used to terminate SSL traffic on 443. Field is left optional to allow SSL routing based on SNI hostname alone. If the SNI host in a listener conflicts with the "Host" header field used by an IngressRule, the SNI host is used for termination and value of the Host header is used for routing.</summary>
        
        public String SecretName { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicy is deprecated by networking/v1/NetworkPolicy. NetworkPolicy describes what network traffic is allowed for a set of Pods</summary>

    public partial class NetworkPolicy
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NetworkPolicyKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior for this NetworkPolicy.</summary>
        
        public NetworkPolicySpec Spec { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicyEgressRule is deprecated by networking/v1/NetworkPolicyEgressRule. NetworkPolicyEgressRule describes a particular set of traffic that is allowed out of pods matched by a NetworkPolicySpec's podSelector. The traffic must match both ports and to. This type is beta-level in 1.8</summary>

    public partial class NetworkPolicyEgressRule
    {
        /// <summary>List of destination ports for outgoing traffic. Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.</summary>
        
        public ICollection<NetworkPolicyPort> Ports { get; set; }

        /// <summary>List of destinations for outgoing traffic of pods selected for this rule. Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all destinations (traffic not restricted by destination). If this field is present and contains at least one item, this rule allows traffic only if the traffic matches at least one item in the to list.</summary>
        
        public ICollection<NetworkPolicyPeer> To { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicyIngressRule is deprecated by networking/v1/NetworkPolicyIngressRule. This NetworkPolicyIngressRule matches traffic if and only if the traffic matches both ports AND from.</summary>

    public partial class NetworkPolicyIngressRule
    {
        /// <summary>List of sources which should be able to access the pods selected for this rule. Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all sources (traffic not restricted by source). If this field is present and contains at least on item, this rule allows traffic only if the traffic matches at least one item in the from list.</summary>
        
        public ICollection<NetworkPolicyPeer> From { get; set; }

        /// <summary>List of ports which should be made accessible on the pods selected for this rule. Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.</summary>
        
        public ICollection<NetworkPolicyPort> Ports { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicyList is deprecated by networking/v1/NetworkPolicyList. Network Policy List is a list of NetworkPolicy objects.</summary>

    public partial class NetworkPolicyList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<NetworkPolicy> Items { get; set; } = new Collection<NetworkPolicy>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NetworkPolicyListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicyPeer is deprecated by networking/v1/NetworkPolicyPeer.</summary>

    public partial class NetworkPolicyPeer
    {
        /// <summary>IPBlock defines policy on a particular IPBlock. If this field is set then neither of the other fields can be.</summary>
        
        public IPBlock IpBlock { get; set; }

        /// <summary>Selects Namespaces using cluster-scoped labels. This field follows standard label selector semantics; if present but empty, it selects all namespaces.
        /// <br/>
        /// <br/>If PodSelector is also set, then the NetworkPolicyPeer as a whole selects the Pods matching PodSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects all Pods in the Namespaces selected by NamespaceSelector.</summary>
        
        public LabelSelector NamespaceSelector { get; set; }

        /// <summary>This is a label selector which selects Pods. This field follows standard label selector semantics; if present but empty, it selects all pods.
        /// <br/>
        /// <br/>If NamespaceSelector is also set, then the NetworkPolicyPeer as a whole selects the Pods matching PodSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects the Pods matching PodSelector in the policy's own Namespace.</summary>
        
        public LabelSelector PodSelector { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicyPort is deprecated by networking/v1/NetworkPolicyPort.</summary>

    public partial class NetworkPolicyPort
    {
        /// <summary>If specified, the port on the given protocol.  This can either be a numerical or named port on a pod.  If this field is not provided, this matches all port names and numbers. If present, only traffic on the specified protocol AND port will be matched.</summary>
        
        public String Port { get; set; }

        /// <summary>Optional.  The protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.</summary>
        
        public String Protocol { get; set; }
    }

    /// <summary>DEPRECATED 1.9 - This group version of NetworkPolicySpec is deprecated by networking/v1/NetworkPolicySpec.</summary>

    public partial class NetworkPolicySpec
    {
        /// <summary>List of egress rules to be applied to the selected pods. Outgoing traffic is allowed if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic matches at least one egress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy limits all outgoing traffic (and serves solely to ensure that the pods it selects are isolated by default). This field is beta-level in 1.8</summary>
        
        public ICollection<NetworkPolicyEgressRule> Egress { get; set; }

        /// <summary>List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod OR if the traffic source is the pod's local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default).</summary>
        
        public ICollection<NetworkPolicyIngressRule> Ingress { get; set; }

        /// <summary>Selects the pods to which this NetworkPolicy Object applies.  The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods.  In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.</summary>
        
        [Required]
        public LabelSelector PodSelector { get; set; } = new LabelSelector();

        /// <summary>List of rule types that the NetworkPolicy relates to. Valid options are "Ingress", "Egress", or "Ingress,Egress". If this field is not specified, it will default based on the existence of Ingress or Egress rules; policies that contain an Egress section are assumed to affect Egress, and all policies (whether or not they contain an Ingress section) are assumed to affect Ingress. If you want to write an egress-only policy, you must explicitly specify policyTypes [ "Egress" ]. Likewise, if you want to write a policy that specifies that no egress is allowed, you must specify a policyTypes value that include "Egress" (since such a policy would not include an Egress section and would otherwise default to just [ "Ingress" ]). This field is beta-level in 1.8</summary>
        
        public ICollection<String> PolicyTypes { get; set; }
    }

    /// <summary>PodSecurityPolicy governs the ability to make requests that affect the Security Context that will be applied to a pod and container. Deprecated: use PodSecurityPolicy from policy API Group instead.</summary>

    public partial class PodSecurityPolicy
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodSecurityPolicyKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>spec defines the policy enforced.</summary>
        
        public PodSecurityPolicySpec Spec { get; set; }
    }

    /// <summary>PodSecurityPolicyList is a list of PodSecurityPolicy objects. Deprecated: use PodSecurityPolicyList from policy API Group instead.</summary>

    public partial class PodSecurityPolicyList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<PodSecurityPolicy> Items { get; set; } = new Collection<PodSecurityPolicy>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodSecurityPolicyListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodSecurityPolicySpec defines the policy enforced. Deprecated: use PodSecurityPolicySpec from policy API Group instead.</summary>

    public partial class PodSecurityPolicySpec
    {
        /// <summary>allowPrivilegeEscalation determines if a pod can request to allow privilege escalation. If unspecified, defaults to true.</summary>
        
        public Boolean? AllowPrivilegeEscalation { get; set; }

        /// <summary>AllowedCSIDrivers is a whitelist of inline CSI drivers that must be explicitly set to be embedded within a pod spec. An empty value means no CSI drivers can run inline within a pod spec.</summary>
        
        public ICollection<AllowedCSIDriver> AllowedCSIDrivers { get; set; }

        /// <summary>allowedCapabilities is a list of capabilities that can be requested to add to the container. Capabilities in this field may be added at the pod author's discretion. You must not list a capability in both allowedCapabilities and requiredDropCapabilities.</summary>
        
        public ICollection<String> AllowedCapabilities { get; set; }

        /// <summary>allowedFlexVolumes is a whitelist of allowed Flexvolumes.  Empty or nil indicates that all Flexvolumes may be used.  This parameter is effective only when the usage of the Flexvolumes is allowed in the "volumes" field.</summary>
        
        public ICollection<AllowedFlexVolume> AllowedFlexVolumes { get; set; }

        /// <summary>allowedHostPaths is a white list of allowed host paths. Empty indicates that all host paths may be used.</summary>
        
        public ICollection<AllowedHostPath> AllowedHostPaths { get; set; }

        /// <summary>AllowedProcMountTypes is a whitelist of allowed ProcMountTypes. Empty or nil indicates that only the DefaultProcMountType may be used. This requires the ProcMountType feature flag to be enabled.</summary>
        
        public ICollection<String> AllowedProcMountTypes { get; set; }

        /// <summary>allowedUnsafeSysctls is a list of explicitly allowed unsafe sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "*" in which case it is considered as a prefix of allowed sysctls. Single * means all unsafe sysctls are allowed. Kubelet has to whitelist all allowed unsafe sysctls explicitly to avoid rejection.
        /// <br/>
        /// <br/>Examples: e.g. "foo/*" allows "foo/bar", "foo/baz", etc. e.g. "foo.*" allows "foo.bar", "foo.baz", etc.</summary>
        
        public ICollection<String> AllowedUnsafeSysctls { get; set; }

        /// <summary>defaultAddCapabilities is the default set of capabilities that will be added to the container unless the pod spec specifically drops the capability.  You may not list a capability in both defaultAddCapabilities and requiredDropCapabilities. Capabilities added here are implicitly allowed, and need not be included in the allowedCapabilities list.</summary>
        
        public ICollection<String> DefaultAddCapabilities { get; set; }

        /// <summary>defaultAllowPrivilegeEscalation controls the default setting for whether a process can gain more privileges than its parent process.</summary>
        
        public Boolean? DefaultAllowPrivilegeEscalation { get; set; }

        /// <summary>forbiddenSysctls is a list of explicitly forbidden sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "*" in which case it is considered as a prefix of forbidden sysctls. Single * means all sysctls are forbidden.
        /// <br/>
        /// <br/>Examples: e.g. "foo/*" forbids "foo/bar", "foo/baz", etc. e.g. "foo.*" forbids "foo.bar", "foo.baz", etc.</summary>
        
        public ICollection<String> ForbiddenSysctls { get; set; }

        /// <summary>fsGroup is the strategy that will dictate what fs group is used by the SecurityContext.</summary>
        
        [Required]
        public FSGroupStrategyOptions FsGroup { get; set; } = new FSGroupStrategyOptions();

        /// <summary>hostIPC determines if the policy allows the use of HostIPC in the pod spec.</summary>
        
        public Boolean? HostIPC { get; set; }

        /// <summary>hostNetwork determines if the policy allows the use of HostNetwork in the pod spec.</summary>
        
        public Boolean? HostNetwork { get; set; }

        /// <summary>hostPID determines if the policy allows the use of HostPID in the pod spec.</summary>
        
        public Boolean? HostPID { get; set; }

        /// <summary>hostPorts determines which host port ranges are allowed to be exposed.</summary>
        
        public ICollection<HostPortRange> HostPorts { get; set; }

        /// <summary>privileged determines if a pod can request to be run as privileged.</summary>
        
        public Boolean? Privileged { get; set; }

        /// <summary>readOnlyRootFilesystem when set to true will force containers to run with a read only root file system.  If the container specifically requests to run with a non-read only root file system the PSP should deny the pod. If set to false the container may run with a read only root file system if it wishes but it will not be forced to.</summary>
        
        public Boolean? ReadOnlyRootFilesystem { get; set; }

        /// <summary>requiredDropCapabilities are the capabilities that will be dropped from the container.  These are required to be dropped and cannot be added.</summary>
        
        public ICollection<String> RequiredDropCapabilities { get; set; }

        /// <summary>RunAsGroup is the strategy that will dictate the allowable RunAsGroup values that may be set. If this field is omitted, the pod's RunAsGroup can take any value. This field requires the RunAsGroup feature gate to be enabled.</summary>
        
        public RunAsGroupStrategyOptions RunAsGroup { get; set; }

        /// <summary>runAsUser is the strategy that will dictate the allowable RunAsUser values that may be set.</summary>
        
        [Required]
        public RunAsUserStrategyOptions RunAsUser { get; set; } = new RunAsUserStrategyOptions();

        /// <summary>seLinux is the strategy that will dictate the allowable labels that may be set.</summary>
        
        [Required]
        public SELinuxStrategyOptions SeLinux { get; set; } = new SELinuxStrategyOptions();

        /// <summary>supplementalGroups is the strategy that will dictate what supplemental groups are used by the SecurityContext.</summary>
        
        [Required]
        public SupplementalGroupsStrategyOptions SupplementalGroups { get; set; } = new SupplementalGroupsStrategyOptions();

        /// <summary>volumes is a white list of allowed volume plugins. Empty indicates that no volumes may be used. To allow all volumes you may use '*'.</summary>
        
        public ICollection<String> Volumes { get; set; }
    }

    /// <summary>DEPRECATED - This group version of ReplicaSet is deprecated by apps/v1beta2/ReplicaSet. See the release notes for more information. ReplicaSet ensures that a specified number of pod replicas are running at any given time.</summary>

    public partial class ReplicaSet3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicaSet3Kind? Kind { get; set; }

        /// <summary>If the Labels of a ReplicaSet are empty, they are defaulted to be the same as the Pod(s) that the ReplicaSet manages. Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec defines the specification of the desired behavior of the ReplicaSet. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public ReplicaSetSpec3 Spec { get; set; }

        /// <summary>Status is the most recently observed status of the ReplicaSet. This data may be out of date by some window of time. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
        
        public ReplicaSetStatus3 Status { get; set; }
    }

    /// <summary>ReplicaSetCondition describes the state of a replica set at a certain point.</summary>

    public partial class ReplicaSetCondition3
    {
        /// <summary>The last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>A human readable message indicating details about the transition.</summary>
        
        public String Message { get; set; }

        /// <summary>The reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status of the condition, one of True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type of replica set condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>ReplicaSetList is a collection of ReplicaSets.</summary>

    public partial class ReplicaSetList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>List of ReplicaSets. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller</summary>
        
        [Required]
        public ICollection<ReplicaSet3> Items { get; set; } = new Collection<ReplicaSet3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ReplicaSetList3Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ReplicaSetSpec is the specification of a ReplicaSet.</summary>

    public partial class ReplicaSetSpec3
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</summary>
        
        public int? MinReadySeconds { get; set; }

        /// <summary>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary>
        
        public int? Replicas { get; set; }

        /// <summary>Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>Template is the Object that describes the pod that will be created if insufficient replicas are detected. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</summary>
        
        public PodTemplateSpec Template { get; set; }
    }

    /// <summary>ReplicaSetStatus represents the current status of a ReplicaSet.</summary>

    public partial class ReplicaSetStatus3
    {
        /// <summary>The number of available replicas (ready for at least minReadySeconds) for this replica set.</summary>
        
        public int? AvailableReplicas { get; set; }

        /// <summary>Represents the latest available observations of a replica set's current state.</summary>
        
        public ICollection<ReplicaSetCondition3> Conditions { get; set; }

        /// <summary>The number of pods that have labels matching the labels of the pod template of the replicaset.</summary>
        
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>ObservedGeneration reflects the generation of the most recently observed ReplicaSet.</summary>
        
        public long? ObservedGeneration { get; set; }

        /// <summary>The number of ready replicas for this replica set.</summary>
        
        public int? ReadyReplicas { get; set; }

        /// <summary>Replicas is the most recently oberved number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</summary>
        
        public int Replicas { get; set; }
    }

    /// <summary>DEPRECATED.</summary>

    public partial class RollbackConfig2
    {
        /// <summary>The revision to rollback to. If set to 0, rollback to the last revision.</summary>
        
        public long? Revision { get; set; }
    }

    /// <summary>Spec to control the desired behavior of daemon set rolling update.</summary>

    public partial class RollingUpdateDaemonSet3
    {
        /// <summary>The maximum number of DaemonSet pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of total number of DaemonSet pods at the start of the update (ex: 10%). Absolute number is calculated from percentage by rounding up. This cannot be 0. Default value is 1. Example: when this is set to 30%, at most 30% of the total number of nodes that should be running the daemon pod (i.e. status.desiredNumberScheduled) can have their pods stopped for an update at any given time. The update starts by stopping at most 30% of those DaemonSet pods and then brings up new DaemonSet pods in their place. Once the new pods are available, it then proceeds onto other DaemonSet pods, thus ensuring that at least 70% of original number of DaemonSet pods are available at all times during the update.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>Spec to control the desired behavior of rolling update.</summary>

    public partial class RollingUpdateDeployment4
    {
        /// <summary>The maximum number of pods that can be scheduled above the desired number of pods. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). This can not be 0 if MaxUnavailable is 0. Absolute number is calculated from percentage by rounding up. By default, a value of 1 is used. Example: when this is set to 30%, the new RC can be scaled up immediately when the rolling update starts, such that the total number of old and new pods do not exceed 130% of desired pods. Once old pods have been killed, new RC can be scaled up further, ensuring that total number of pods running at any time during the update is at most 130% of desired pods.</summary>
        
        public String MaxSurge { get; set; }

        /// <summary>The maximum number of pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding down. This can not be 0 if MaxSurge is 0. By default, a fixed value of 1 is used. Example: when this is set to 30%, the old RC can be scaled down to 70% of desired pods immediately when the rolling update starts. Once new pods are ready, old RC can be scaled down further, followed by scaling up the new RC, ensuring that the total number of pods available at all times during the update is at least 70% of desired pods.</summary>
        
        public String MaxUnavailable { get; set; }
    }

    /// <summary>RunAsGroupStrategyOptions defines the strategy type and any options used to create the strategy. Deprecated: use RunAsGroupStrategyOptions from policy API Group instead.</summary>

    public partial class RunAsGroupStrategyOptions
    {
        /// <summary>ranges are the allowed ranges of gids that may be used. If you would like to force a single gid then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate the allowable RunAsGroup values that may be set.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Rule { get; set; }
    }

    /// <summary>RunAsUserStrategyOptions defines the strategy type and any options used to create the strategy. Deprecated: use RunAsUserStrategyOptions from policy API Group instead.</summary>

    public partial class RunAsUserStrategyOptions
    {
        /// <summary>ranges are the allowed ranges of uids that may be used. If you would like to force a single uid then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate the allowable RunAsUser values that may be set.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Rule { get; set; }
    }

    /// <summary>SELinuxStrategyOptions defines the strategy type and any options used to create the strategy. Deprecated: use SELinuxStrategyOptions from policy API Group instead.</summary>

    public partial class SELinuxStrategyOptions
    {
        /// <summary>rule is the strategy that will dictate the allowable labels that may be set.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Rule { get; set; }

        /// <summary>seLinuxOptions required to run as; required for MustRunAs More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
        
        public SELinuxOptions SeLinuxOptions { get; set; }
    }

    /// <summary>represents a scaling request for a resource.</summary>

    public partial class Scale4
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Scale4Kind? Kind { get; set; }

        /// <summary>Standard Object metadata; More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>defines the behavior of the scale. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.</summary>
        
        public ScaleSpec4 Spec { get; set; }

        /// <summary>current status of the scale. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status. Read-only.</summary>
        
        public ScaleStatus4 Status { get; set; }
    }

    /// <summary>describes the attributes of a scale subresource</summary>

    public partial class ScaleSpec4
    {
        /// <summary>desired number of instances for the scaled Object.</summary>
        
        public int? Replicas { get; set; }
    }

    /// <summary>represents the current status of a scale subresource.</summary>

    public partial class ScaleStatus4
    {
        /// <summary>actual number of observed instances of the scaled Object.</summary>
        
        public int Replicas { get; set; }

        /// <summary>label query over pods that should match the replicas count. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors</summary>
        
        public IDictionary<String, String> Selector { get; set; }

        /// <summary>label selector for pods that should match the replicas count. This is a serializated version of both map-based and more expressive set-based selectors. This is done to avoid introspection in the clients. The String will be in the same format as the query-param syntax. If the target type only supports map-based selectors, both this field and map-based selector field are populated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</summary>
        
        public String TargetSelector { get; set; }
    }

    /// <summary>SupplementalGroupsStrategyOptions defines the strategy type and options used to create the strategy. Deprecated: use SupplementalGroupsStrategyOptions from policy API Group instead.</summary>

    public partial class SupplementalGroupsStrategyOptions
    {
        /// <summary>ranges are the allowed ranges of supplemental groups.  If you would like to force a single supplemental group then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate what supplemental groups is used in the SecurityContext.</summary>
        
        public String Rule { get; set; }
    }

    /// <summary>IPBlock describes a particular CIDR (Ex. "192.168.1.1/24") that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The except entry describes CIDRs that should not be included within this rule.</summary>

    public partial class IPBlock2
    {
        /// <summary>CIDR is a String representing the IP Block Valid examples are "192.168.1.1/24"</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Cidr { get; set; }

        /// <summary>Except is a slice of CIDRs that should not be included within an IP Block Valid examples are "192.168.1.1/24" Except values will be rejected if they are outside the CIDR range</summary>
        
        public ICollection<String> Except { get; set; }
    }

    /// <summary>NetworkPolicy describes what network traffic is allowed for a set of Pods</summary>

    public partial class NetworkPolicy2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NetworkPolicy2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior for this NetworkPolicy.</summary>
        
        public NetworkPolicySpec2 Spec { get; set; }
    }

    /// <summary>NetworkPolicyEgressRule describes a particular set of traffic that is allowed out of pods matched by a NetworkPolicySpec's podSelector. The traffic must match both ports and to. This type is beta-level in 1.8</summary>

    public partial class NetworkPolicyEgressRule2
    {
        /// <summary>List of destination ports for outgoing traffic. Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.</summary>
        
        public ICollection<NetworkPolicyPort2> Ports { get; set; }

        /// <summary>List of destinations for outgoing traffic of pods selected for this rule. Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all destinations (traffic not restricted by destination). If this field is present and contains at least one item, this rule allows traffic only if the traffic matches at least one item in the to list.</summary>
        
        public ICollection<NetworkPolicyPeer2> To { get; set; }
    }

    /// <summary>NetworkPolicyIngressRule describes a particular set of traffic that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The traffic must match both ports and from.</summary>

    public partial class NetworkPolicyIngressRule2
    {
        /// <summary>List of sources which should be able to access the pods selected for this rule. Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all sources (traffic not restricted by source). If this field is present and contains at least on item, this rule allows traffic only if the traffic matches at least one item in the from list.</summary>
        
        public ICollection<NetworkPolicyPeer2> From { get; set; }

        /// <summary>List of ports which should be made accessible on the pods selected for this rule. Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.</summary>
        
        public ICollection<NetworkPolicyPort2> Ports { get; set; }
    }

    /// <summary>NetworkPolicyList is a list of NetworkPolicy objects.</summary>

    public partial class NetworkPolicyList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<NetworkPolicy2> Items { get; set; } = new Collection<NetworkPolicy2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public NetworkPolicyList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>NetworkPolicyPeer describes a peer to allow traffic from. Only certain combinations of fields are allowed</summary>

    public partial class NetworkPolicyPeer2
    {
        /// <summary>IPBlock defines policy on a particular IPBlock. If this field is set then neither of the other fields can be.</summary>
        
        public IPBlock2 IpBlock { get; set; }

        /// <summary>Selects Namespaces using cluster-scoped labels. This field follows standard label selector semantics; if present but empty, it selects all namespaces.
        /// <br/>
        /// <br/>If PodSelector is also set, then the NetworkPolicyPeer as a whole selects the Pods matching PodSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects all Pods in the Namespaces selected by NamespaceSelector.</summary>
        
        public LabelSelector NamespaceSelector { get; set; }

        /// <summary>This is a label selector which selects Pods. This field follows standard label selector semantics; if present but empty, it selects all pods.
        /// <br/>
        /// <br/>If NamespaceSelector is also set, then the NetworkPolicyPeer as a whole selects the Pods matching PodSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects the Pods matching PodSelector in the policy's own Namespace.</summary>
        
        public LabelSelector PodSelector { get; set; }
    }

    /// <summary>NetworkPolicyPort describes a port to allow traffic on</summary>

    public partial class NetworkPolicyPort2
    {
        /// <summary>The port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers.</summary>
        
        public String Port { get; set; }

        /// <summary>The protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.</summary>
        
        public String Protocol { get; set; }
    }

    /// <summary>NetworkPolicySpec provides the specification of a NetworkPolicy</summary>

    public partial class NetworkPolicySpec2
    {
        /// <summary>List of egress rules to be applied to the selected pods. Outgoing traffic is allowed if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic matches at least one egress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy limits all outgoing traffic (and serves solely to ensure that the pods it selects are isolated by default). This field is beta-level in 1.8</summary>
        
        public ICollection<NetworkPolicyEgressRule2> Egress { get; set; }

        /// <summary>List of ingress rules to be applied to the selected pods. Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod's local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)</summary>
        
        public ICollection<NetworkPolicyIngressRule2> Ingress { get; set; }

        /// <summary>Selects the pods to which this NetworkPolicy Object applies. The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.</summary>
        
        [Required]
        public LabelSelector PodSelector { get; set; } = new LabelSelector();

        /// <summary>List of rule types that the NetworkPolicy relates to. Valid options are "Ingress", "Egress", or "Ingress,Egress". If this field is not specified, it will default based on the existence of Ingress or Egress rules; policies that contain an Egress section are assumed to affect Egress, and all policies (whether or not they contain an Ingress section) are assumed to affect Ingress. If you want to write an egress-only policy, you must explicitly specify policyTypes [ "Egress" ]. Likewise, if you want to write a policy that specifies that no egress is allowed, you must specify a policyTypes value that include "Egress" (since such a policy would not include an Egress section and would otherwise default to just [ "Ingress" ]). This field is beta-level in 1.8</summary>
        
        public ICollection<String> PolicyTypes { get; set; }
    }

    /// <summary>HTTPIngressPath associates a path regex with a backend. Incoming urls matching the path are forwarded to the backend.</summary>

    public partial class HTTPIngressPath2
    {
        /// <summary>Backend defines the referenced service endpoint to which the traffic will be forwarded to.</summary>
        
        [Required]
        public IngressBackend2 Backend { get; set; } = new IngressBackend2();

        /// <summary>Path is an extended POSIX regex as defined by IEEE Std 1003.1, (i.e this follows the egrep/unix syntax, not the perl syntax) matched against the path of an incoming request. Currently it can contain characters disallowed from the conventional "path" part of a URL as defined by RFC 3986. Paths must begin with a '/'. If unspecified, the path defaults to a catch all sending traffic to the backend.</summary>
        
        public String Path { get; set; }
    }

    /// <summary>HTTPIngressRuleValue is a list of http selectors pointing to backends. In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt; -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.</summary>

    public partial class HTTPIngressRuleValue2
    {
        /// <summary>A collection of paths that map requests to backends.</summary>
        
        [Required]
        public ICollection<HTTPIngressPath2> Paths { get; set; } = new Collection<HTTPIngressPath2>();
    }

    /// <summary>Ingress is a collection of rules that allow inbound connections to reach the endpoints defined by a backend. An Ingress can be configured to give services externally-reachable urls, load balance traffic, terminate SSL, offer name based virtual hosting etc.</summary>

    public partial class Ingress2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Ingress2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec is the desired state of the Ingress. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public IngressSpec2 Spec { get; set; }

        /// <summary>Status is the current state of the Ingress. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        public IngressStatus2 Status { get; set; }
    }

    /// <summary>IngressBackend describes all endpoints for a given service and port.</summary>

    public partial class IngressBackend2
    {
        /// <summary>Specifies the name of the referenced service.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServiceName { get; set; }

        /// <summary>Specifies the port of the referenced service.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ServicePort { get; set; }
    }

    /// <summary>IngressList is a collection of Ingress.</summary>

    public partial class IngressList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of Ingress.</summary>
        
        [Required]
        public ICollection<Ingress2> Items { get; set; } = new Collection<Ingress2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public IngressList2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>IngressRule represents the rules mapping the paths under a specified host to the related backend services. Incoming requests are first evaluated for a host match, then routed to the backend associated with the matching IngressRuleValue.</summary>

    public partial class IngressRule2
    {
        /// <summary>Host is the fully qualified domain name of a network host, as defined by RFC 3986. Note the following deviations from the "host" part of the URI as defined in the RFC: 1. IPs are not allowed. Currently an IngressRuleValue can only apply to the
        /// <br/>	  IP in the Spec of the parent Ingress.
        /// <br/>2. The `:` delimiter is not respected because ports are not allowed.
        /// <br/>	  Currently the port of an Ingress is implicitly :80 for http and
        /// <br/>	  :443 for https.
        /// <br/>Both these may change in the future. Incoming requests are matched against the host before the IngressRuleValue. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue.</summary>
        
        public String Host { get; set; }

        
        public HTTPIngressRuleValue2 Http { get; set; }
    }

    /// <summary>IngressSpec describes the Ingress the user wishes to exist.</summary>

    public partial class IngressSpec2
    {
        /// <summary>A default backend capable of servicing requests that don't match any rule. At least one of 'backend' or 'rules' must be specified. This field is optional to allow the loadbalancer controller or defaulting logic to specify a global default.</summary>
        
        public IngressBackend2 Backend { get; set; }

        /// <summary>A list of host rules used to configure the Ingress. If unspecified, or no rule matches, all traffic is sent to the default backend.</summary>
        
        public ICollection<IngressRule2> Rules { get; set; }

        /// <summary>TLS configuration. Currently the Ingress only supports a single TLS port, 443. If multiple members of this list specify different hosts, they will be multiplexed on the same port according to the hostname specified through the SNI TLS extension, if the ingress controller fulfilling the ingress supports SNI.</summary>
        
        public ICollection<IngressTLS2> Tls { get; set; }
    }

    /// <summary>IngressStatus describe the current state of the Ingress.</summary>

    public partial class IngressStatus2
    {
        /// <summary>LoadBalancer contains the current status of the load-balancer.</summary>
        
        public LoadBalancerStatus LoadBalancer { get; set; }
    }

    /// <summary>IngressTLS describes the transport layer security associated with an Ingress.</summary>

    public partial class IngressTLS2
    {
        /// <summary>Hosts are a list of hosts included in the TLS certificate. The values in this list must match the name/s used in the tlsSecret. Defaults to the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.</summary>
        
        public ICollection<String> Hosts { get; set; }

        /// <summary>SecretName is the name of the secret used to terminate SSL traffic on 443. Field is left optional to allow SSL routing based on SNI hostname alone. If the SNI host in a listener conflicts with the "Host" header field used by an IngressRule, the SNI host is used for termination and value of the Host header is used for routing.</summary>
        
        public String SecretName { get; set; }
    }

    /// <summary>RuntimeClass defines a class of container runtime supported in the cluster. The RuntimeClass is used to determine which container runtime is used to run all containers in a pod. RuntimeClasses are (currently) manually defined by a user or cluster provisioner, and referenced in the PodSpec. The Kubelet is responsible for resolving the RuntimeClassName reference before running the pod.  For more details, see https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md</summary>

    public partial class RuntimeClass
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RuntimeClassKind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the RuntimeClass More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>
        
        [Required]
        public RuntimeClassSpec Spec { get; set; } = new RuntimeClassSpec();
    }

    /// <summary>RuntimeClassList is a list of RuntimeClass objects.</summary>

    public partial class RuntimeClassList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<RuntimeClass> Items { get; set; } = new Collection<RuntimeClass>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RuntimeClassListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RuntimeClassSpec is a specification of a RuntimeClass. It contains parameters that are required to describe the RuntimeClass to the Container Runtime Interface (CRI) implementation, as well as any other components that need to understand how the pod will be run. The RuntimeClassSpec is immutable.</summary>

    public partial class RuntimeClassSpec
    {
        /// <summary>RuntimeHandler specifies the underlying runtime and configuration that the CRI implementation will use to handle pods of this class. The possible values are specific to the node &amp; CRI configuration.  It is assumed that all handlers are available on every node, and handlers of the same name are equivalent on every node. For example, a handler called "runc" might specify that the runc OCI runtime (using native Linux containers) will be used to run the containers in a pod. The RuntimeHandler must conform to the DNS Label (RFC 1123) requirements and is immutable.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String RuntimeHandler { get; set; }
    }

    /// <summary>RuntimeClass defines a class of container runtime supported in the cluster. The RuntimeClass is used to determine which container runtime is used to run all containers in a pod. RuntimeClasses are (currently) manually defined by a user or cluster provisioner, and referenced in the PodSpec. The Kubelet is responsible for resolving the RuntimeClassName reference before running the pod.  For more details, see https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md</summary>

    public partial class RuntimeClass2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Handler specifies the underlying runtime and configuration that the CRI implementation will use to handle pods of this class. The possible values are specific to the node &amp; CRI configuration.  It is assumed that all handlers are available on every node, and handlers of the same name are equivalent on every node. For example, a handler called "runc" might specify that the runc OCI runtime (using native Linux containers) will be used to run the containers in a pod. The Handler must conform to the DNS Label (RFC 1123) requirements, and is immutable.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Handler { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RuntimeClass2Kind? Kind { get; set; }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }
    }

    /// <summary>RuntimeClassList is a list of RuntimeClass objects.</summary>

    public partial class RuntimeClassList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<RuntimeClass2> Items { get; set; } = new Collection<RuntimeClass2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RuntimeClassList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>AllowedCSIDriver represents a single inline CSI Driver that is allowed to be used.</summary>

    public partial class AllowedCSIDriver2
    {
        /// <summary>Name is the registered name of the CSI driver</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>AllowedFlexVolume represents a single Flexvolume that is allowed to be used.</summary>

    public partial class AllowedFlexVolume2
    {
        /// <summary>driver is the name of the Flexvolume driver.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Driver { get; set; }
    }

    /// <summary>AllowedHostPath defines the host volume conditions that will be enabled by a policy for pods to use. It requires the path prefix to be defined.</summary>

    public partial class AllowedHostPath2
    {
        /// <summary>pathPrefix is the path prefix that the host volume must match. It does not support `*`. Trailing slashes are trimmed when validating the path prefix with a host path.
        /// <br/>
        /// <br/>Examples: `/foo` would allow `/foo`, `/foo/` and `/foo/bar` `/foo` would not allow `/food` or `/etc/foo`</summary>
        
        public String PathPrefix { get; set; }

        /// <summary>when set to true, will allow host volumes matching the pathPrefix only if all volume mounts are readOnly.</summary>
        
        public Boolean? ReadOnly { get; set; }
    }

    /// <summary>Eviction evicts a pod from its node subject to certain policies and safety constraints. This is a subresource of Pod.  A request to cause such an eviction is created by POSTing to .../pods/&lt;pod name&gt;/evictions.</summary>

    public partial class Eviction
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>DeleteOptions may be provided</summary>
        
        public DeleteOptions DeleteOptions { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public EvictionKind? Kind { get; set; }

        /// <summary>ObjectMeta describes the pod that is being evicted.</summary>
        
        public ObjectMeta Metadata { get; set; }
    }

    /// <summary>FSGroupStrategyOptions defines the strategy type and options used to create the strategy.</summary>

    public partial class FSGroupStrategyOptions2
    {
        /// <summary>ranges are the allowed ranges of fs groups.  If you would like to force a single fs group then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange2> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate what FSGroup is used in the SecurityContext.</summary>
        
        public String Rule { get; set; }
    }

    /// <summary>HostPortRange defines a range of host ports that will be enabled by a policy for pods to use.  It requires both the start and end to be defined.</summary>

    public partial class HostPortRange2
    {
        /// <summary>max is the end of the range, inclusive.</summary>
        
        public int Max { get; set; }

        /// <summary>min is the start of the range, inclusive.</summary>
        
        public int Min { get; set; }
    }

    /// <summary>IDRange provides a min/max of an allowed range of IDs.</summary>

    public partial class IDRange2
    {
        /// <summary>max is the end of the range, inclusive.</summary>
        
        public long Max { get; set; }

        /// <summary>min is the start of the range, inclusive.</summary>
        
        public long Min { get; set; }
    }

    /// <summary>PodDisruptionBudget is an Object to define the max disruption that can be caused to a collection of pods</summary>

    public partial class PodDisruptionBudget
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodDisruptionBudgetKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the PodDisruptionBudget.</summary>
        
        public PodDisruptionBudgetSpec Spec { get; set; }

        /// <summary>Most recently observed status of the PodDisruptionBudget.</summary>
        
        public PodDisruptionBudgetStatus Status { get; set; }
    }

    /// <summary>PodDisruptionBudgetList is a collection of PodDisruptionBudgets.</summary>

    public partial class PodDisruptionBudgetList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        
        [Required]
        public ICollection<PodDisruptionBudget> Items { get; set; } = new Collection<PodDisruptionBudget>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodDisruptionBudgetListKind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.</summary>

    public partial class PodDisruptionBudgetSpec
    {
        /// <summary>An eviction is allowed if at most "maxUnavailable" pods selected by "selector" are unavailable after the eviction, i.e. even in absence of the evicted pod. For example, one can prevent all voluntary evictions by specifying 0. This is a mutually exclusive setting with "minAvailable".</summary>
        
        public String MaxUnavailable { get; set; }

        /// <summary>An eviction is allowed if at least "minAvailable" pods selected by "selector" will still be available after the eviction, i.e. even in the absence of the evicted pod.  So for example you can prevent all voluntary evictions by specifying "100%".</summary>
        
        public String MinAvailable { get; set; }

        /// <summary>Label query over pods whose evictions are managed by the disruption budget.</summary>
        
        public LabelSelector Selector { get; set; }
    }

    /// <summary>PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.</summary>

    public partial class PodDisruptionBudgetStatus
    {
        /// <summary>current number of healthy pods</summary>
        
        public int CurrentHealthy { get; set; }

        /// <summary>minimum desired number of healthy pods</summary>
        
        public int DesiredHealthy { get; set; }

        /// <summary>DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.</summary>
        
        public IDictionary<String, DateTimeOffset> DisruptedPods { get; set; }

        /// <summary>Number of pod disruptions that are currently allowed.</summary>
        
        public int DisruptionsAllowed { get; set; }

        /// <summary>total number of pods counted by this disruption budget</summary>
        
        public int ExpectedPods { get; set; }

        /// <summary>Most recent generation observed when updating this PDB status. PodDisruptionsAllowed and other status informatio is valid only if observedGeneration equals to PDB's Object generation.</summary>
        
        public long? ObservedGeneration { get; set; }
    }

    /// <summary>PodSecurityPolicy governs the ability to make requests that affect the Security Context that will be applied to a pod and container.</summary>

    public partial class PodSecurityPolicy2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodSecurityPolicy2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>spec defines the policy enforced.</summary>
        
        public PodSecurityPolicySpec2 Spec { get; set; }
    }

    /// <summary>PodSecurityPolicyList is a list of PodSecurityPolicy objects.</summary>

    public partial class PodSecurityPolicyList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<PodSecurityPolicy2> Items { get; set; } = new Collection<PodSecurityPolicy2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodSecurityPolicyList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodSecurityPolicySpec defines the policy enforced.</summary>

    public partial class PodSecurityPolicySpec2
    {
        /// <summary>allowPrivilegeEscalation determines if a pod can request to allow privilege escalation. If unspecified, defaults to true.</summary>
        
        public Boolean? AllowPrivilegeEscalation { get; set; }

        /// <summary>AllowedCSIDrivers is a whitelist of inline CSI drivers that must be explicitly set to be embedded within a pod spec. An empty value means no CSI drivers can run inline within a pod spec.</summary>
        
        public ICollection<AllowedCSIDriver2> AllowedCSIDrivers { get; set; }

        /// <summary>allowedCapabilities is a list of capabilities that can be requested to add to the container. Capabilities in this field may be added at the pod author's discretion. You must not list a capability in both allowedCapabilities and requiredDropCapabilities.</summary>
        
        public ICollection<String> AllowedCapabilities { get; set; }

        /// <summary>allowedFlexVolumes is a whitelist of allowed Flexvolumes.  Empty or nil indicates that all Flexvolumes may be used.  This parameter is effective only when the usage of the Flexvolumes is allowed in the "volumes" field.</summary>
        
        public ICollection<AllowedFlexVolume2> AllowedFlexVolumes { get; set; }

        /// <summary>allowedHostPaths is a white list of allowed host paths. Empty indicates that all host paths may be used.</summary>
        
        public ICollection<AllowedHostPath2> AllowedHostPaths { get; set; }

        /// <summary>AllowedProcMountTypes is a whitelist of allowed ProcMountTypes. Empty or nil indicates that only the DefaultProcMountType may be used. This requires the ProcMountType feature flag to be enabled.</summary>
        
        public ICollection<String> AllowedProcMountTypes { get; set; }

        /// <summary>allowedUnsafeSysctls is a list of explicitly allowed unsafe sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "*" in which case it is considered as a prefix of allowed sysctls. Single * means all unsafe sysctls are allowed. Kubelet has to whitelist all allowed unsafe sysctls explicitly to avoid rejection.
        /// <br/>
        /// <br/>Examples: e.g. "foo/*" allows "foo/bar", "foo/baz", etc. e.g. "foo.*" allows "foo.bar", "foo.baz", etc.</summary>
        
        public ICollection<String> AllowedUnsafeSysctls { get; set; }

        /// <summary>defaultAddCapabilities is the default set of capabilities that will be added to the container unless the pod spec specifically drops the capability.  You may not list a capability in both defaultAddCapabilities and requiredDropCapabilities. Capabilities added here are implicitly allowed, and need not be included in the allowedCapabilities list.</summary>
        
        public ICollection<String> DefaultAddCapabilities { get; set; }

        /// <summary>defaultAllowPrivilegeEscalation controls the default setting for whether a process can gain more privileges than its parent process.</summary>
        
        public Boolean? DefaultAllowPrivilegeEscalation { get; set; }

        /// <summary>forbiddenSysctls is a list of explicitly forbidden sysctls, defaults to none. Each entry is either a plain sysctl name or ends in "*" in which case it is considered as a prefix of forbidden sysctls. Single * means all sysctls are forbidden.
        /// <br/>
        /// <br/>Examples: e.g. "foo/*" forbids "foo/bar", "foo/baz", etc. e.g. "foo.*" forbids "foo.bar", "foo.baz", etc.</summary>
        
        public ICollection<String> ForbiddenSysctls { get; set; }

        /// <summary>fsGroup is the strategy that will dictate what fs group is used by the SecurityContext.</summary>
        
        [Required]
        public FSGroupStrategyOptions2 FsGroup { get; set; } = new FSGroupStrategyOptions2();

        /// <summary>hostIPC determines if the policy allows the use of HostIPC in the pod spec.</summary>
        
        public Boolean? HostIPC { get; set; }

        /// <summary>hostNetwork determines if the policy allows the use of HostNetwork in the pod spec.</summary>
        
        public Boolean? HostNetwork { get; set; }

        /// <summary>hostPID determines if the policy allows the use of HostPID in the pod spec.</summary>
        
        public Boolean? HostPID { get; set; }

        /// <summary>hostPorts determines which host port ranges are allowed to be exposed.</summary>
        
        public ICollection<HostPortRange2> HostPorts { get; set; }

        /// <summary>privileged determines if a pod can request to be run as privileged.</summary>
        
        public Boolean? Privileged { get; set; }

        /// <summary>readOnlyRootFilesystem when set to true will force containers to run with a read only root file system.  If the container specifically requests to run with a non-read only root file system the PSP should deny the pod. If set to false the container may run with a read only root file system if it wishes but it will not be forced to.</summary>
        
        public Boolean? ReadOnlyRootFilesystem { get; set; }

        /// <summary>requiredDropCapabilities are the capabilities that will be dropped from the container.  These are required to be dropped and cannot be added.</summary>
        
        public ICollection<String> RequiredDropCapabilities { get; set; }

        /// <summary>RunAsGroup is the strategy that will dictate the allowable RunAsGroup values that may be set. If this field is omitted, the pod's RunAsGroup can take any value. This field requires the RunAsGroup feature gate to be enabled.</summary>
        
        public RunAsGroupStrategyOptions2 RunAsGroup { get; set; }

        /// <summary>runAsUser is the strategy that will dictate the allowable RunAsUser values that may be set.</summary>
        
        [Required]
        public RunAsUserStrategyOptions2 RunAsUser { get; set; } = new RunAsUserStrategyOptions2();

        /// <summary>seLinux is the strategy that will dictate the allowable labels that may be set.</summary>
        
        [Required]
        public SELinuxStrategyOptions2 SeLinux { get; set; } = new SELinuxStrategyOptions2();

        /// <summary>supplementalGroups is the strategy that will dictate what supplemental groups are used by the SecurityContext.</summary>
        
        [Required]
        public SupplementalGroupsStrategyOptions2 SupplementalGroups { get; set; } = new SupplementalGroupsStrategyOptions2();

        /// <summary>volumes is a white list of allowed volume plugins. Empty indicates that no volumes may be used. To allow all volumes you may use '*'.</summary>
        
        public ICollection<String> Volumes { get; set; }
    }

    /// <summary>RunAsGroupStrategyOptions defines the strategy type and any options used to create the strategy.</summary>

    public partial class RunAsGroupStrategyOptions2
    {
        /// <summary>ranges are the allowed ranges of gids that may be used. If you would like to force a single gid then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange2> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate the allowable RunAsGroup values that may be set.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Rule { get; set; }
    }

    /// <summary>RunAsUserStrategyOptions defines the strategy type and any options used to create the strategy.</summary>

    public partial class RunAsUserStrategyOptions2
    {
        /// <summary>ranges are the allowed ranges of uids that may be used. If you would like to force a single uid then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange2> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate the allowable RunAsUser values that may be set.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Rule { get; set; }
    }

    /// <summary>SELinuxStrategyOptions defines the strategy type and any options used to create the strategy.</summary>

    public partial class SELinuxStrategyOptions2
    {
        /// <summary>rule is the strategy that will dictate the allowable labels that may be set.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Rule { get; set; }

        /// <summary>seLinuxOptions required to run as; required for MustRunAs More info: https://kubernetes.io/docs/tasks/configure-pod-container/security-context/</summary>
        
        public SELinuxOptions SeLinuxOptions { get; set; }
    }

    /// <summary>SupplementalGroupsStrategyOptions defines the strategy type and options used to create the strategy.</summary>

    public partial class SupplementalGroupsStrategyOptions2
    {
        /// <summary>ranges are the allowed ranges of supplemental groups.  If you would like to force a single supplemental group then supply a single range with the same start and end. Required for MustRunAs.</summary>
        
        public ICollection<IDRange2> Ranges { get; set; }

        /// <summary>rule is the strategy that will dictate what supplemental groups is used in the SecurityContext.</summary>
        
        public String Rule { get; set; }
    }

    /// <summary>AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole</summary>

    public partial class AggregationRule
    {
        /// <summary>ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added</summary>
        
        public ICollection<LabelSelector> ClusterRoleSelectors { get; set; }
    }

    /// <summary>ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.</summary>

    public partial class ClusterRole
    {
        /// <summary>AggregationRule is an optional field that describes how to build the Rules for this ClusterRole. If AggregationRule is set, then the Rules are controller managed and direct changes to Rules will be stomped by the controller.</summary>
        
        public AggregationRule AggregationRule { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Rules holds all the PolicyRules for this ClusterRole</summary>
        
        public ICollection<PolicyRule> Rules { get; set; }
    }

    /// <summary>ClusterRoleBinding references a ClusterRole, but not contain it.  It can reference a ClusterRole in the global namespace, and adds who information via Subject.</summary>

    public partial class ClusterRoleBinding
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleBindingKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</summary>
        
        [Required]
        public RoleRef RoleRef { get; set; } = new RoleRef();

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        
        public ICollection<Subject> Subjects { get; set; }
    }

    /// <summary>ClusterRoleBindingList is a collection of ClusterRoleBindings</summary>

    public partial class ClusterRoleBindingList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ClusterRoleBindings</summary>
        
        [Required]
        public ICollection<ClusterRoleBinding> Items { get; set; } = new Collection<ClusterRoleBinding>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleBindingListKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ClusterRoleList is a collection of ClusterRoles</summary>

    public partial class ClusterRoleList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ClusterRoles</summary>
        
        [Required]
        public ICollection<ClusterRole> Items { get; set; } = new Collection<ClusterRole>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleListKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.</summary>

    public partial class PolicyRule
    {
        /// <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.</summary>
        
        public ICollection<String> ApiGroups { get; set; }

        /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.</summary>
        
        public ICollection<String> NonResourceURLs { get; set; }

        /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
        
        public ICollection<String> ResourceNames { get; set; }

        /// <summary>Resources is a list of resources this rule applies to.  ResourceAll represents all resources.</summary>
        
        public ICollection<String> Resources { get; set; }

        /// <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.</summary>

    public partial class Role
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Rules holds all the PolicyRules for this Role</summary>
        
        public ICollection<PolicyRule> Rules { get; set; }
    }

    /// <summary>RoleBinding references a role, but does not contain it.  It can reference a Role in the same namespace or a ClusterRole in the global namespace. It adds who information via Subjects and namespace information by which namespace it exists in.  RoleBindings in a given namespace only have effect in that namespace.</summary>

    public partial class RoleBinding
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleBindingKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>RoleRef can reference a Role in the current namespace or a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</summary>
        
        [Required]
        public RoleRef RoleRef { get; set; } = new RoleRef();

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        
        public ICollection<Subject> Subjects { get; set; }
    }

    /// <summary>RoleBindingList is a collection of RoleBindings</summary>

    public partial class RoleBindingList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of RoleBindings</summary>
        
        [Required]
        public ICollection<RoleBinding> Items { get; set; } = new Collection<RoleBinding>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleBindingListKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RoleList is a collection of Roles</summary>

    public partial class RoleList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of Roles</summary>
        
        [Required]
        public ICollection<Role> Items { get; set; } = new Collection<Role>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleListKind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RoleRef contains information that points to the role being used</summary>

    public partial class RoleRef
    {
        /// <summary>APIGroup is the group for the resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ApiGroup { get; set; }

        /// <summary>Kind is the type of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name is the name of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>Subject contains a reference to the Object or user identities a role binding applies to.  This can either hold a direct API Object reference, or a value for non-objects such as user and group names.</summary>

    public partial class Subject
    {
        /// <summary>APIGroup holds the API group of the referenced subject. Defaults to "" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.</summary>
        
        public String ApiGroup { get; set; }

        /// <summary>Kind of Object being referenced. Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the Object being referenced.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Namespace of the referenced Object.  If the Object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.</summary>
        
        public String Namespace { get; set; }
    }

    /// <summary>AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole</summary>

    public partial class AggregationRule2
    {
        /// <summary>ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added</summary>
        
        public ICollection<LabelSelector> ClusterRoleSelectors { get; set; }
    }

    /// <summary>ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.</summary>

    public partial class ClusterRole2
    {
        /// <summary>AggregationRule is an optional field that describes how to build the Rules for this ClusterRole. If AggregationRule is set, then the Rules are controller managed and direct changes to Rules will be stomped by the controller.</summary>
        
        public AggregationRule2 AggregationRule { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRole2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Rules holds all the PolicyRules for this ClusterRole</summary>
        
        public ICollection<PolicyRule2> Rules { get; set; }
    }

    /// <summary>ClusterRoleBinding references a ClusterRole, but not contain it.  It can reference a ClusterRole in the global namespace, and adds who information via Subject.</summary>

    public partial class ClusterRoleBinding2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleBinding2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</summary>
        
        [Required]
        public RoleRef2 RoleRef { get; set; } = new RoleRef2();

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        
        public ICollection<Subject2> Subjects { get; set; }
    }

    /// <summary>ClusterRoleBindingList is a collection of ClusterRoleBindings</summary>

    public partial class ClusterRoleBindingList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ClusterRoleBindings</summary>
        
        [Required]
        public ICollection<ClusterRoleBinding2> Items { get; set; } = new Collection<ClusterRoleBinding2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleBindingList2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ClusterRoleList is a collection of ClusterRoles</summary>

    public partial class ClusterRoleList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ClusterRoles</summary>
        
        [Required]
        public ICollection<ClusterRole2> Items { get; set; } = new Collection<ClusterRole2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleList2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.</summary>

    public partial class PolicyRule2
    {
        /// <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.</summary>
        
        public ICollection<String> ApiGroups { get; set; }

        /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path This name is intentionally different than the internal type so that the DefaultConvert works nicely and because the ordering may be different. Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.</summary>
        
        public ICollection<String> NonResourceURLs { get; set; }

        /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
        
        public ICollection<String> ResourceNames { get; set; }

        /// <summary>Resources is a list of resources this rule applies to.  ResourceAll represents all resources.</summary>
        
        public ICollection<String> Resources { get; set; }

        /// <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.</summary>

    public partial class Role2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Role2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Rules holds all the PolicyRules for this Role</summary>
        
        public ICollection<PolicyRule2> Rules { get; set; }
    }

    /// <summary>RoleBinding references a role, but does not contain it.  It can reference a Role in the same namespace or a ClusterRole in the global namespace. It adds who information via Subjects and namespace information by which namespace it exists in.  RoleBindings in a given namespace only have effect in that namespace.</summary>

    public partial class RoleBinding2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleBinding2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>RoleRef can reference a Role in the current namespace or a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</summary>
        
        [Required]
        public RoleRef2 RoleRef { get; set; } = new RoleRef2();

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        
        public ICollection<Subject2> Subjects { get; set; }
    }

    /// <summary>RoleBindingList is a collection of RoleBindings</summary>

    public partial class RoleBindingList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of RoleBindings</summary>
        
        [Required]
        public ICollection<RoleBinding2> Items { get; set; } = new Collection<RoleBinding2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleBindingList2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RoleList is a collection of Roles</summary>

    public partial class RoleList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of Roles</summary>
        
        [Required]
        public ICollection<Role2> Items { get; set; } = new Collection<Role2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleList2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RoleRef contains information that points to the role being used</summary>

    public partial class RoleRef2
    {
        /// <summary>APIGroup is the group for the resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ApiGroup { get; set; }

        /// <summary>Kind is the type of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name is the name of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>Subject contains a reference to the Object or user identities a role binding applies to.  This can either hold a direct API Object reference, or a value for non-objects such as user and group names.</summary>

    public partial class Subject2
    {
        /// <summary>APIVersion holds the API group and version of the referenced subject. Defaults to "v1" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io/v1alpha1" for User and Group subjects.</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind of Object being referenced. Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the Object being referenced.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Namespace of the referenced Object.  If the Object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.</summary>
        
        public String Namespace { get; set; }
    }

    /// <summary>AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole</summary>

    public partial class AggregationRule3
    {
        /// <summary>ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added</summary>
        
        public ICollection<LabelSelector> ClusterRoleSelectors { get; set; }
    }

    /// <summary>ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.</summary>

    public partial class ClusterRole3
    {
        /// <summary>AggregationRule is an optional field that describes how to build the Rules for this ClusterRole. If AggregationRule is set, then the Rules are controller managed and direct changes to Rules will be stomped by the controller.</summary>
        
        public AggregationRule3 AggregationRule { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRole3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Rules holds all the PolicyRules for this ClusterRole</summary>
        
        public ICollection<PolicyRule3> Rules { get; set; }
    }

    /// <summary>ClusterRoleBinding references a ClusterRole, but not contain it.  It can reference a ClusterRole in the global namespace, and adds who information via Subject.</summary>

    public partial class ClusterRoleBinding3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleBinding3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>RoleRef can only reference a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</summary>
        
        [Required]
        public RoleRef3 RoleRef { get; set; } = new RoleRef3();

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        
        public ICollection<Subject3> Subjects { get; set; }
    }

    /// <summary>ClusterRoleBindingList is a collection of ClusterRoleBindings</summary>

    public partial class ClusterRoleBindingList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ClusterRoleBindings</summary>
        
        [Required]
        public ICollection<ClusterRoleBinding3> Items { get; set; } = new Collection<ClusterRoleBinding3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleBindingList3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>ClusterRoleList is a collection of ClusterRoles</summary>

    public partial class ClusterRoleList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of ClusterRoles</summary>
        
        [Required]
        public ICollection<ClusterRole3> Items { get; set; } = new Collection<ClusterRole3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public ClusterRoleList3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.</summary>

    public partial class PolicyRule3
    {
        /// <summary>APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.</summary>
        
        public ICollection<String> ApiGroups { get; set; }

        /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.</summary>
        
        public ICollection<String> NonResourceURLs { get; set; }

        /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
        
        public ICollection<String> ResourceNames { get; set; }

        /// <summary>Resources is a list of resources this rule applies to.  '*' represents all resources in the specified apiGroups. '*/foo' represents the subresource 'foo' for all resources in the specified apiGroups.</summary>
        
        public ICollection<String> Resources { get; set; }

        /// <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds.</summary>
        
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();
    }

    /// <summary>Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.</summary>

    public partial class Role3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public Role3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Rules holds all the PolicyRules for this Role</summary>
        
        public ICollection<PolicyRule3> Rules { get; set; }
    }

    /// <summary>RoleBinding references a role, but does not contain it.  It can reference a Role in the same namespace or a ClusterRole in the global namespace. It adds who information via Subjects and namespace information by which namespace it exists in.  RoleBindings in a given namespace only have effect in that namespace.</summary>

    public partial class RoleBinding3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleBinding3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>RoleRef can reference a Role in the current namespace or a ClusterRole in the global namespace. If the RoleRef cannot be resolved, the Authorizer must return an error.</summary>
        
        [Required]
        public RoleRef3 RoleRef { get; set; } = new RoleRef3();

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        
        public ICollection<Subject3> Subjects { get; set; }
    }

    /// <summary>RoleBindingList is a collection of RoleBindings</summary>

    public partial class RoleBindingList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of RoleBindings</summary>
        
        [Required]
        public ICollection<RoleBinding3> Items { get; set; } = new Collection<RoleBinding3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleBindingList3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RoleList is a collection of Roles</summary>

    public partial class RoleList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of Roles</summary>
        
        [Required]
        public ICollection<Role3> Items { get; set; } = new Collection<Role3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public RoleList3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata.</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>RoleRef contains information that points to the role being used</summary>

    public partial class RoleRef3
    {
        /// <summary>APIGroup is the group for the resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String ApiGroup { get; set; }

        /// <summary>Kind is the type of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name is the name of resource being referenced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>Subject contains a reference to the Object or user identities a role binding applies to.  This can either hold a direct API Object reference, or a value for non-objects such as user and group names.</summary>

    public partial class Subject3
    {
        /// <summary>APIGroup holds the API group of the referenced subject. Defaults to "" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.</summary>
        
        public String ApiGroup { get; set; }

        /// <summary>Kind of Object being referenced. Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the Object being referenced.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Namespace of the referenced Object.  If the Object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.</summary>
        
        public String Namespace { get; set; }
    }

    /// <summary>PriorityClass defines mapping from a priority class name to the priority integer value. The value can be any valid integer.</summary>

    public partial class PriorityClass
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>description is an arbitrary String that usually provides guidelines on when this priority class should be used.</summary>
        
        public String Description { get; set; }

        /// <summary>globalDefault specifies whether this PriorityClass should be considered as the default priority for pods that do not have any priority class. Only one PriorityClass can be marked as `globalDefault`. However, if more than one PriorityClasses exists with their `globalDefault` field set to true, the smallest value of such global default PriorityClasses will be used as the default priority.</summary>
        
        public Boolean? GlobalDefault { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PriorityClassKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The value of this priority class. This is the actual priority that pods receive when they have the name of this class in their pod spec.</summary>
        
        public int Value { get; set; }
    }

    /// <summary>PriorityClassList is a collection of priority classes.</summary>

    public partial class PriorityClassList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of PriorityClasses</summary>
        
        [Required]
        public ICollection<PriorityClass> Items { get; set; } = new Collection<PriorityClass>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PriorityClassListKind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED - This group version of PriorityClass is deprecated by scheduling.k8s.io/v1/PriorityClass. PriorityClass defines mapping from a priority class name to the priority integer value. The value can be any valid integer.</summary>

    public partial class PriorityClass2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>description is an arbitrary String that usually provides guidelines on when this priority class should be used.</summary>
        
        public String Description { get; set; }

        /// <summary>globalDefault specifies whether this PriorityClass should be considered as the default priority for pods that do not have any priority class. Only one PriorityClass can be marked as `globalDefault`. However, if more than one PriorityClasses exists with their `globalDefault` field set to true, the smallest value of such global default PriorityClasses will be used as the default priority.</summary>
        
        public Boolean? GlobalDefault { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PriorityClass2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The value of this priority class. This is the actual priority that pods receive when they have the name of this class in their pod spec.</summary>
        
        public int Value { get; set; }
    }

    /// <summary>PriorityClassList is a collection of priority classes.</summary>

    public partial class PriorityClassList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of PriorityClasses</summary>
        
        [Required]
        public ICollection<PriorityClass2> Items { get; set; } = new Collection<PriorityClass2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PriorityClassList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>DEPRECATED - This group version of PriorityClass is deprecated by scheduling.k8s.io/v1/PriorityClass. PriorityClass defines mapping from a priority class name to the priority integer value. The value can be any valid integer.</summary>

    public partial class PriorityClass3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>description is an arbitrary String that usually provides guidelines on when this priority class should be used.</summary>
        
        public String Description { get; set; }

        /// <summary>globalDefault specifies whether this PriorityClass should be considered as the default priority for pods that do not have any priority class. Only one PriorityClass can be marked as `globalDefault`. However, if more than one PriorityClasses exists with their `globalDefault` field set to true, the smallest value of such global default PriorityClasses will be used as the default priority.</summary>
        
        public Boolean? GlobalDefault { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PriorityClass3Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>The value of this priority class. This is the actual priority that pods receive when they have the name of this class in their pod spec.</summary>
        
        public int Value { get; set; }
    }

    /// <summary>PriorityClassList is a collection of priority classes.</summary>

    public partial class PriorityClassList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of PriorityClasses</summary>
        
        [Required]
        public ICollection<PriorityClass3> Items { get; set; } = new Collection<PriorityClass3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PriorityClassList3Kind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodPreset is a policy resource that defines additional runtime requirements for a Pod.</summary>

    public partial class PodPreset
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodPresetKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        
        public PodPresetSpec Spec { get; set; }
    }

    /// <summary>PodPresetList is a list of PodPreset objects.</summary>

    public partial class PodPresetList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is a list of schema objects.</summary>
        
        [Required]
        public ICollection<PodPreset> Items { get; set; } = new Collection<PodPreset>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public PodPresetListKind? Kind { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>PodPresetSpec is a description of a pod preset.</summary>

    public partial class PodPresetSpec
    {
        /// <summary>Env defines the collection of EnvVar to inject into containers.</summary>
        
        public ICollection<EnvVar> Env { get; set; }

        /// <summary>EnvFrom defines the collection of EnvFromSource to inject into containers.</summary>
        
        public ICollection<EnvFromSource> EnvFrom { get; set; }

        /// <summary>Selector is a label query over a set of resources, in this case pods. Required.</summary>
        
        public LabelSelector Selector { get; set; }

        /// <summary>VolumeMounts defines the collection of VolumeMount to inject into containers.</summary>
        
        public ICollection<VolumeMount> VolumeMounts { get; set; }

        /// <summary>Volumes defines the collection of Volume to inject into the pod.</summary>
        
        public ICollection<Volume> Volumes { get; set; }
    }

    /// <summary>StorageClass describes the parameters for a class of storage for which PersistentVolumes can be dynamically provisioned.
    /// <br/>
    /// <br/>StorageClasses are non-namespaced; the name of the storage class according to etcd is in ObjectMeta.Name.</summary>

    public partial class StorageClass
    {
        /// <summary>AllowVolumeExpansion shows whether the storage class allow volume expand</summary>
        
        public Boolean? AllowVolumeExpansion { get; set; }

        /// <summary>Restrict the node topologies where volumes can be dynamically provisioned. Each volume plugin defines its own supported topology specifications. An empty TopologySelectorTerm list means there is no topology restriction. This field is only honored by servers that enable the VolumeScheduling feature.</summary>
        
        public ICollection<TopologySelectorTerm> AllowedTopologies { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StorageClassKind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Dynamically provisioned PersistentVolumes of this storage class are created with these mountOptions, e.g. ["ro", "soft"]. Not validated - mount of the PVs will simply fail if one is invalid.</summary>
        
        public ICollection<String> MountOptions { get; set; }

        /// <summary>Parameters holds the parameters for the provisioner that should create volumes of this storage class.</summary>
        
        public IDictionary<String, String> Parameters { get; set; }

        /// <summary>Provisioner indicates the type of the provisioner.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Provisioner { get; set; }

        /// <summary>Dynamically provisioned PersistentVolumes of this storage class are created with this reclaimPolicy. Defaults to Delete.</summary>
        
        public String ReclaimPolicy { get; set; }

        /// <summary>VolumeBindingMode indicates how PersistentVolumeClaims should be provisioned and bound.  When unset, VolumeBindingImmediate is used. This field is only honored by servers that enable the VolumeScheduling feature.</summary>
        
        public String VolumeBindingMode { get; set; }
    }

    /// <summary>StorageClassList is a collection of storage classes.</summary>

    public partial class StorageClassList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of StorageClasses</summary>
        
        [Required]
        public ICollection<StorageClass> Items { get; set; } = new Collection<StorageClass>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StorageClassListKind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>VolumeAttachment captures the intent to attach or detach the specified volume to/from the specified node.
    /// <br/>
    /// <br/>VolumeAttachment objects are non-namespaced.</summary>

    public partial class VolumeAttachment
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public VolumeAttachmentKind? Kind { get; set; }

        /// <summary>Standard Object metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired attach/detach volume behavior. Populated by the Kubernetes system.</summary>
        
        [Required]
        public VolumeAttachmentSpec Spec { get; set; } = new VolumeAttachmentSpec();

        /// <summary>Status of the VolumeAttachment request. Populated by the entity completing the attach or detach operation, i.e. the external-attacher.</summary>
        
        public VolumeAttachmentStatus Status { get; set; }
    }

    /// <summary>VolumeAttachmentList is a collection of VolumeAttachment objects.</summary>

    public partial class VolumeAttachmentList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of VolumeAttachments</summary>
        
        [Required]
        public ICollection<VolumeAttachment> Items { get; set; } = new Collection<VolumeAttachment>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public VolumeAttachmentListKind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>VolumeAttachmentSource represents a volume that should be attached. Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.</summary>

    public partial class VolumeAttachmentSource
    {
        /// <summary>Name of the persistent volume to attach.</summary>
        
        public String PersistentVolumeName { get; set; }
    }

    /// <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary>

    public partial class VolumeAttachmentSpec
    {
        /// <summary>Attacher indicates the name of the volume driver that MUST handle this request. This is the name returned by GetPluginName().</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Attacher { get; set; }

        /// <summary>The node that the volume should be attached to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String NodeName { get; set; }

        /// <summary>Source represents the volume that should be attached.</summary>
        
        [Required]
        public VolumeAttachmentSource Source { get; set; } = new VolumeAttachmentSource();
    }

    /// <summary>VolumeAttachmentStatus is the status of a VolumeAttachment request.</summary>

    public partial class VolumeAttachmentStatus
    {
        /// <summary>The last error encountered during attach operation, if any. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public VolumeError AttachError { get; set; }

        /// <summary>Indicates the volume is successfully attached. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public Boolean Attached { get; set; }

        /// <summary>Upon successful attach, this field is populated with any information returned by the attach operation that must be passed into subsequent WaitForAttach or Mount calls. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public IDictionary<String, String> AttachmentMetadata { get; set; }

        /// <summary>The last error encountered during detach operation, if any. This field must only be set by the entity completing the detach operation, i.e. the external-attacher.</summary>
        
        public VolumeError DetachError { get; set; }
    }

    /// <summary>VolumeError captures an error encountered during a volume operation.</summary>

    public partial class VolumeError
    {
        /// <summary>String detailing the error encountered during Attach or Detach operation. This String may be logged, so it should not contain sensitive information.</summary>
        
        public String Message { get; set; }

        /// <summary>Time the error was encountered.</summary>
        
        public DateTimeOffset? Time { get; set; }
    }

    /// <summary>VolumeAttachment captures the intent to attach or detach the specified volume to/from the specified node.
    /// <br/>
    /// <br/>VolumeAttachment objects are non-namespaced.</summary>

    public partial class VolumeAttachment2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public VolumeAttachment2Kind? Kind { get; set; }

        /// <summary>Standard Object metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired attach/detach volume behavior. Populated by the Kubernetes system.</summary>
        
        [Required]
        public VolumeAttachmentSpec2 Spec { get; set; } = new VolumeAttachmentSpec2();

        /// <summary>Status of the VolumeAttachment request. Populated by the entity completing the attach or detach operation, i.e. the external-attacher.</summary>
        
        public VolumeAttachmentStatus2 Status { get; set; }
    }

    /// <summary>VolumeAttachmentList is a collection of VolumeAttachment objects.</summary>

    public partial class VolumeAttachmentList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of VolumeAttachments</summary>
        
        [Required]
        public ICollection<VolumeAttachment2> Items { get; set; } = new Collection<VolumeAttachment2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public VolumeAttachmentList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>VolumeAttachmentSource represents a volume that should be attached. Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.</summary>

    public partial class VolumeAttachmentSource2
    {
        /// <summary>Name of the persistent volume to attach.</summary>
        
        public String PersistentVolumeName { get; set; }
    }

    /// <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary>

    public partial class VolumeAttachmentSpec2
    {
        /// <summary>Attacher indicates the name of the volume driver that MUST handle this request. This is the name returned by GetPluginName().</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Attacher { get; set; }

        /// <summary>The node that the volume should be attached to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String NodeName { get; set; }

        /// <summary>Source represents the volume that should be attached.</summary>
        
        [Required]
        public VolumeAttachmentSource2 Source { get; set; } = new VolumeAttachmentSource2();
    }

    /// <summary>VolumeAttachmentStatus is the status of a VolumeAttachment request.</summary>

    public partial class VolumeAttachmentStatus2
    {
        /// <summary>The last error encountered during attach operation, if any. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public VolumeError2 AttachError { get; set; }

        /// <summary>Indicates the volume is successfully attached. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public Boolean Attached { get; set; }

        /// <summary>Upon successful attach, this field is populated with any information returned by the attach operation that must be passed into subsequent WaitForAttach or Mount calls. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public IDictionary<String, String> AttachmentMetadata { get; set; }

        /// <summary>The last error encountered during detach operation, if any. This field must only be set by the entity completing the detach operation, i.e. the external-attacher.</summary>
        
        public VolumeError2 DetachError { get; set; }
    }

    /// <summary>VolumeError captures an error encountered during a volume operation.</summary>

    public partial class VolumeError2
    {
        /// <summary>String detailing the error encountered during Attach or Detach operation. This String maybe logged, so it should not contain sensitive information.</summary>
        
        public String Message { get; set; }

        /// <summary>Time the error was encountered.</summary>
        
        public DateTimeOffset? Time { get; set; }
    }

    /// <summary>CSIDriver captures information about a Container Storage Interface (CSI) volume driver deployed on the cluster. CSI drivers do not need to create the CSIDriver Object directly. Instead they may use the cluster-driver-registrar sidecar container. When deployed with a CSI driver it automatically creates a CSIDriver Object representing the driver. Kubernetes attach detach controller uses this Object to determine whether attach is required. Kubelet uses this Object to determine whether pod information needs to be passed on mount. CSIDriver objects are non-namespaced.</summary>

    public partial class CSIDriver
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CSIDriverKind? Kind { get; set; }

        /// <summary>Standard Object metadata. metadata.Name indicates the name of the CSI driver that this Object refers to; it MUST be the same name returned by the CSI GetPluginName() call for that driver. The driver name must be 63 characters or less, beginning and ending with an alphanumeric character ([a-z0-9A-Z]) with dashes (-), dots (.), and alphanumerics between. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the CSI Driver.</summary>
        
        [Required]
        public CSIDriverSpec Spec { get; set; } = new CSIDriverSpec();
    }

    /// <summary>CSIDriverList is a collection of CSIDriver objects.</summary>

    public partial class CSIDriverList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of CSIDriver</summary>
        
        [Required]
        public ICollection<CSIDriver> Items { get; set; } = new Collection<CSIDriver>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CSIDriverListKind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>CSIDriverSpec is the specification of a CSIDriver.</summary>

    public partial class CSIDriverSpec
    {
        /// <summary>attachRequired indicates this CSI volume driver requires an attach operation (because it implements the CSI ControllerPublishVolume() method), and that the Kubernetes attach detach controller should call the attach volume interface which checks the volumeattachment status and waits until the volume is attached before proceeding to mounting. The CSI external-attacher coordinates with CSI volume driver and updates the volumeattachment status when the attach operation is complete. If the CSIDriverRegistry feature gate is enabled and the value is specified to false, the attach operation will be skipped. Otherwise the attach operation will be called.</summary>
        
        public Boolean? AttachRequired { get; set; }

        /// <summary>If set to true, podInfoOnMount indicates this CSI volume driver requires additional pod information (like podName, podUID, etc.) during mount operations. If set to false, pod information will not be passed on mount. Default is false. The CSI driver specifies podInfoOnMount as part of driver deployment. If true, Kubelet will pass pod information as VolumeContext in the CSI NodePublishVolume() calls. The CSI driver is responsible for parsing and validating the information passed in as VolumeContext. The following VolumeConext will be passed if podInfoOnMount is set to true. This list might grow, but the prefix will be used. "csi.storage.k8s.io/pod.name": pod.Name "csi.storage.k8s.io/pod.namespace": pod.Namespace "csi.storage.k8s.io/pod.uid": String(pod.UID)</summary>
        
        public Boolean? PodInfoOnMount { get; set; }
    }

    /// <summary>CSINode holds information about all CSI drivers installed on a node. CSI drivers do not need to create the CSINode Object directly. As long as they use the node-driver-registrar sidecar container, the kubelet will automatically populate the CSINode Object for the CSI driver as part of kubelet plugin registration. CSINode has the same name as a node. If the Object is missing, it means either there are no CSI Drivers available on the node, or the Kubelet version is low enough that it doesn't create this Object. CSINode has an OwnerReference that points to the corresponding node Object.</summary>

    public partial class CSINode
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CSINodeKind? Kind { get; set; }

        /// <summary>metadata.name must be the Kubernetes node name.</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>spec is the specification of CSINode</summary>
        
        [Required]
        public CSINodeSpec Spec { get; set; } = new CSINodeSpec();
    }

    /// <summary>CSINodeDriver holds information about the specification of one CSI driver installed on a node</summary>

    public partial class CSINodeDriver
    {
        /// <summary>This is the name of the CSI driver that this Object refers to. This MUST be the same name returned by the CSI GetPluginName() call for that driver.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>nodeID of the node from the driver point of view. This field enables Kubernetes to communicate with storage systems that do not share the same nomenclature for nodes. For example, Kubernetes may refer to a given node as "node1", but the storage system may refer to the same node as "nodeA". When Kubernetes issues a command to the storage system to attach a volume to a specific node, it can use this field to refer to the node name using the ID that the storage system will understand, e.g. "nodeA" instead of "node1". This field is required.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String NodeID { get; set; }

        /// <summary>topologyKeys is the list of keys supported by the driver. When a driver is initialized on a cluster, it provides a set of topology keys that it understands (e.g. "company.com/zone", "company.com/region"). When a driver is initialized on a node, it provides the same topology keys along with values. Kubelet will expose these topology keys as labels on its own node Object. When Kubernetes does topology aware provisioning, it can use this list to determine which labels it should retrieve from the node Object and pass back to the driver. It is possible for different nodes to use different topology keys. This can be empty if driver does not support topology.</summary>
        
        public ICollection<String> TopologyKeys { get; set; }
    }

    /// <summary>CSINodeList is a collection of CSINode objects.</summary>

    public partial class CSINodeList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>items is the list of CSINode</summary>
        
        [Required]
        public ICollection<CSINode> Items { get; set; } = new Collection<CSINode>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CSINodeListKind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>CSINodeSpec holds information about the specification of all CSI drivers installed on a node</summary>

    public partial class CSINodeSpec
    {
        /// <summary>drivers is a list of information of all CSI Drivers existing on a node. If all drivers in the list are uninstalled, this can become empty.</summary>
        
        [Required]
        public ICollection<CSINodeDriver> Drivers { get; set; } = new Collection<CSINodeDriver>();
    }

    /// <summary>StorageClass describes the parameters for a class of storage for which PersistentVolumes can be dynamically provisioned.
    /// <br/>
    /// <br/>StorageClasses are non-namespaced; the name of the storage class according to etcd is in ObjectMeta.Name.</summary>

    public partial class StorageClass2
    {
        /// <summary>AllowVolumeExpansion shows whether the storage class allow volume expand</summary>
        
        public Boolean? AllowVolumeExpansion { get; set; }

        /// <summary>Restrict the node topologies where volumes can be dynamically provisioned. Each volume plugin defines its own supported topology specifications. An empty TopologySelectorTerm list means there is no topology restriction. This field is only honored by servers that enable the VolumeScheduling feature.</summary>
        
        public ICollection<TopologySelectorTerm> AllowedTopologies { get; set; }

        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StorageClass2Kind? Kind { get; set; }

        /// <summary>Standard Object's metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Dynamically provisioned PersistentVolumes of this storage class are created with these mountOptions, e.g. ["ro", "soft"]. Not validated - mount of the PVs will simply fail if one is invalid.</summary>
        
        public ICollection<String> MountOptions { get; set; }

        /// <summary>Parameters holds the parameters for the provisioner that should create volumes of this storage class.</summary>
        
        public IDictionary<String, String> Parameters { get; set; }

        /// <summary>Provisioner indicates the type of the provisioner.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Provisioner { get; set; }

        /// <summary>Dynamically provisioned PersistentVolumes of this storage class are created with this reclaimPolicy. Defaults to Delete.</summary>
        
        public String ReclaimPolicy { get; set; }

        /// <summary>VolumeBindingMode indicates how PersistentVolumeClaims should be provisioned and bound.  When unset, VolumeBindingImmediate is used. This field is only honored by servers that enable the VolumeScheduling feature.</summary>
        
        public String VolumeBindingMode { get; set; }
    }

    /// <summary>StorageClassList is a collection of storage classes.</summary>

    public partial class StorageClassList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of StorageClasses</summary>
        
        [Required]
        public ICollection<StorageClass2> Items { get; set; } = new Collection<StorageClass2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public StorageClassList2Kind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>VolumeAttachment captures the intent to attach or detach the specified volume to/from the specified node.
    /// <br/>
    /// <br/>VolumeAttachment objects are non-namespaced.</summary>

    public partial class VolumeAttachment3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public VolumeAttachment3Kind? Kind { get; set; }

        /// <summary>Standard Object metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired attach/detach volume behavior. Populated by the Kubernetes system.</summary>
        
        [Required]
        public VolumeAttachmentSpec3 Spec { get; set; } = new VolumeAttachmentSpec3();

        /// <summary>Status of the VolumeAttachment request. Populated by the entity completing the attach or detach operation, i.e. the external-attacher.</summary>
        
        public VolumeAttachmentStatus3 Status { get; set; }
    }

    /// <summary>VolumeAttachmentList is a collection of VolumeAttachment objects.</summary>

    public partial class VolumeAttachmentList3
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items is the list of VolumeAttachments</summary>
        
        [Required]
        public ICollection<VolumeAttachment3> Items { get; set; } = new Collection<VolumeAttachment3>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public VolumeAttachmentList3Kind? Kind { get; set; }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>VolumeAttachmentSource represents a volume that should be attached. Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.</summary>

    public partial class VolumeAttachmentSource3
    {
        /// <summary>Name of the persistent volume to attach.</summary>
        
        public String PersistentVolumeName { get; set; }
    }

    /// <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary>

    public partial class VolumeAttachmentSpec3
    {
        /// <summary>Attacher indicates the name of the volume driver that MUST handle this request. This is the name returned by GetPluginName().</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Attacher { get; set; }

        /// <summary>The node that the volume should be attached to.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String NodeName { get; set; }

        /// <summary>Source represents the volume that should be attached.</summary>
        
        [Required]
        public VolumeAttachmentSource3 Source { get; set; } = new VolumeAttachmentSource3();
    }

    /// <summary>VolumeAttachmentStatus is the status of a VolumeAttachment request.</summary>

    public partial class VolumeAttachmentStatus3
    {
        /// <summary>The last error encountered during attach operation, if any. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public VolumeError3 AttachError { get; set; }

        /// <summary>Indicates the volume is successfully attached. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public Boolean Attached { get; set; }

        /// <summary>Upon successful attach, this field is populated with any information returned by the attach operation that must be passed into subsequent WaitForAttach or Mount calls. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.</summary>
        
        public IDictionary<String, String> AttachmentMetadata { get; set; }

        /// <summary>The last error encountered during detach operation, if any. This field must only be set by the entity completing the detach operation, i.e. the external-attacher.</summary>
        
        public VolumeError3 DetachError { get; set; }
    }

    /// <summary>VolumeError captures an error encountered during a volume operation.</summary>

    public partial class VolumeError3
    {
        /// <summary>String detailing the error encountered during Attach or Detach operation. This String may be logged, so it should not contain sensitive information.</summary>
        
        public String Message { get; set; }

        /// <summary>Time the error was encountered.</summary>
        
        public DateTimeOffset? Time { get; set; }
    }

    /// <summary>CustomResourceColumnDefinition specifies a column for server side printing.</summary>

    public partial class CustomResourceColumnDefinition
    {
        /// <summary>JSONPath is a simple JSON path, i.e. with array notation.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String JSONPath { get; set; }

        /// <summary>description is a human readable description of this column.</summary>
        
        public String Description { get; set; }

        /// <summary>format is an optional OpenAPI type definition for this column. The 'name' format is applied to the primary identifier column to assist in clients identifying column is the resource name. See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for more.</summary>
        
        public String Format { get; set; }

        /// <summary>name is a human readable name for the column.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>priority is an integer defining the relative importance of this column compared to others. Lower numbers are considered higher priority. Columns that may be omitted in limited space scenarios should be given a higher priority.</summary>
        
        public int? Priority { get; set; }

        /// <summary>type is an OpenAPI type definition for this column. See https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for more.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>CustomResourceConversion describes how to convert different versions of a CR.</summary>

    public partial class CustomResourceConversion
    {
        /// <summary>ConversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. API server will try to use first version in the list which it supports. If none of the versions specified in this list supported by API server, conversion will fail for this Object. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail. Default to `['v1beta1']`.</summary>
        
        public ICollection<String> ConversionReviewVersions { get; set; }

        /// <summary>`strategy` specifies the conversion strategy. Allowed values are: - `None`: The converter only change the apiVersion and would not touch any other field in the CR. - `Webhook`: API Server will call to an external webhook to do the conversion. Additional information is needed for this option.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Strategy { get; set; }

        /// <summary>`webhookClientConfig` is the instructions for how to call the webhook if strategy is `Webhook`. This field is alpha-level and is only honored by servers that enable the CustomResourceWebhookConversion feature.</summary>
        
        public WebhookClientConfig3 WebhookClientConfig { get; set; }
    }

    /// <summary>CustomResourceDefinition represents a resource that should be exposed on the API server.  Its name MUST be in the format &lt;.spec.name&gt;.&lt;.spec.group&gt;.</summary>

    public partial class CustomResourceDefinition
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CustomResourceDefinitionKind? Kind { get; set; }

        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec describes how the user wants the resources to appear</summary>
        
        [Required]
        public CustomResourceDefinitionSpec Spec { get; set; } = new CustomResourceDefinitionSpec();

        /// <summary>Status indicates the actual state of the CustomResourceDefinition</summary>
        
        public CustomResourceDefinitionStatus Status { get; set; }
    }

    /// <summary>CustomResourceDefinitionCondition contains details for the current condition of this pod.</summary>

    public partial class CustomResourceDefinitionCondition
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>
        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human-readable message indicating details about last transition.</summary>
        
        public String Message { get; set; }

        /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
        
        public String Reason { get; set; }

        /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type is the type of the condition.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>CustomResourceDefinitionList is a list of CustomResourceDefinition objects.</summary>

    public partial class CustomResourceDefinitionList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        
        public String ApiVersion { get; set; }

        /// <summary>Items individual CustomResourceDefinitions</summary>
        
        [Required]
        public ICollection<CustomResourceDefinition> Items { get; set; } = new Collection<CustomResourceDefinition>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        
        
        public CustomResourceDefinitionListKind? Kind { get; set; }

        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition</summary>

    public partial class CustomResourceDefinitionNames
    {
        /// <summary>Categories is a list of grouped resources custom resources belong to (e.g. 'all')</summary>
        
        public ICollection<String> Categories { get; set; }

        /// <summary>Kind is the serialized kind of the resource.  It is normally CamelCase and singular.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>ListKind is the serialized kind of the list for this resource.  Defaults to &lt;kind&gt;List.</summary>
        
        public String ListKind { get; set; }

        /// <summary>Plural is the plural name of the resource to serve.  It must match the name of the CustomResourceDefinition-registration too: plural.group and it must be all lowercase.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Plural { get; set; }

        /// <summary>ShortNames are short names for the resource.  It must be all lowercase.</summary>
        
        public ICollection<String> ShortNames { get; set; }

        /// <summary>Singular is the singular name of the resource.  It must be all lowercase  Defaults to lowercased &lt;kind&gt;</summary>
        
        public String Singular { get; set; }
    }

    /// <summary>CustomResourceDefinitionSpec describes how a user wants their resource to appear</summary>

    public partial class CustomResourceDefinitionSpec
    {
        /// <summary>AdditionalPrinterColumns are additional columns shown e.g. in kubectl next to the name. Defaults to a created-at column. Optional, the global columns for all versions. Top-level and per-version columns are mutually exclusive.</summary>
        
        public ICollection<CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

        /// <summary>`conversion` defines conversion settings for the CRD.</summary>
        
        public CustomResourceConversion Conversion { get; set; }

        /// <summary>Group is the group this resource belongs in</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Group { get; set; }

        /// <summary>Names are the names used to describe this custom resource</summary>
        
        [Required]
        public CustomResourceDefinitionNames Names { get; set; } = new CustomResourceDefinitionNames();

        /// <summary>Scope indicates whether this resource is cluster or namespace scoped.  Default is namespaced</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Scope { get; set; }

        /// <summary>Subresources describes the subresources for CustomResource Optional, the global subresources for all versions. Top-level and per-version subresources are mutually exclusive.</summary>
        
        public CustomResourceSubresources Subresources { get; set; }

        /// <summary>Validation describes the validation methods for CustomResources Optional, the global validation schema for all versions. Top-level and per-version schemas are mutually exclusive.</summary>
        
        public CustomResourceValidation Validation { get; set; }

        /// <summary>Version is the version this resource belongs in Should be always first item in Versions field if provided. Optional, but at least one of Version or Versions must be set. Deprecated: Please use `Versions`.</summary>
        
        public String Version { get; set; }

        /// <summary>Versions is the list of all supported versions for this resource. If Version field is provided, this field is optional. Validation: All versions must use the same validation schema for now. i.e., top level Validation field is applied to all of these versions. Order: The version name will be used to compute the order. If the version String is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the String "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.</summary>
        
        public ICollection<CustomResourceDefinitionVersion> Versions { get; set; }
    }

    /// <summary>CustomResourceDefinitionStatus indicates the state of the CustomResourceDefinition</summary>

    public partial class CustomResourceDefinitionStatus
    {
        /// <summary>AcceptedNames are the names that are actually being used to serve discovery They may be different than the names in spec.</summary>
        
        [Required]
        public CustomResourceDefinitionNames AcceptedNames { get; set; } = new CustomResourceDefinitionNames();

        /// <summary>Conditions indicate state for particular aspects of a CustomResourceDefinition</summary>
        
        [Required]
        public ICollection<CustomResourceDefinitionCondition> Conditions { get; set; } = new Collection<CustomResourceDefinitionCondition>();

        /// <summary>StoredVersions are all versions of CustomResources that were ever persisted. Tracking these versions allows a migration path for stored versions in etcd. The field is mutable so the migration controller can first finish a migration to another version (i.e. that no old objects are left in the storage), and then remove the rest of the versions from this list. None of the versions in this list can be removed from the spec.Versions field.</summary>
        
        [Required]
        public ICollection<String> StoredVersions { get; set; } = new Collection<String>();
    }

    /// <summary>CustomResourceDefinitionVersion describes a version for CRD.</summary>

    public partial class CustomResourceDefinitionVersion
    {
        /// <summary>AdditionalPrinterColumns are additional columns shown e.g. in kubectl next to the name. Defaults to a created-at column. Top-level and per-version columns are mutually exclusive. Per-version columns must not all be set to identical values (top-level columns should be used instead) This field is alpha-level and is only honored by servers that enable the CustomResourceWebhookConversion feature. NOTE: CRDs created prior to 1.13 populated the top-level additionalPrinterColumns field by default. To apply an update that changes to per-version additionalPrinterColumns, the top-level additionalPrinterColumns field must be explicitly set to null</summary>
        
        public ICollection<CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

        /// <summary>Name is the version name, e.g. “v1”, “v2beta1”, etc.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>Schema describes the schema for CustomResource used in validation, pruning, and defaulting. Top-level and per-version schemas are mutually exclusive. Per-version schemas must not all be set to identical values (top-level validation schema should be used instead) This field is alpha-level and is only honored by servers that enable the CustomResourceWebhookConversion feature.</summary>
        
        public CustomResourceValidation Schema { get; set; }

        /// <summary>Served is a flag enabling/disabling this version from being served via REST APIs</summary>
        
        public Boolean Served { get; set; }

        /// <summary>Storage flags the version as storage version. There must be exactly one flagged as storage version.</summary>
        
        public Boolean Storage { get; set; }

        /// <summary>Subresources describes the subresources for CustomResource Top-level and per-version subresources are mutually exclusive. Per-version subresources must not all be set to identical values (top-level subresources should be used instead) This field is alpha-level and is only honored by servers that enable the CustomResourceWebhookConversion feature.</summary>
        
        public CustomResourceSubresources Subresources { get; set; }
    }

    /// <summary>CustomResourceSubresourceScale defines how to serve the scale subresource for CustomResources.</summary>

    public partial class CustomResourceSubresourceScale
    {
        /// <summary>LabelSelectorPath defines the JSON path inside of a CustomResource that corresponds to Scale.Status.Selector. Only JSON paths without the array notation are allowed. Must be a JSON Path under .status. Must be set to work with HPA. If there is no value under the given path in the CustomResource, the status label selector value in the /scale subresource will default to the empty String.</summary>
        
        public String LabelSelectorPath { get; set; }

        /// <summary>SpecReplicasPath defines the JSON path inside of a CustomResource that corresponds to Scale.Spec.Replicas. Only JSON paths without the array notation are allowed. Must be a JSON Path under .spec. If there is no value under the given path in the CustomResource, the /scale subresource will return an error on GET.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String SpecReplicasPath { get; set; }

        /// <summary>StatusReplicasPath defines the JSON path inside of a CustomResource that corresponds to Scale.Status.Replicas. Only JSON paths without the array notation are allowed. Must be a JSON Path under .status. If there is no value under the given path in the CustomResource, the status replica value in the /scale subresource will default to 0.</summary>
        
        [Required(AllowEmptyStrings = true)]
        public String StatusReplicasPath { get; set; }
    }

    /// <summary>CustomResourceSubresourceStatus defines how to serve the status subresource for CustomResources. Status is represented by the `.status` JSON path inside of a CustomResource. When set, * exposes a /status subresource for the custom resource * PUT requests to the /status subresource take a custom resource Object, and ignore changes to anything except the status stanza * PUT/POST/PATCH requests to the custom resource ignore changes to the status stanza</summary>

    public partial class CustomResourceSubresourceStatus
    {

    }

    /// <summary>CustomResourceSubresources defines the status and scale subresources for CustomResources.</summary>
    public partial class CustomResourceSubresources
    {
        /// <summary>Scale denotes the scale subresource for CustomResources</summary>        
        public CustomResourceSubresourceScale Scale { get; set; }

        /// <summary>Status denotes the status subresource for CustomResources</summary>        
        public CustomResourceSubresourceStatus Status { get; set; }
    }

    /// <summary>CustomResourceValidation is a list of validation methods for CustomResources.</summary>

    public partial class CustomResourceValidation
    {
        /// <summary>OpenAPIV3Schema is the OpenAPI v3 schema to be validated against.</summary>
        
        //public JSONSchemaProps OpenAPIV3Schema { get; set; }
    }

    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io</summary>
    public partial class ServiceReference3
    {
        /// <summary>`name` is the name of the service. Required</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>`namespace` is the namespace of the service. Required</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Namespace { get; set; }

        /// <summary>`path` is an optional URL path which will be sent in any request to this service.</summary>        
        public String Path { get; set; }
    }

    /// <summary>WebhookClientConfig contains the information to make a TLS connection with the webhook. It has the same field as admissionregistration.v1beta1.WebhookClientConfig.</summary>
    public partial class WebhookClientConfig3
    {
        /// <summary>`caBundle` is a PEM encoded CA bundle which will be used to validate the webhook's server certificate. If unspecified, system trust roots on the apiserver are used.</summary>        
        public byte[] CaBundle { get; set; }

        /// <summary>`service` is a reference to the service for this webhook. Either `service` or `url` must be specified.
        /// <br/>
        /// <br/>If the webhook is running within the cluster, then you should use `service`.
        /// <br/>
        /// <br/>Port 443 will be used if it is open, otherwise it is an error.</summary>        
        public ServiceReference3 Service { get; set; }

        /// <summary>`url` gives the location of the webhook, in standard URL form (`scheme://host:port/path`). Exactly one of `url` or `service` must be specified.
        /// <br/>
        /// <br/>The `host` should not refer to a service running in the cluster; use the `service` field instead. The host might be resolved via external DNS in some apiservers (e.g., `kube-apiserver` cannot resolve in-cluster DNS as that would be a layering violation). `host` may also be an IP address.
        /// <br/>
        /// <br/>Please note that using `localhost` or `127.0.0.1` as a `host` is risky unless you take great care to run this webhook on all hosts which run an apiserver which might need to make calls to this webhook. Such installs are likely to be non-portable, i.e., not easy to turn up in a new cluster.
        /// <br/>
        /// <br/>The scheme must be "https"; the URL must begin with "https://".
        /// <br/>
        /// <br/>A path is optional, and if present may be any String permissible in a URL. You may use the path to pass an arbitrary String to the webhook, for example, a cluster identifier.
        /// <br/>
        /// <br/>Attempting to use a user or basic auth e.g. "user:password@" is not allowed. Fragments ("#...") and query parameters ("?...") are not allowed, either.</summary>        
        public String Url { get; set; }
    }

    /// <summary>APIGroup contains the name, the supported versions, and the preferred version of a group.</summary>
    public partial class APIGroup
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIGroupKind? Kind { get; set; }

        /// <summary>name is the name of the group.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>preferredVersion is the version preferred by the API server, which probably is the storage version.</summary>
        public GroupVersionForDiscovery PreferredVersion { get; set; }

        /// <summary>a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.</summary>
        public ICollection<ServerAddressByClientCIDR> ServerAddressByClientCIDRs { get; set; }

        /// <summary>versions are the versions supported in this group.</summary>        
        [Required]
        public ICollection<GroupVersionForDiscovery> Versions { get; set; } = new Collection<GroupVersionForDiscovery>();
    }

    /// <summary>APIGroupList is a list of APIGroup, to allow clients to discover the API at /apis.</summary>
    public partial class APIGroupList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>groups is a list of APIGroup.</summary>
        [Required]
        public ICollection<APIGroup> Groups { get; set; } = new Collection<APIGroup>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIGroupListKind? Kind { get; set; }
    }

    /// <summary>APIResource specifies the name of a resource and whether it is namespaced.</summary>
    public partial class APIResource
    {
        /// <summary>categories is a list of the grouped resources this resource belongs to (e.g. 'all')</summary>
        public ICollection<String> Categories { get; set; }

        /// <summary>group is the preferred group of the resource.  Empty implies the group of the containing resource list. For subresources, this may have a different value, for example: Scale".</summary>
        public String Group { get; set; }

        /// <summary>kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')</summary>
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>name is the plural name of the resource.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>namespaced indicates if a resource is namespaced or not.</summary>
        public Boolean Namespaced { get; set; }

        /// <summary>shortNames is a list of suggested short names of the resource.</summary>
        public ICollection<String> ShortNames { get; set; }

        /// <summary>singularName is the singular name of the resource.  This allows clients to handle plural and singular opaquely. The singularName is more correct for reporting status on a single item and both singular and plural are allowed from the kubectl CLI interface.</summary>
        [Required(AllowEmptyStrings = true)]
        public String SingularName { get; set; }

        /// <summary>The hash value of the storage version, the version this resource is converted to when written to the data store. Value must be treated as opaque by clients. Only equality comparison on the value is valid. This is an alpha feature and may change or be removed in the future. The field is populated by the apiserver only if the StorageVersionHash feature gate is enabled. This field will remain optional even if it graduates.</summary>
        public String StorageVersionHash { get; set; }

        /// <summary>verbs is a list of supported kube verbs (this includes get, list, watch, create, update, patch, delete, deletecollection, and proxy)</summary>
        [Required]
        public ICollection<String> Verbs { get; set; } = new Collection<String>();

        /// <summary>version is the preferred version of the resource.  Empty implies the version of the containing resource list For subresources, this may have a different value, for example: v1 (while inside a v1beta1 version of the core resource's group)".</summary>
        public String Version { get; set; }
    }

    /// <summary>APIResourceList is a list of APIResource, it is used to expose the name of the resources supported in a specific group and version, and if the resource is namespaced.</summary>
    public partial class APIResourceList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>groupVersion is the group and version this APIResourceList is for.</summary>
        [Required(AllowEmptyStrings = true)]
        public String GroupVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIResourceListKind? Kind { get; set; }

        /// <summary>resources contains the name of the resources and if they are namespaced.</summary>
        [Required]
        public ICollection<APIResource> Resources { get; set; } = new Collection<APIResource>();
    }

    /// <summary>APIVersions lists the versions that are available, to allow clients to discover the API at /api, which is the root path of the legacy v1 API.</summary>
    public partial class APIVersions
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIVersionsKind? Kind { get; set; }

        /// <summary>a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.</summary>
        [Required]
        public ICollection<ServerAddressByClientCIDR> ServerAddressByClientCIDRs { get; set; } = new Collection<ServerAddressByClientCIDR>();

        /// <summary>versions are the api versions that are available.</summary>        
        [Required]
        public ICollection<String> Versions { get; set; } = new Collection<String>();
    }

    /// <summary>DeleteOptions may be provided when deleting an API Object.</summary>

    public partial class DeleteOptions
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>When present, indicates that modifications should not be persisted. An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed</summary>
        public ICollection<String> DryRun { get; set; }

        /// <summary>The duration in seconds before the Object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per Object value if not specified. zero means delete immediately.</summary>
        public long? GracePeriodSeconds { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public DeleteOptionsKind? Kind { get; set; }

        /// <summary>Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the "orphan" finalizer will be added to/removed from the Object's finalizers list. Either this field or PropagationPolicy may be set, but not both.</summary>
        public Boolean? OrphanDependents { get; set; }

        /// <summary>Must be fulfilled before a deletion is carried out. If not possible, a 409 Conflict status will be returned.</summary>
        public Preconditions Preconditions { get; set; }

        /// <summary>Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: 'Orphan' - orphan the dependents; 'Background' - allow the garbage collector to delete the dependents in the background; 'Foreground' - a cascading policy that deletes all dependents in the foreground.</summary>
        public String PropagationPolicy { get; set; }
    }

    /// <summary>Fields stores a set of fields in a data structure like a Trie. To understand how this is used, see: https://github.com/kubernetes-sigs/structured-merge-diff</summary>
    public partial class Fields
    {

    }

    /// <summary>GroupVersion contains the "group/version" and "version" String of a version. It is made a struct to keep extensibility.</summary>
    public partial class GroupVersionForDiscovery
    {
        /// <summary>groupVersion specifies the API group and version in the form "group/version"</summary>        
        [Required(AllowEmptyStrings = true)]
        public String GroupVersion { get; set; }

        /// <summary>version specifies the version in the form of "version". This is to save the clients the trouble of splitting the GroupVersion.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Version { get; set; }
    }

    /// <summary>Initializer is information about an initializer that has not yet completed.</summary>
    public partial class Initializer
    {
        /// <summary>name of the process that is responsible for initializing this Object.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }
    }

    /// <summary>Initializers tracks the progress of initialization.</summary>
    public partial class Initializers
    {
        /// <summary>Pending is a list of initializers that must execute in order before this Object is visible. When the last pending initializer is removed, and no failing result is set, the initializers struct will be set to nil and the Object is considered as initialized and visible to all clients.</summary>
        [Required]
        public ICollection<Initializer> Pending { get; set; } = new Collection<Initializer>();

        /// <summary>If result is set with the Failure field, the Object will be persisted to storage and then deleted, ensuring that other clients can observe the deletion.</summary>
        public Status Result { get; set; }
    }

    /// <summary>A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.</summary>
    public partial class LabelSelector
    {
        /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
        public ICollection<LabelSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
        public IDictionary<String, String> MatchLabels { get; set; }
    }

    /// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>

    public partial class LabelSelectorRequirement
    {
        /// <summary>key is the label key that the selector applies to.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Key { get; set; }

        /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
        [Required(AllowEmptyStrings = true)]
        public String Operator { get; set; }

        /// <summary>values is an array of String values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
        public ICollection<String> Values { get; set; }
    }

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    public partial class ListMeta
    {
        /// <summary>continue may be set if the user set a limit on the number of items returned, and indicates that the server has more data available. The value is opaque and may be used to issue another request to the endpoint that served this list to retrieve the next set of available objects. Continuing a consistent list may not be possible if the server configuration has changed or more than a few minutes have passed. The resourceVersion field returned when using this continue value will be identical to the value in the first response, unless you have received this token from an error message.</summary>
        public String Continue { get; set; }

        /// <summary>String that identifies the server's internal version of this Object that can be used by clients to determine when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</summary>
        public String ResourceVersion { get; set; }

        /// <summary>selfLink is a URL representing this Object. Populated by the system. Read-only.</summary>        
        public String SelfLink { get; set; }
    }

    /// <summary>ManagedFieldsEntry is a workflow-id, a FieldSet and the group version of the resource that the fieldset applies to.</summary>
    public partial class ManagedFieldsEntry
    {
        /// <summary>APIVersion defines the version of this resource that this field set applies to. The format is "group/version" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.</summary>
        public String ApiVersion { get; set; }

        /// <summary>Fields identifies a set of fields.</summary>        
        public Fields Fields { get; set; }

        /// <summary>Manager is an identifier of the workflow managing these fields.</summary>        
        public String Manager { get; set; }

        /// <summary>Operation is the type of operation which lead to this ManagedFieldsEntry being created. The only valid values for this field are 'Apply' and 'Update'.</summary>        
        public String Operation { get; set; }

        /// <summary>Time is timestamp of when these fields were set. It should always be empty if Operation is 'Apply'</summary>        
        public DateTimeOffset? Time { get; set; }
    }

    /// <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary>
    public partial class ObjectMeta
    {
        /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations</summary>
        public IDictionary<String, String> Annotations { get; set; }

        /// <summary>The name of the cluster which the Object belongs to. This is used to distinguish resources with same name and namespace in different clusters. This field is not set anywhere right now and apiserver is going to ignore it if set in create or update request.</summary>
        public String ClusterName { get; set; }

        /// <summary>CreationTimestamp is a timestamp representing the server time when this Object was created. It is not guaranteed to be set in happens-before order across separate operations. Clients may not set this value. It is represented in RFC3339 form and is in UTC.
        /// <br/>
        /// <br/>Populated by the system. Read-only. Null for lists. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public DateTimeOffset? CreationTimestamp { get; set; }

        /// <summary>Number of seconds allowed for this Object to gracefully terminate before it will be removed from the system. Only set when deletionTimestamp is also set. May only be shortened. Read-only.</summary>
        public long? DeletionGracePeriodSeconds { get; set; }

        /// <summary>DeletionTimestamp is RFC 3339 date and time at which this resource will be deleted. This field is set by the server when a graceful deletion is requested by the user, and is not directly settable by a client. The resource is expected to be deleted (no longer visible from resource lists, and not reachable by name) after the time in this field, once the finalizers list is empty. As long as the finalizers list contains items, deletion is blocked. Once the deletionTimestamp is set, this value may not be unset or be set further into the future, although it may be shortened or the resource may be deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet will react by sending a graceful termination signal to the containers in the pod. After that 30 seconds, the Kubelet will send a hard termination signal (SIGKILL) to the container and after cleanup, remove the pod from the API. In the presence of network partitions, this Object may still exist after this timestamp, until an administrator or automated process can determine the resource is fully terminated. If not set, graceful deletion of the Object has not been requested.
        /// <br/>
        /// <br/>Populated by the system when a graceful deletion is requested. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata</summary>
        public DateTimeOffset? DeletionTimestamp { get; set; }

        /// <summary>Must be empty before the Object is deleted from the registry. Each entry is an identifier for the responsible component that will remove the entry from the list. If the deletionTimestamp of the Object is non-nil, entries in this list can only be removed.</summary>
        public ICollection<String> Finalizers { get; set; }

        /// <summary>GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.
        /// <br/>
        /// <br/>If this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry (optionally after the time indicated in the Retry-After header).
        /// <br/>
        /// <br/>Applied only if Name is not specified. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency</summary>
        public String GenerateName { get; set; }

        /// <summary>A sequence number representing a specific generation of the desired state. Populated by the system. Read-only.</summary>
        public long? Generation { get; set; }

        /// <summary>An initializer is a controller which enforces some system invariant at Object creation time. This field is a list of initializers that have not yet acted on this Object. If nil or empty, this Object has been completely initialized. Otherwise, the Object is considered uninitialized and is hidden (in list/watch and get calls) from clients that haven't explicitly asked to observe uninitialized objects.
        /// <br/>
        /// <br/>When an Object is created, the system will populate this list with the current set of initializers. Only privileged users may set or modify this list. Once it is empty, it may not be modified further by any user.
        /// <br/>
        /// <br/>DEPRECATED - initializers are an alpha field and will be removed in v1.15.</summary>
        public Initializers Initializers { get; set; }

        /// <summary>Map of String keys and values that can be used to organize and categorize (scope and select) objects. May match selectors of replication controllers and services. More info: http://kubernetes.io/docs/user-guide/labels</summary>
        public IDictionary<String, String> Labels { get; set; }

        /// <summary>ManagedFields maps workflow-id and version to the set of fields that are managed by that workflow. This is mostly for internal housekeeping, and users typically shouldn't need to set or understand this field. A workflow can be the user's name, a controller's name, or the name of a specific apply path like "ci-cd". The set of fields is always in the version that the workflow used when modifying the Object.
        /// <br/>
        /// <br/>This field is alpha and can be changed or removed without notice.</summary>
        public ICollection<ManagedFieldsEntry> ManagedFields { get; set; }

        /// <summary>Name must be unique within a namespace. Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        public String Name { get; set; }

        /// <summary>Namespace defines the space within each name must be unique. An empty namespace is equivalent to the "default" namespace, but "default" is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.
        /// <br/>
        /// <br/>Must be a DNS_LABEL. Cannot be updated. More info: http://kubernetes.io/docs/user-guide/namespaces</summary>        
        public String Namespace { get; set; }

        /// <summary>List of objects depended by this Object. If ALL objects in the list have been deleted, this Object will be garbage collected. If this Object is managed by a controller, then an entry in this list will point to this controller, with the controller field set to true. There cannot be more than one managing controller.</summary>
        public ICollection<OwnerReference> OwnerReferences { get; set; }

        /// <summary>An opaque value that represents the internal version of this Object that can be used by clients to determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.
        /// <br/>
        /// <br/>Populated by the system. Read-only. Value must be treated as opaque by clients and . More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency</summary>        
        public String ResourceVersion { get; set; }

        /// <summary>SelfLink is a URL representing this Object. Populated by the system. Read-only.</summary>        
        public String SelfLink { get; set; }

        /// <summary>UID is the unique in time and space value for this Object. It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.
        /// <br/>
        /// <br/>Populated by the system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary>        
        public String Uid { get; set; }
    }

    /// <summary>OwnerReference contains enough information to let you identify an owning Object. An owning Object must be in the same namespace as the dependent, or be cluster-scoped, so there is no namespace field.</summary>
    public partial class OwnerReference
    {
        /// <summary>API version of the referent.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String ApiVersion { get; set; }

        /// <summary>If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot be deleted from the key-value store until this reference is removed. Defaults to false. To set this field, a user needs "delete" permission of the owner, otherwise 422 (Unprocessable Entity) will be returned.</summary>
        public Boolean? BlockOwnerDeletion { get; set; }

        /// <summary>If true, this reference points to the managing controller.</summary>        
        public Boolean? Controller { get; set; }

        /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Kind { get; set; }

        /// <summary>Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Name { get; set; }

        /// <summary>UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Uid { get; set; }
    }

    /// <summary>Preconditions must be fulfilled before an operation (update, delete, etc.) is carried out.</summary>
    public partial class Preconditions
    {
        /// <summary>Specifies the target ResourceVersion</summary>        
        public String ResourceVersion { get; set; }

        /// <summary>Specifies the target UID.</summary>        
        public String Uid { get; set; }
    }

    /// <summary>ServerAddressByClientCIDR helps the client to determine the server address that they should use, depending on the clientCIDR that they match.</summary>
    public partial class ServerAddressByClientCIDR
    {
        /// <summary>The CIDR with which clients can match their IP to figure out the server address that they should use.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String ClientCIDR { get; set; }

        /// <summary>Address of this server, suitable for a client that matches the above CIDR. This can be a hostname, hostname:port, IP or IP:port.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String ServerAddress { get; set; }
    }

    /// <summary>Status is a return value for calls that don't return other objects.</summary>
    public partial class Status
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Suggested HTTP return code for this status, 0 if not set.</summary>
        public int? Code { get; set; }

        /// <summary>Extended data associated with the reason.  Each reason may define its own extended details. This field is optional and the data returned is not guaranteed to conform to any schema except that defined by the reason type.</summary>
        public StatusDetails Details { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>        
        public StatusKind? Kind { get; set; }

        /// <summary>A human-readable description of the status of this operation.</summary>        
        public String Message { get; set; }

        /// <summary>Standard list metadata. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>        
        public ListMeta Metadata { get; set; }

        /// <summary>A machine-readable description of why this operation is in the "Failure" status. If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it.</summary>        
        public String Reason { get; set; }

        /// <summary>Status of the operation. One of: "Success" or "Failure". More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status</summary>        
        public String Status1 { get; set; }
    }

    /// <summary>StatusCause provides more information about an api.Status failure, including cases when multiple errors are encountered.</summary>
    public partial class StatusCause
    {
        /// <summary>The field of the resource that has caused this error, as named by its JSON serialization. May include dot and postfix notation for nested attributes. Arrays are zero-indexed.  Fields may appear more than once in an array of causes due to fields having multiple errors. Optional.
        /// <br/>
        /// <br/>Examples:
        /// <br/>  "name" - the field "name" on the current resource
        /// <br/>  "items[0].name" - the field "name" on the first array entry in "items"</summary>        
        public String Field { get; set; }

        /// <summary>A human-readable description of the cause of the error.  This field may be presented as-is to a reader.</summary>        
        public String Message { get; set; }

        /// <summary>A machine-readable description of the cause of the error. If this value is empty there is no information available.</summary>        
        public String Reason { get; set; }
    }

    /// <summary>StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response. The Reason field of a Status Object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.</summary>
    public partial class StatusDetails
    {
        /// <summary>The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.</summary>        
        public ICollection<StatusCause> Causes { get; set; }

        /// <summary>The group attribute of the resource associated with the status StatusReason.</summary>        
        public String Group { get; set; }

        /// <summary>The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>        
        public String Kind { get; set; }

        /// <summary>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</summary>        
        public String Name { get; set; }

        /// <summary>If specified, the time in seconds before the operation should be retried. Some errors may indicate the client must take an alternate action - for those errors this field may indicate how long to wait before taking the alternate action.</summary>        
        public int? RetryAfterSeconds { get; set; }

        /// <summary>UID of the resource. (when there is a single resource which can be described). More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary>        
        public String Uid { get; set; }
    }

    /// <summary>Event represents a single event to a watched resource.</summary>
    public partial class WatchEvent
    {
        /// <summary>Object is:
        /// <br/> * If Type is Added or Modified: the new state of the Object.
        /// <br/> * If Type is Deleted: the state of the Object immediately before deletion.
        /// <br/> * If Type is Error: *Status is recommended; other types may make sense
        /// <br/>   depending on context.</summary>        
        [Required]
        public RawExtension Object { get; set; } = new RawExtension();
        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>RawExtension is used to hold extensions in external versions.
    /// <br/>
    /// <br/>To use this, make a field which has RawExtension as its type in your external, versioned struct, and Object in your internal struct. You also need to register your various plugin types.
    /// <br/>
    /// <br/>// Internal package: type MyAPIObject struct {
    /// <br/>	runtime.TypeMeta `json:",inline"`
    /// <br/>	MyPlugin runtime.Object `json:"myPlugin"`
    /// <br/>} type PluginA struct {
    /// <br/>	AOption String `json:"aOption"`
    /// <br/>}
    /// <br/>
    /// <br/>// External package: type MyAPIObject struct {
    /// <br/>	runtime.TypeMeta `json:",inline"`
    /// <br/>	MyPlugin runtime.RawExtension `json:"myPlugin"`
    /// <br/>} type PluginA struct {
    /// <br/>	AOption String `json:"aOption"`
    /// <br/>}
    /// <br/>
    /// <br/>// On the wire, the JSON will look something like this: {
    /// <br/>	"kind":"MyAPIObject",
    /// <br/>	"apiVersion":"v1",
    /// <br/>	"myPlugin": {
    /// <br/>		"kind":"PluginA",
    /// <br/>		"aOption":"foo",
    /// <br/>	},
    /// <br/>}
    /// <br/>
    /// <br/>So what happens? Decode first uses json or yaml to unmarshal the serialized data into your external MyAPIObject. That causes the raw JSON to be stored, but not unpacked. The next step is to copy (using pkg/conversion) into the internal struct. The runtime package's DefaultScheme has conversion functions installed which will unpack the JSON stored in RawExtension, turning it into the correct Object type, and storing it in the Object. (TODO: In the case where the Object is of an unknown type, a runtime.Unknown Object will be created and stored.)</summary>
    public partial class RawExtension
    {
        /// <summary>Raw is the underlying serialization of this Object.</summary>        
        [Required(AllowEmptyStrings = true)]
        public byte[] Raw { get; set; }
    }


    /// <summary>Info contains versioning information. how we'll want to distribute that information.</summary>
    public partial class Info
    {        
        [Required(AllowEmptyStrings = true)]
        public String BuildDate { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String Compiler { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String GitCommit { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String GitTreeState { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String GitVersion { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String GoVersion { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String Major { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String Minor { get; set; }
        
        [Required(AllowEmptyStrings = true)]
        public String Platform { get; set; }
    }

    /// <summary>APIService represents a server for a particular GroupVersion. Name must be "version.group".</summary>
    public partial class APIService
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIServiceKind? Kind { get; set; }
                
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec contains information for locating and communicating with a server</summary>        
        public APIServiceSpec Spec { get; set; }

        /// <summary>Status contains derived information about an API server</summary>        
        public APIServiceStatus Status { get; set; }
    }

    /// <summary>APIServiceCondition describes the state of an APIService at a particular point</summary>
    public partial class APIServiceCondition
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human-readable message indicating details about last transition.</summary>        
        public String Message { get; set; }

        /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>        
        public String Reason { get; set; }

        /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type is the type of the condition.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>APIServiceList is a list of APIService objects.</summary>
    public partial class APIServiceList
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        [Required]
        public ICollection<APIService> Items { get; set; } = new Collection<APIService>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIServiceListKind? Kind { get; set; }
        
        public ListMeta Metadata { get; set; }
    }

    /// <summary>APIServiceSpec contains information for locating and communicating with a server. Only https is supported, though you are able to disable certificate verification.</summary>
    public partial class APIServiceSpec
    {
        /// <summary>CABundle is a PEM encoded CA bundle which will be used to validate an API server's serving certificate. If unspecified, system trust roots on the apiserver are used.</summary>
        public byte[] CaBundle { get; set; }

        /// <summary>Group is the API group name this server hosts</summary>
        public String Group { get; set; }

        /// <summary>GroupPriorityMininum is the priority this group should have at least. Higher priority means that the group is preferred by clients over lower priority ones. Note that other versions of this group might specify even higher GroupPriorityMininum values such that the whole group gets a higher priority. The primary sort is based on GroupPriorityMinimum, ordered highest number to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the Object.  (v1.bar before v1.foo) We'd recommend something like: *.k8s.io (except extensions) at 18000 and PaaSes (OpenShift, Deis) are recommended to be in the 2000s</summary>
        public int GroupPriorityMinimum { get; set; }

        /// <summary>InsecureSkipTLSVerify disables TLS certificate verification when communicating with this server. This is strongly discouraged.  You should use the CABundle instead.</summary>
        public Boolean? InsecureSkipTLSVerify { get; set; }

        /// <summary>Service is a reference to the service for this API server.  It must communicate on port 443 If the Service is nil, that means the handling for the API groupversion is handled locally on this server. The call will simply delegate to the normal handler chain to be fulfilled.</summary>
        [Required]
        public ServiceReference4 Service { get; set; } = new ServiceReference4();

        /// <summary>Version is the API version this server hosts.  For example, "v1"</summary>
        public String Version { get; set; }

        /// <summary>VersionPriority controls the ordering of this API version inside of its group.  Must be greater than zero. The primary sort is based on VersionPriority, ordered highest to lowest (20 before 10). Since it's inside of a group, the number can be small, probably in the 10s. In case of equal version priorities, the version String will be used to compute the order inside a group. If the version String is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the String "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.</summary>
        public int VersionPriority { get; set; }
    }

    /// <summary>APIServiceStatus contains derived information about an API server</summary>
    public partial class APIServiceStatus
    {
        /// <summary>Current service state of apiService.</summary>        
        public ICollection<APIServiceCondition> Conditions { get; set; }
    }

    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io</summary>
    public partial class ServiceReference4
    {
        /// <summary>Name is the name of the service</summary>        
        public String Name { get; set; }

        /// <summary>Namespace is the namespace of the service</summary>        
        public String Namespace { get; set; }
    }

    /// <summary>APIService represents a server for a particular GroupVersion. Name must be "version.group".</summary>
    public partial class APIService2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIService2Kind? Kind { get; set; }
        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Spec contains information for locating and communicating with a server</summary>        
        public APIServiceSpec2 Spec { get; set; }

        /// <summary>Status contains derived information about an API server</summary>        
        public APIServiceStatus2 Status { get; set; }
    }

    /// <summary>APIServiceCondition describes the state of an APIService at a particular point</summary>
    public partial class APIServiceCondition2
    {
        /// <summary>Last time the condition transitioned from one status to another.</summary>        
        public DateTimeOffset? LastTransitionTime { get; set; }

        /// <summary>Human-readable message indicating details about last transition.</summary>        
        public String Message { get; set; }

        /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>        
        public String Reason { get; set; }

        /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Status { get; set; }

        /// <summary>Type is the type of the condition.</summary>        
        [Required(AllowEmptyStrings = true)]
        public String Type { get; set; }
    }

    /// <summary>APIServiceList is a list of APIService objects.</summary>
    public partial class APIServiceList2
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public String ApiVersion { get; set; }

        [Required]
        public ICollection<APIService2> Items { get; set; } = new Collection<APIService2>();

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
        public APIServiceList2Kind? Kind { get; set; }

        public ListMeta Metadata { get; set; }
    }

    /// <summary>APIServiceSpec contains information for locating and communicating with a server. Only https is supported, though you are able to disable certificate verification.</summary>

    public partial class APIServiceSpec2
    {
        /// <summary>CABundle is a PEM encoded CA bundle which will be used to validate an API server's serving certificate. If unspecified, system trust roots on the apiserver are used.</summary>
        public byte[] CaBundle { get; set; }

        /// <summary>Group is the API group name this server hosts</summary>
        public String Group { get; set; }

        /// <summary>GroupPriorityMininum is the priority this group should have at least. Higher priority means that the group is preferred by clients over lower priority ones. Note that other versions of this group might specify even higher GroupPriorityMininum values such that the whole group gets a higher priority. The primary sort is based on GroupPriorityMinimum, ordered highest number to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the Object.  (v1.bar before v1.foo) We'd recommend something like: *.k8s.io (except extensions) at 18000 and PaaSes (OpenShift, Deis) are recommended to be in the 2000s</summary>
        public int GroupPriorityMinimum { get; set; }

        /// <summary>InsecureSkipTLSVerify disables TLS certificate verification when communicating with this server. This is strongly discouraged.  You should use the CABundle instead.</summary>
        public Boolean? InsecureSkipTLSVerify { get; set; }

        /// <summary>Service is a reference to the service for this API server.  It must communicate on port 443 If the Service is nil, that means the handling for the API groupversion is handled locally on this server. The call will simply delegate to the normal handler chain to be fulfilled.</summary>
        [Required]
        public ServiceReference5 Service { get; set; } = new ServiceReference5();

        /// <summary>Version is the API version this server hosts.  For example, "v1"</summary>
        public String Version { get; set; }

        /// <summary>VersionPriority controls the ordering of this API version inside of its group.  Must be greater than zero. The primary sort is based on VersionPriority, ordered highest to lowest (20 before 10). Since it's inside of a group, the number can be small, probably in the 10s. In case of equal version priorities, the version String will be used to compute the order inside a group. If the version String is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the String "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.</summary>
        public int VersionPriority { get; set; }
    }

    /// <summary>APIServiceStatus contains derived information about an API server</summary>
    public partial class APIServiceStatus2
    {
        /// <summary>Current service state of apiService.</summary>        
        public ICollection<APIServiceCondition2> Conditions { get; set; }
    }

    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io</summary>
    public partial class ServiceReference5
    {
        /// <summary>Name is the name of the service</summary>        
        public String Name { get; set; }

        /// <summary>Namespace is the namespace of the service</summary>        
        public String Namespace { get; set; }
    }

    /// <summary>Deployment enables declarative updates for Pods and ReplicaSets.</summary>
    public partial class Anonymous
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an Object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
        public ApiVersion? ApiVersion { get; set; }

        /// <summary>Kind is a String value representing the REST resource this Object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>        
        public Kind? Kind { get; set; }

        /// <summary>Standard Object metadata.</summary>        
        public ObjectMeta Metadata { get; set; }

        /// <summary>Specification of the desired behavior of the Deployment.</summary>        
        public DeploymentSpec Spec { get; set; }

        /// <summary>Most recently observed status of the Deployment.</summary>        
        public DeploymentStatus Status { get; set; }
    }

    public enum MutatingWebhookConfigurationKind
    {        
        MutatingWebhookConfiguration = 0
    }

    public enum MutatingWebhookConfigurationListKind
    {        
        MutatingWebhookConfigurationList = 0
    }

    public enum ValidatingWebhookConfigurationKind
    {        
        ValidatingWebhookConfiguration = 0
    }

    public enum ValidatingWebhookConfigurationListKind
    {        
        ValidatingWebhookConfigurationList = 0
    }

    public enum ControllerRevisionKind
    {        
        ControllerRevision = 0
    }

    public enum ControllerRevisionListKind
    {        
        ControllerRevisionList = 0
    }

    public enum DaemonSetKind
    {        
        DaemonSet = 0
    }

    public enum DaemonSetListKind
    {        
        DaemonSetList = 0
    }

    public enum DeploymentKind
    {        
        Deployment = 0
    }

    public enum DeploymentListKind
    {        
        DeploymentList = 0
    }

    public enum ReplicaSetKind
    {        
        ReplicaSet = 0
    }

    public enum ReplicaSetListKind
    {        
        ReplicaSetList = 0
    }

    public enum StatefulSetKind
    {        
        StatefulSet = 0
    }

    public enum StatefulSetListKind
    {        
        StatefulSetList = 0
    }

    public enum ControllerRevision2Kind
    {        
        ControllerRevision = 0
    }

    public enum ControllerRevisionList2Kind
    {        
        ControllerRevisionList = 0
    }

    public enum Deployment2Kind
    {        
        Deployment = 0
    }

    public enum DeploymentList2Kind
    {        
        DeploymentList = 0
    }

    public enum DeploymentRollbackKind
    {        
        DeploymentRollback = 0
    }

    public enum ScaleKind
    {        
        Scale = 0
    }

    public enum StatefulSet2Kind
    {        
        StatefulSet = 0
    }

    public enum StatefulSetList2Kind
    {        
        StatefulSetList = 0
    }

    public enum ControllerRevision3Kind
    {        
        ControllerRevision = 0
    }

    public enum ControllerRevisionList3Kind
    {        
        ControllerRevisionList = 0
    }

    public enum DaemonSet2Kind
    {        
        DaemonSet = 0
    }

    public enum DaemonSetList2Kind
    {        
        DaemonSetList = 0
    }

    public enum Deployment3Kind
    {        
        Deployment = 0
    }

    public enum DeploymentList3Kind
    {        
        DeploymentList = 0
    }

    public enum ReplicaSet2Kind
    {        
        ReplicaSet = 0
    }

    public enum ReplicaSetList2Kind
    {        
        ReplicaSetList = 0
    }

    public enum Scale2Kind
    {        
        Scale = 0
    }

    public enum StatefulSet3Kind
    {        
        StatefulSet = 0
    }

    public enum StatefulSetList3Kind
    {        
        StatefulSetList = 0
    }

    public enum AuditSinkKind
    {        
        AuditSink = 0
    }

    public enum AuditSinkListKind
    {        
        AuditSinkList = 0
    }

    public enum TokenReviewKind
    {        
        TokenReview = 0
    }

    public enum TokenReview2Kind
    {        
        TokenReview = 0
    }

    public enum LocalSubjectAccessReviewKind
    {        
        LocalSubjectAccessReview = 0
    }

    public enum SelfSubjectAccessReviewKind
    {        
        SelfSubjectAccessReview = 0
    }

    public enum SelfSubjectRulesReviewKind
    {        
        SelfSubjectRulesReview = 0
    }

    public enum SubjectAccessReviewKind
    {        
        SubjectAccessReview = 0
    }

    public enum LocalSubjectAccessReview2Kind
    {        
        LocalSubjectAccessReview = 0
    }

    public enum SelfSubjectAccessReview2Kind
    {        
        SelfSubjectAccessReview = 0
    }

    public enum SelfSubjectRulesReview2Kind
    {        
        SelfSubjectRulesReview = 0
    }

    public enum SubjectAccessReview2Kind
    {        
        SubjectAccessReview = 0
    }

    public enum HorizontalPodAutoscalerKind
    {        
        HorizontalPodAutoscaler = 0
    }

    public enum HorizontalPodAutoscalerListKind
    {        
        HorizontalPodAutoscalerList = 0
    }

    public enum Scale3Kind
    {        
        Scale = 0
    }

    public enum HorizontalPodAutoscaler2Kind
    {        
        HorizontalPodAutoscaler = 0
    }

    public enum HorizontalPodAutoscalerList2Kind
    {        
        HorizontalPodAutoscalerList = 0
    }

    public enum HorizontalPodAutoscaler3Kind
    {        
        HorizontalPodAutoscaler = 0
    }

    public enum HorizontalPodAutoscalerList3Kind
    {        
        HorizontalPodAutoscalerList = 0
    }

    public enum JobKind
    {        
        Job = 0
    }

    public enum JobListKind
    {        
        JobList = 0
    }

    public enum CronJobKind
    {        
        CronJob = 0
    }

    public enum CronJobListKind
    {        
        CronJobList = 0
    }

    public enum CronJob2Kind
    {        
        CronJob = 0
    }

    public enum CronJobList2Kind
    {        
        CronJobList = 0
    }

    public enum CertificateSigningRequestKind
    {        
        CertificateSigningRequest = 0
    }

    public enum CertificateSigningRequestListKind
    {        
        CertificateSigningRequestList = 0
    }

    public enum LeaseKind
    {        
        Lease = 0
    }

    public enum LeaseListKind
    {        
        LeaseList = 0
    }

    public enum Lease2Kind
    {        
        Lease = 0
    }

    public enum LeaseList2Kind
    {        
        LeaseList = 0
    }

    public enum BindingKind
    {        
        Binding = 0
    }

    public enum ComponentStatusKind
    {        
        ComponentStatus = 0
    }

    public enum ComponentStatusListKind
    {        
        ComponentStatusList = 0
    }

    public enum ConfigMapKind
    {        
        ConfigMap = 0
    }

    public enum ConfigMapListKind
    {        
        ConfigMapList = 0
    }

    public enum EndpointsKind
    {        
        Endpoints = 0
    }

    public enum EndpointsListKind
    {        
        EndpointsList = 0
    }

    public enum EventKind
    {        
        Event = 0
    }

    public enum EventListKind
    {        
        EventList = 0
    }

    public enum LimitRangeKind
    {        
        LimitRange = 0
    }

    public enum LimitRangeListKind
    {        
        LimitRangeList = 0
    }

    public enum NamespaceKind
    {        
        Namespace = 0
    }

    public enum NamespaceListKind
    {        
        NamespaceList = 0
    }

    public enum NodeKind
    {        
        Node = 0
    }

    public enum NodeListKind
    {        
        NodeList = 0
    }

    public enum PersistentVolumeKind
    {        
        PersistentVolume = 0
    }

    public enum PersistentVolumeClaimKind
    {        
        PersistentVolumeClaim = 0
    }

    public enum PersistentVolumeClaimListKind
    {        
        PersistentVolumeClaimList = 0
    }

    public enum PersistentVolumeListKind
    {        
        PersistentVolumeList = 0
    }

    public enum PodKind
    {        
        Pod = 0
    }

    public enum PodListKind
    {        
        PodList = 0
    }

    public enum PodTemplateKind
    {        
        PodTemplate = 0
    }

    public enum PodTemplateListKind
    {        
        PodTemplateList = 0
    }

    public enum ReplicationControllerKind
    {        
        ReplicationController = 0
    }

    public enum ReplicationControllerListKind
    {        
        ReplicationControllerList = 0
    }

    public enum ResourceQuotaKind
    {        
        ResourceQuota = 0
    }

    public enum ResourceQuotaListKind
    {        
        ResourceQuotaList = 0
    }

    public enum SecretKind
    {        
        Secret = 0
    }

    public enum SecretListKind
    {        
        SecretList = 0
    }

    public enum ServiceKind
    {        
        Service = 0
    }

    public enum ServiceAccountKind
    {        
        ServiceAccount = 0
    }

    public enum ServiceAccountListKind
    {        
        ServiceAccountList = 0
    }

    public enum ServiceListKind
    {        
        ServiceList = 0
    }

    public enum Event2Kind
    {        
        Event = 0
    }

    public enum EventList2Kind
    {        
        EventList = 0
    }

    public enum DaemonSet3Kind
    {        
        DaemonSet = 0
    }

    public enum DaemonSetList3Kind
    {        
        DaemonSetList = 0
    }

    public enum Deployment4Kind
    {        
        Deployment = 0
    }

    public enum DeploymentList4Kind
    {        
        DeploymentList = 0
    }

    public enum DeploymentRollback2Kind
    {        
        DeploymentRollback = 0
    }

    public enum IngressKind
    {        
        Ingress = 0
    }

    public enum IngressListKind
    {        
        IngressList = 0
    }

    public enum NetworkPolicyKind
    {        
        NetworkPolicy = 0
    }

    public enum NetworkPolicyListKind
    {        
        NetworkPolicyList = 0
    }

    public enum PodSecurityPolicyKind
    {        
        PodSecurityPolicy = 0
    }

    public enum PodSecurityPolicyListKind
    {        
        PodSecurityPolicyList = 0
    }

    public enum ReplicaSet3Kind
    {        
        ReplicaSet = 0
    }

    public enum ReplicaSetList3Kind
    {        
        ReplicaSetList = 0
    }

    public enum Scale4Kind
    {        
        Scale = 0
    }

    public enum NetworkPolicy2Kind
    {        
        NetworkPolicy = 0
    }

    public enum NetworkPolicyList2Kind
    {        
        NetworkPolicyList = 0
    }

    public enum Ingress2Kind
    {        
        Ingress = 0
    }

    public enum IngressList2Kind
    {        
        IngressList = 0
    }

    public enum RuntimeClassKind
    {        
        RuntimeClass = 0
    }

    public enum RuntimeClassListKind
    {        
        RuntimeClassList = 0
    }

    public enum RuntimeClass2Kind
    {        
        RuntimeClass = 0
    }

    public enum RuntimeClassList2Kind
    {        
        RuntimeClassList = 0
    }

    public enum EvictionKind
    {        
        Eviction = 0
    }

    public enum PodDisruptionBudgetKind
    {        
        PodDisruptionBudget = 0
    }

    public enum PodDisruptionBudgetListKind
    {        
        PodDisruptionBudgetList = 0
    }

    public enum PodSecurityPolicy2Kind
    {
        PodSecurityPolicy = 0
    }

    public enum PodSecurityPolicyList2Kind
    {        
        PodSecurityPolicyList = 0
    }

    public enum ClusterRoleKind
    {        
        ClusterRole = 0
    }

    public enum ClusterRoleBindingKind
    {        
        ClusterRoleBinding = 0
    }

    public enum ClusterRoleBindingListKind
    {        
        ClusterRoleBindingList = 0
    }

    public enum ClusterRoleListKind
    {        
        ClusterRoleList = 0
    }

    public enum RoleKind
    {        
        Role = 0
    }

    public enum RoleBindingKind
    {        
        RoleBinding = 0
    }

    public enum RoleBindingListKind
    {        
        RoleBindingList = 0
    }

    public enum RoleListKind
    {        
        RoleList = 0
    }

    public enum ClusterRole2Kind
    {        
        ClusterRole = 0
    }

    public enum ClusterRoleBinding2Kind
    {        
        ClusterRoleBinding = 0
    }

    public enum ClusterRoleBindingList2Kind
    {        
        ClusterRoleBindingList = 0
    }

    public enum ClusterRoleList2Kind
    {        
        ClusterRoleList = 0
    }

    public enum Role2Kind
    {        
        Role = 0
    }

    public enum RoleBinding2Kind
    {        
        RoleBinding = 0
    }

    public enum RoleBindingList2Kind
    {        
        RoleBindingList = 0
    }

    public enum RoleList2Kind
    {        
        RoleList = 0
    }

    public enum ClusterRole3Kind
    {        
        ClusterRole = 0
    }

    public enum ClusterRoleBinding3Kind
    {        
        ClusterRoleBinding = 0
    }

    public enum ClusterRoleBindingList3Kind
    {        
        ClusterRoleBindingList = 0
    }

    public enum ClusterRoleList3Kind
    {        
        ClusterRoleList = 0
    }

    public enum Role3Kind
    {        
        Role = 0
    }

    public enum RoleBinding3Kind
    {        
        RoleBinding = 0
    }

    public enum RoleBindingList3Kind
    {        
        RoleBindingList = 0
    }

    public enum RoleList3Kind
    {        
        RoleList = 0
    }

    public enum PriorityClassKind
    {        
        PriorityClass = 0
    }

    public enum PriorityClassListKind
    {        
        PriorityClassList = 0
    }

    public enum PriorityClass2Kind
    {        
        PriorityClass = 0
    }

    public enum PriorityClassList2Kind
    {        
        PriorityClassList = 0
    }

    public enum PriorityClass3Kind
    {        
        PriorityClass = 0
    }

    public enum PriorityClassList3Kind
    {        
        PriorityClassList = 0
    }

    public enum PodPresetKind
    {        
        PodPreset = 0
    }

    public enum PodPresetListKind
    {        
        PodPresetList = 0
    }

    public enum StorageClassKind
    {        
        StorageClass = 0
    }

    public enum StorageClassListKind
    {        
        StorageClassList = 0
    }

    public enum VolumeAttachmentKind
    {        
        VolumeAttachment = 0
    }

    public enum VolumeAttachmentListKind
    {
        VolumeAttachmentList = 0
    }

    public enum VolumeAttachment2Kind
    {        
        VolumeAttachment = 0
    }

    public enum VolumeAttachmentList2Kind
    {        
        VolumeAttachmentList = 0
    }

    public enum CSIDriverKind
    {        
        CSIDriver = 0
    }

    public enum CSIDriverListKind
    {        
        CSIDriverList = 0
    }

    public enum CSINodeKind
    {        
        CSINode = 0
    }

    public enum CSINodeListKind
    {        
        CSINodeList = 0
    }

    public enum StorageClass2Kind
    {        
        StorageClass = 0
    }

    public enum StorageClassList2Kind
    {        
        StorageClassList = 0
    }

    public enum VolumeAttachment3Kind
    {        
        VolumeAttachment = 0
    }

    public enum VolumeAttachmentList3Kind
    {        
        VolumeAttachmentList = 0
    }

    public enum CustomResourceDefinitionKind
    {        
        CustomResourceDefinition = 0
    }

    public enum CustomResourceDefinitionListKind
    {        
        CustomResourceDefinitionList = 0
    }

    public enum APIGroupKind
    {        
        APIGroup = 0
    }

    public enum APIGroupListKind
    {        
        APIGroupList = 0
    }

    public enum APIResourceListKind
    {        
        APIResourceList = 0
    }

    public enum APIVersionsKind
    {        
        APIVersions = 0
    }

    public enum DeleteOptionsKind
    {        
        DeleteOptions = 0
    }

    public enum StatusKind
    {        
        Status = 0
    }

    public enum APIServiceKind
    {        
        APIService = 0
    }

    public enum APIServiceListKind
    {        
        APIServiceList = 0
    }

    public enum APIService2Kind
    {        
        APIService = 0
    }

    public enum APIServiceList2Kind
    {        
        APIServiceList = 0
    }

    public enum ApiVersion
    {
        Apps_v1 = 0
    }

    public enum Kind
    {        
        Deployment = 0
    }
}
