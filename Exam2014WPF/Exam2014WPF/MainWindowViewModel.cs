using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2014WPF
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        public List<GetInfoUserResult>Clients { get; set; }
        public List<getInfoFactureResult> Facture { get; set; }
        public MainWindowViewModel()
        {
            Clients = new List<GetInfoUserResult>();
            Facture = new List<getInfoFactureResult>();
            DataClasses1DataContext myContext = new DataClasses1DataContext();
            Clients=myContext.GetInfoUser().ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void InfoFacture(Guid id)
        {
            Facture = new List<getInfoFactureResult>();

            DataClasses1DataContext myContext = new DataClasses1DataContext();
            Facture = myContext.getInfoFacture(id).ToList();
            OnPropertyChanged("Facture");
        }
        public void OnPropertyChanged(string PropertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
