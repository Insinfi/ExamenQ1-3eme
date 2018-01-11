using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureExamen
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<GetAllClientsResult> ClientList { get; set; }
        public MainWindowViewModel()
        {
            DataClasses1DataContext myContext = new DataClasses1DataContext();
            ClientList = myContext.GetAllClients().ToList();
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
