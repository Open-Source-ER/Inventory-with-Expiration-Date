using System;
using System.Globalization;
using Xamarin.Forms;

namespace prototype.UI.Converters
{
    public class ItemTappedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ItemTappedEventArgs eventArgs))
                throw new ArgumentException($"value should be TappedEventArgs");

            return eventArgs.Item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
