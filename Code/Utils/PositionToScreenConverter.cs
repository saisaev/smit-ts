using System;
using System.Globalization;
using System.Windows.Data;

namespace SmitDemo
{
    public class PositionToScreenConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            try {
                var screenSize = (double)values[0];
                var machinePos = (double)values[1];
                var machineSize = double.Parse((string)values[2], CultureInfo.InvariantCulture);
                var screenPos = machinePos / machineSize * screenSize;
                return screenPos;
            }
            catch(Exception) {
                return 1.0;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) 
            => throw new NotImplementedException();
    }
}
