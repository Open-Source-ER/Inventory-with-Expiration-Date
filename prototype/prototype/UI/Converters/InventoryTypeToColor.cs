using prototype.Enumerations;
using System;
using System.Globalization;
using Xamarin.Forms;

namespace prototype.UI.Converters
{
    public class InventoryTypeToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = (EInvenoryType)value;
            Color color;
            switch (type)
            {
                case EInvenoryType.Water:
                    color = Color.BlueViolet;
                    break;
                case EInvenoryType.Food:
                    color = Color.LightSalmon;
                    break;
                case EInvenoryType.Electricity:
                    color = Color.YellowGreen;
                    break;
                case EInvenoryType.Other:
                    color = Color.Green;
                    break;
                default:
                    color = Color.Green;
                    break;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
