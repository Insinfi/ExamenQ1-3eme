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

namespace FactureExamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel mwvm { get; set; }
        public MainWindow()
        {
            mwvm = new MainWindowViewModel();
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox tmp = (ListBox)sender;
            GetAllClientsResult user = (GetAllClientsResult)tmp.SelectedItem;
            if (user != null)
            {
                mwvm.GetFacture(user.ClientId);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
