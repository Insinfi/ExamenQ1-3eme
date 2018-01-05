using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ExamenXaml4H
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        public List<GetAllContactResult> ContactList { get; set; }
        public GetCurrentContactResult CurrentContact { get; set; }

        public List<GetRDVByIDResult> RDVlist { get; set; }
        public MainWindowViewModel()
        {
            DataClasses1DataContext myContext = new DataClasses1DataContext();
            ContactList = myContext.GetAllContact().ToList();
        }


        public void GetCurrentContact(Guid id)
        {
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            CurrentContact = mycontext.GetCurrentContact(id).FirstOrDefault();
            OnPropertyChanged("CurrentContact");
        }

        public void GetRDV(Guid id)
        {
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            RDVlist = mycontext.GetRDVByID(id).ToList();
            OnPropertyChanged("RDVlist");
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

    }

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
    public class IsBeforeTodayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).Date < DateTime.Now.Date;
            }
            else
            {
                return DependencyProperty.UnsetValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
