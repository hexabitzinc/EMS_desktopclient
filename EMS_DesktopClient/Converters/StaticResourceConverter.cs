using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace EMS_DesktopClient.Converters
{
    public class StaticResourceConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values is null)
                return null;
            object value = values[0];
            FrameworkElement frameworkElement = values[1] as FrameworkElement;
            if (value is null || frameworkElement is null)
                return null;
            if (value.GetType() != typeof(string))
                return frameworkElement.Resources["ViewDialog"];
            string key = value as string;
            if (string.IsNullOrWhiteSpace(key))
                return frameworkElement.Resources["ViewDialog"];
            if (frameworkElement.Resources[key] == null)
                return frameworkElement.Resources["ViewDialog"];
            object fff = frameworkElement.Resources[key];
            return fff;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
