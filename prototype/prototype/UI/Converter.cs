using System;
using System.Globalization;
using Xamarin.Forms;

namespace prototype.UI
{
    public class ItemTappedEventArgsConverter : IValueConverter
    {
        /// <inheritdoc />
        /// <summary>
        /// Converts binds of the ItemTapped event of the ListView to a Command which takes as parameter the BindingContext of the tapped item.
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ItemTappedEventArgs eventArgs))
                throw new ArgumentException($"Expected TappedEventArgs as {value}");

            return eventArgs.Item;
        }

        /// <inheritdoc />
        /// <summary>
        /// Not implemented method
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
