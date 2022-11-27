using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Hto3.KubernetesDefinition.UI.Converters
{
    [ValueConversion(typeof(Double), typeof(Double))]
    public class NumberAddConverter : IValueConverter
    {
        private static CultureInfo cSharpDefaultCulture = new CultureInfo("en-US");

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {            
            return System.Convert.ToDouble(value, cSharpDefaultCulture) + System.Convert.ToDouble(parameter, cSharpDefaultCulture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDouble(value, cSharpDefaultCulture) + (System.Convert.ToDouble(parameter, cSharpDefaultCulture) * -1);
        }
    }
}
