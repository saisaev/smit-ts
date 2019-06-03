using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SmitDemo
{
    public class PositionToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            try {
                var productPosX = (double)values[0];
                var productPosY = (double)values[1];
                var productLenght = (double)values[2];
                var productWidth = (double)values[3];
                var machineLength = double.Parse((string)values[4], CultureInfo.InvariantCulture);
                var machineWidth = double.Parse((string)values[5], CultureInfo.InvariantCulture);

                if (productPosX < 0) {
                    return Visibility.Hidden;
                }

                if (productPosY < 0) {
                    return Visibility.Hidden;
                }

                if (productPosX + productLenght >= machineLength) {
                    return Visibility.Hidden;
                }

                if (productPosY + productWidth >= machineWidth) {
                    return Visibility.Hidden;
                }

                return Visibility.Visible;
            }
            catch (Exception) {
                return Visibility.Visible;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
