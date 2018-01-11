using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace RevisionWPF
{
    [ValueConversion(typeof(DateTime), typeof(Brush))]
    public class DateTimeToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dateTime = (DateTime)value;
            if (dateTime.Day == DateTime.Now.Day && dateTime.Month == DateTime.Now.Month)
            {
                return Brushes.Red;
            }
            else
            {
                return Brushes.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
