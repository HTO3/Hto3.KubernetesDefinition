using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.Common.Models;
using Hto3.KubernetesDefinition.UI.ViewModels;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class ServiceViewModelMapper : IViewModelMapper<Service, ServiceViewModel>
    {
        public Service ConvertBack(ServiceViewModel source)
        {
            var service = new Service();
            service.ApiVersion = "v1";
            service.Kind = ServiceKind.Service;
            service.Metadata = new ObjectMeta();
            service.Metadata.Name = source.Name;
            service.Metadata.Namespace = source.Namespace;
            service.Spec = new ServiceSpec();
            service.Spec.Type = source.Type;
            if (source.TrafficPolicy != Models.ExternalTrafficPolicy.Cluster)
                service.Spec.ExternalTrafficPolicy = source.TrafficPolicy.ToString();
            service.Spec.Selector = source.Selector.ToDictionary(s => s.Item1, s => s.Item2);
            service.Spec.Ports = source.ServicePorts
                .Select(p => new ServicePort()
                {
                    Name = p.Name,
                    Port = p.ExposedPort,
                    Protocol = p.Protocol,
                    TargetPort = p.InternalPort
                })
                .ToList();
            return service;
        }

        public void Fill(Service source, ServiceViewModel target)
        {
            target.Name = source.Metadata?.Name;
            target.Namespace = source.Metadata?.Namespace;
            target.Type = source.Spec?.Type ?? "ClusterIP";
            target.TrafficPolicy =
                source.Spec?.ExternalTrafficPolicy == null
                    ?
                Models.ExternalTrafficPolicy.Cluster
                    :
                (Models.ExternalTrafficPolicy)Enum.Parse(typeof(Models.ExternalTrafficPolicy), source.Spec.ExternalTrafficPolicy);

            target.Selector.Clear();
            target.Selector.AddRange
                (
                    source.Spec?.Selector
                        .EmptyIfNull()
                        .Select(x => new Tuple<String, String>(x.Key, x.Value))
                );
            target.ServicePorts.Clear();
            target.ServicePorts.AddRange
                (
                    source.Spec?.Ports
                        .EmptyIfNull()
                        .Select(x => new ServicePortSetup(x.Name, x.Port, x.TargetPort, x.Protocol))
                );
        }

        public Object ConvertBack(Object source) => ConvertBack((ServiceViewModel)source);

        public void Fill(Object source, Object target) => Fill((Service)source, (ServiceViewModel)target);
    }
}
