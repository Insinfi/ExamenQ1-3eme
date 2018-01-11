using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionWPF
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<GetAllContactsResult> ContactList { get; set; }
        public List<GetAllRDVByContactResult> RDVList { get; set; }
        public GetContactInfoResult CurrentContact { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            DataClasses1DataContext MyContext = new DataClasses1DataContext();
            ContactList = MyContext.GetAllContacts().ToList();
        }

        public void OnPropertyChanged(string PropertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public void UpdateCurrentUser(Guid ContactId)
        {
            DataClasses1DataContext MyContext = new DataClasses1DataContext();
            CurrentContact = MyContext.GetContactInfo(ContactId).FirstOrDefault<GetContactInfoResult>();
            OnPropertyChanged("CurrentContact");
        }

        public void UpdateRDV(Guid ContactId)
        {
            DataClasses1DataContext MyContext = new DataClasses1DataContext();
            RDVList = MyContext.GetAllRDVByContact(ContactId).ToList();
            OnPropertyChanged("RDVList");
        }
    }
}
