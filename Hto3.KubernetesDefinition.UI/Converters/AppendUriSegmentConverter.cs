using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Hto3.KubernetesDefinition.UI.Converters
{
    [ValueConversion(typeof(String), typeof(Uri))]
    public class AppendUriSegmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return new Uri($"{parameter?.ToString().TrimEnd('/')}/{value}");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var uri = value as Uri;
            var startIndex = parameter?.ToString().Length ?? 0;
            return uri?.OriginalString.Substring(startIndex + 1);
        }
    }
}
