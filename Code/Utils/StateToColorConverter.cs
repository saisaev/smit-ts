using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SmitDemo
{
    public class StateToColorConverter : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, CultureInfo culture) {
            try {
                var state = (ProductState)values;
                switch (state) {
                    case ProductState.Undefined:
                        return ProductStateColor.Undefined;
                    case ProductState.NotActive:
                        return ProductStateColor.NotActive;
                    case ProductState.ProductOK:
                        return ProductStateColor.ProductOK;
                    case ProductState.ProductRejected:
                        return ProductStateColor.ProductRejected;
                }
                return ProductStateColor.Undefined;
            }
            catch (Exception) {
                return ProductStateColor.Undefined;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
