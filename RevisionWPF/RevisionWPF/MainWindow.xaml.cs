using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RevisionWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel mwvm { get; set; }

        public Timer RefreshHour;
        public MainWindow()
        {
            mwvm = new MainWindowViewModel();   
            InitializeComponent();

            this.Heure.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            RefreshHour = new Timer(1000);
            RefreshHour.Elapsed += RefreshHour_Elapsed;
            RefreshHour.Enabled = true;
            RefreshHour.Start();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox tmp = (ListBox)sender;
            GetAllContactsResult contact = (GetAllContactsResult)tmp.SelectedItem;
            mwvm.UpdateCurrentUser(contact.IdContact);
            mwvm.UpdateRDV(contact.IdContact);
        }

        private void RefreshHour_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() => {
                this.Heure.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }));
        }
    }
}
