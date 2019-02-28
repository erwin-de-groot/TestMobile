using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TestMobile.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        // The DependencyService retrieves the platform specific implementation of an interface.
        private IColors PlatformColors = DependencyService.Get<IColors>();

        public BoolToColorConverter()
        {
        }
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            if (value is bool)
            {
                if ((bool)value)
                    return PlatformColors.TrueStateColor;
            }
            return PlatformColors.FalseStateColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            throw new NotSupportedException();
        }
    }
}
