using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionWPFFActures
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<GetAllClientsResult> ClientList { get; set; }
        public List<GetAllFacturesByClientResult> FactureList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            DataClasses1DataContext MyContext = new DataClasses1DataContext();
            ClientList = MyContext.GetAllClients().ToList();
        }

        public void OnPropertyChanged(string PropertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        /*public void UpdateCurrentUser(Guid ContactId)
        {
            DataClasses1DataContext MyContext = new DataClasses1DataContext();
            CurrentContact = MyContext.GetContactInfo(ContactId).FirstOrDefault<GetContactInfoResult>();
            OnPropertyChanged("CurrentContact");
        }*/

        public void UpdateFactures(Guid ClientId)
        {
            DataClasses1DataContext MyContext = new DataClasses1DataContext();
            FactureList = MyContext.GetAllFacturesByClient(ClientId).ToList();
            OnPropertyChanged("FactureList");
        }
    }
}
