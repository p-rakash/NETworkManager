using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace NETworkManager.Converters
{
    public sealed class GridLengthToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
                        if (value is not GridLength length)

                return 99;

            return length.Value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
