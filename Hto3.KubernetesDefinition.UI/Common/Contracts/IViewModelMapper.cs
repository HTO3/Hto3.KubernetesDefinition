using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.Common.Contracts
{
    public interface IViewModelMapper<From, To> : IViewModelMapper
        where From : class
        where To : class
    {
        From ConvertBack(To source);

        void Fill(From source, To target);
    }

    public interface IViewModelMapper
    {
        Object ConvertBack(Object source);

        void Fill(Object source, Object target);
    }
}
