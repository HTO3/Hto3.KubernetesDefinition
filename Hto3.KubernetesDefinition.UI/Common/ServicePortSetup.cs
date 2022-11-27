using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public class ServicePortSetup
    {
        public ServicePortSetup(String name, Int32 exposedPort, String internalPort, String protocol)
        {
            this.Name = name;
            this.ExposedPort = exposedPort;
            this.InternalPort = internalPort;
            this.Protocol = protocol;
        }

        public String Name { get; }
        public Int32 ExposedPort { get; }
        public String InternalPort { get; }
        public String Protocol { get; }
    }
}
