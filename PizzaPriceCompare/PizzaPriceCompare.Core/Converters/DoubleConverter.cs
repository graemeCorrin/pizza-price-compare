using System;
using System.Globalization;
using Xamarin.Forms;

namespace PizzaPriceCompare.Core.Converters
{
    public class DoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var nullable = value as double?;
            var result = string.Empty;

            if (nullable.HasValue)
            {
                result = nullable.Value.ToString();
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = value as string;
            double doubleValue;
            double? result = null;

            if (double.TryParse(stringValue, out doubleValue))
            {
                result = doubleValue;
            }

            return result;
        }
    }
}
