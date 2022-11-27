using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Hto3.KubernetesDefinition.UI.Converters
{
    [ValueConversion(typeof(Enum), typeof(Boolean))]
    public class EnumToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null || !(parameter is String))
                return false;

            var targetEnum = Enum.Parse(value.GetType(), (String)parameter);
            return value.Equals(targetEnum);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null || !(parameter is String))
                return Activator.CreateInstance(targetType);

            if (System.Convert.ToBoolean(value))
                return Enum.Parse(targetType, (String)parameter);

            return Activator.CreateInstance(targetType);
        }
    }
}
