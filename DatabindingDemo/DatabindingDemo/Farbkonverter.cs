using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DatabindingDemo
{
    class Farbkonverter : IValueConverter
    {
        // Nur OneWayBinding
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string color = (string)value;

            if (color == null)
                return Color.Black;

            var fields = typeof(Color).GetFields();
            var outputColor = fields.FirstOrDefault(x => x.Name.ToString().ToLower() == color.ToLower());
            return outputColor?.GetValue(typeof(Color)) ?? Color.Black;
        }

        // Pflicht bei TwoWayBinding und OneWayToSource, ansonsten "weglassen"
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
