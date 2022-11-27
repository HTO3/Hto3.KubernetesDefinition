using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Hto3.EnumHelpers;

namespace Hto3.KubernetesDefinition.UI.Converters
{
    [ValueConversion(typeof(Object), typeof(IReadOnlyDictionary<Object, String>))]
    public class EnumToDictionaryOptionsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Hto3.EnumHelpers.EnumHelpers.GetMembers(value.GetType());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
