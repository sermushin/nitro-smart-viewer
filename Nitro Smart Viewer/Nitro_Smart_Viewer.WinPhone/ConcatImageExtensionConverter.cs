using System;
using Windows.UI.Xaml.Data;

namespace Nitro_Smart_Viewer.WinPhone
{
    public class ConcatImageExtensionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var isFile = value as bool? ?? false;

            return isFile ? "file.png" : "folder.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}