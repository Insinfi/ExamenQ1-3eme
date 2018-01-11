using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenWPFprep2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel mwvm { get; set; }
        Window centrer;
        public MainWindow()
        {
            mwvm = new MainWindowViewModel();
            MaClasseStatic.client1 = new Client { Nom = "Dupond", Prenom = "Eric", Adresse = "Tournai" };
            MaClasseStatic.clientList = new List<Client>();
            MaClasseStatic.clientList.Add(new Client { Nom = "Dupond3", Prenom = "Eric3", Adresse = "Tournai3" });
            MaClasseStatic.clientList.Add(new Client { Nom = "Dupond4", Prenom = "Eric4", Adresse = "Tournai4" });
            MaClasseStatic.clientList.Add(new Client { Nom = "Dupond5", Prenom = "Eric5", Adresse = "Tournai5" });
            centrer = new TestCentrage();
            InitializeComponent();
            
        }
        
        private void Fenetre2_Checked(object sender, RoutedEventArgs e)
        {
            centrer = new TestCentrage();
            if (Fenetre2.IsChecked == true)
            {
                centrer.Show();
                
            }
            else { centrer.Close(); }
            
        }

        private void Fenetre2_Unchecked(object sender, RoutedEventArgs e)
        {
            if(centrer!=null) centrer.Close();
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {

        }
    }
}
