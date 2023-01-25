using Hto3.CollectionHelpers;
using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.KubernetesObjects;
using Hto3.KubernetesDefinition.UI.Common.Contracts;
using Hto3.KubernetesDefinition.UI.ViewModels;
using Hto3.StringHelpers;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ObjectMappers
{
    public class ContainerViewModelMapper : IViewModelMapper<Container, ContainerViewModel>
    {
        public Container ConvertBack(ContainerViewModel source)
        {
            var container = new Container();
            container.Image = source.ImageName;
            container.Name = source.Name;

            var resources = new ResourceRequirements()
            {
                Limits = new Dictionary<String, String>(),
                Requests = new Dictionary<String, String>()
            };
            
            var change = new[]
            {
                new { shouldInclude = source.CpuLimit.HasValue, name = "cpu", resourceRequierements = resources.Limits, value = $"{(source.CpuLimit * 10)}m" },
                new { shouldInclude = source.MemoryLimit.HasValue, name = "memory", resourceRequierements = resources.Limits, value = $"{source.MemoryLimit}{source.MemoryLimitSize}".TrimEnd('b') },
                new { shouldInclude = source.CpuRequest.HasValue, name = "cpu", resourceRequierements = resources.Requests, value = $"{(source.CpuRequest * 10)}m" },
                new { shouldInclude = source.MemoryRequest.HasValue, name = "memory", resourceRequierements = resources.Requests, value = $"{source.MemoryRequest}{source.MemoryRequestSize}".TrimEnd('b') }
            };
            
            change = change
                .Where(c => c.shouldInclude)
                .ToArray();
            
            foreach (var resourceChange in change)
            {
                if (resourceChange.resourceRequierements.ContainsKey(resourceChange.name))
                    resourceChange.resourceRequierements[resourceChange.name] = resourceChange.value;
                else
                    resourceChange.resourceRequierements.Add(resourceChange.name, resourceChange.value);
            }
            
            if (!resources.Requests.Any())
                resources.Requests = null;
            if (!resources.Limits.Any())
                resources.Limits = null;

            if (resources.Requests == null && resources.Limits == null)
                container.Resources = null;
            else
                container.Resources = resources;

            if (source.ExposedPorts.Any())
                container.Ports = source.ExposedPorts.Select(p => new ContainerNetworkExpose() { ContainerPort = p.Item1, Protocol = p.Item2 }).ToList();
            else
                container.Ports = null;

            if (source.VolumeMounts.Any())
                container.VolumeMounts = source.VolumeMounts.Select(p => new VolumeMount() { Name = p.Item1, MountPath = p.Item2, ReadOnly = p.Item3 }).ToList();
            else
                container.VolumeMounts = null;

            if (source.EnvironmentVariables.Any())
                container.Env = source.EnvironmentVariables.Select(p => new EnvVar() { Name = p.Item1, Value = p.Item2 }).ToList();
            else
                container.Env = null;

            var probeSetter = new Action<ProbeViewModel, Probe>((probeViewModel, probe) =>
            {
                if (probeViewModel.ByHttpRequest)
                {
                    probe.HttpGet = new HTTPGetAction();
                    probe.HttpGet.Path = probeViewModel.RequestUrl;
                    probe.HttpGet.Port = probeViewModel.RequestPort.ToString();
                    if (probeViewModel.CustomHeaders.Any())
                        probe.HttpGet.HttpHeaders = probeViewModel.CustomHeaders.Select(c => new HTTPHeader() { Name = c.Item1, Value = c.Item2 }).ToList();
                }
                else if (probeViewModel.ByTcpSocket)
                {
                    probe.TcpSocket = new TCPSocketAction();
                    probe.TcpSocket.Port = probeViewModel.TCPSocketPort.ToString();
                }
                else if (probeViewModel.ByCommand)
                {
                    probe.Exec = new ExecAction();
                    probe.Exec.Command = new List<String>(probeViewModel.Commands);
                }

                probe.FailureThreshold = probeViewModel.FailureThreshold;
                probe.InitialDelaySeconds = probeViewModel.InitialDelay;
                probe.TimeoutSeconds = probeViewModel.Timeout;
                probe.PeriodSeconds = probeViewModel.Interval;
                probe.SuccessThreshold = probeViewModel.SucessThreshold;
            });

            if (source.LivenessProbeDesired)
            {
                container.LivenessProbe = new Probe();
                probeSetter(source.LivenessProbe, container.LivenessProbe);
            }
            if (source.ReadinessProbeDesired)
            {
                container.ReadinessProbe = new Probe();
                probeSetter(source.ReadinessProbe, container.ReadinessProbe);
            }

            return container;
        }

        public void Fill(Container source, ContainerViewModel target)
        {
            target.ImageName = source.Image;
            target.Name = source.Name;

            target.CpuLimit = source.Resources?.Limits?.ContainsKey("cpu") == true ? Math.Round(Decimal.Parse(source.Resources.Limits["cpu"].NumbersOnly()) / 10) : (Decimal?)null;
            target.CpuRequest = source.Resources?.Requests?.ContainsKey("cpu") == true ? Math.Round(Decimal.Parse(source.Resources.Requests["cpu"].NumbersOnly()) / 10) : (Decimal?)null;

            if (source.Resources?.Limits?.ContainsKey("memory") == true)
            {
                var memoryRaw = source.Resources.Limits["memory"];
                var memoryNumbersOnly = memoryRaw.NumbersOnly();
                var memoryLettersOnly = memoryRaw.LettersOnly();

                if (String.IsNullOrEmpty(memoryLettersOnly))
                    target.MemoryLimitSize = MemorySize.b;
                else
                    target.MemoryLimitSize = (MemorySize)Enum.Parse(typeof(MemorySize), memoryLettersOnly);

                target.MemoryLimit = Decimal.Parse(memoryNumbersOnly);
            }
            else
                target.MemoryLimit = null;

            if (source.Resources?.Requests?.ContainsKey("memory") == true)
            {
                var memoryRaw = source.Resources.Requests["memory"];
                var memoryNumbersOnly = memoryRaw.NumbersOnly();
                var memoryLettersOnly = memoryRaw.LettersOnly();

                if (String.IsNullOrEmpty(memoryLettersOnly))
                    target.MemoryRequestSize = MemorySize.b;
                else
                    target.MemoryRequestSize = (MemorySize)Enum.Parse(typeof(MemorySize), memoryLettersOnly);

                target.MemoryRequest = Decimal.Parse(memoryNumbersOnly);
            }
            else
                target.MemoryRequest = null;

            target.ExposedPorts.Clear();
            target.ExposedPorts.AddRange
                (
                    source.Ports
                        .EmptyIfNull()
                        .Select(p => new Tuple<Int32, String>(p.ContainerPort, String.IsNullOrEmpty(p.Protocol) ? "TCP" : p.Protocol))
                );

            target.EnvironmentVariables.Clear();
            target.EnvironmentVariables.AddRange
                (
                    source.Env
                        .EmptyIfNull()
                        .Select(p => new Tuple<String, String>(p.Name, p.Value))
                );

            target.VolumeMounts.Clear();
            target.VolumeMounts.AddRange
                (
                    source.VolumeMounts
                        .EmptyIfNull()
                        .Select(p => new Tuple<String, String, Boolean>(p.Name, p.MountPath, p.ReadOnly == true))
                );

            var probeSetter = new Func<Probe, ProbeViewModel, Boolean>((probe, probeViewModel) =>
            {
                probeViewModel.Clear();
                
                probeViewModel.FailureThreshold = probe?.FailureThreshold ?? 3;
                probeViewModel.InitialDelay = probe?.InitialDelaySeconds ?? 0;
                probeViewModel.Timeout = probe?.TimeoutSeconds ?? 1;
                probeViewModel.Interval = probe?.PeriodSeconds ?? 10;
                probeViewModel.SucessThreshold = probe?.SuccessThreshold ?? 1;

                if (probe == null)
                    return false;

                if (probe.HttpGet != null)
                {
                    probeViewModel.ByHttpRequest = true;
                    probeViewModel.RequestUrl = probe.HttpGet.Path;
                    probeViewModel.RequestPort = Int32.Parse(probe.HttpGet.Port);
                    probeViewModel.CustomHeaders.AddRange
                        (
                            probe.HttpGet.HttpHeaders
                                .EmptyIfNull()
                                .Select(h => new Tuple<string, string>(h.Name, h.Value))
                        );
                }
                else if (probe.TcpSocket != null)
                {
                    probeViewModel.ByTcpSocket = true;
                    probeViewModel.TCPSocketPort = Int32.Parse(probe.TcpSocket.Port);
                }
                else if (probe.Exec != null)
                {
                    probeViewModel.ByCommand = true;
                    probeViewModel.Commands.AddRange(probe.Exec.Command.EmptyIfNull());
                }

                return true;
            });

            target.LivenessProbeDesired = probeSetter(source.LivenessProbe, target.LivenessProbe);
            target.ReadinessProbeDesired = probeSetter(source.ReadinessProbe, target.ReadinessProbe);
        }

        public Object ConvertBack(Object source) => ConvertBack((ContainerViewModel)source);
        public void Fill(Object source, Object target) => Fill((Container)source, (ContainerViewModel)target);
    }
}
