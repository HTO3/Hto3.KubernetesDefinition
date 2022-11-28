using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.UI.Common;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class EmptyDirViewModel : MvxViewModel, IClearableViewModel
    {
        public EmptyDirViewModel()
        {
            this.SizeLimitSize = MemorySize.G;
        }

        public void Clear()
        {
            this.SizeLimit = null;
            this.SizeLimitSize = MemorySize.G;
            this.MediumType = Medium.Default;
        }

        public Medium MediumType { get; set; }
        public Decimal? SizeLimit { get; set; }
        public MemorySize SizeLimitSize { get; set; }
    }
}
