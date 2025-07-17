using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WordleGame.Converters
{
    public class TileStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string state = value as string;
            return state switch
            {
                "Correct" => Brushes.Green,
                "Present" => Brushes.Goldenrod,
                "Absent" => Brushes.Gray,
                _ => Brushes.LightGray
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
