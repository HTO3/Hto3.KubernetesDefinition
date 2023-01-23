using Hto3.KubernetesDefinition.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common
{
    public interface IObjectMetadataUI : IObjectMetadata
    {
        /// <summary>
        /// The MvxNavigation route path to reach the visualization. 
        /// </summary>
        String EditorPath { get; }
        /// <summary>
        /// The SVG icon name.
        /// </summary>
        String IconName { get; }
        /// <summary>
        /// The specialized type of the ObjectManager View Model, aka Canvas icon ViewModel.
        /// </summary>
        Type ManagerType { get; }
    }
}
