using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Fluent.Controls
{
    internal class ViewIsGridViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Returns true if value is a GridView, otherwise false
            return value is GridView;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}