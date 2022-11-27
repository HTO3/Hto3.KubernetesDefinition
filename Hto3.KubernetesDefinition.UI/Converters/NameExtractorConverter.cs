using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Hto3.KubernetesDefinition.UI.Converters
{
    [ValueConversion(typeof(Object), typeof(String))]
    public class NameExtractorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            var nameProperty = value.GetType().GetProperty("Name");
            if (nameProperty != null)
                return nameProperty.GetValue(value, null);

            var metadataProperty = value.GetType().GetProperty("Metadata");
            if (metadataProperty == null)
                return null;

            var metadata = metadataProperty.GetValue(value, null);
            if (metadata == null)
                return null;

            nameProperty = metadata.GetType().GetProperty("Name");
            if (nameProperty != null)
                return nameProperty.GetValue(metadata, null);

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
