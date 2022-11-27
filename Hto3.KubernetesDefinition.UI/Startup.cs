using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI
{
    public class Startup : MvxWpfSetup<DependencyInjection>
    {
        protected override ILoggerFactory CreateLogFactory()
        {
            return null;
        }

        protected override ILoggerProvider CreateLogProvider()
        {
            return null;
        }
    }
}
