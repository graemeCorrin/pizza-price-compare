using System;
using System.Globalization;

namespace PizzaPriceCompare.Core.Converters
{
    public class DoubleToCurrencyConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return string.Format("{0:C2}.", (double)value);
            return "yo";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new System.NotImplementedException();
            return 5.5;
        }
    }
}
