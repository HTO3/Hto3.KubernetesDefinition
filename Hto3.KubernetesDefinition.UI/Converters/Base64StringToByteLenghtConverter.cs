using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Hto3.KubernetesDefinition.UI.Converters
{
    [ValueConversion(typeof(String), typeof(Int32))]
    public class Base64StringToByteLenghtConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var base64String = value as String;
            if (base64String == null)
                return 0;

            return base64String.Length / 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
