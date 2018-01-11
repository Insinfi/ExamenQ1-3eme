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

namespace Exam2014WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindowViewModel mwvm { get; set; }
        Window Edit;

        public MainWindow()
        {
            
            mwvm = new MainWindowViewModel();
            Edit= new EditFacture();
            InitializeComponent();
        }

        

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lb = (ListBox)sender;
            var client = (GetInfoUserResult)lb.SelectedItem;
            mwvm.InfoFacture(client.ClientID);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Edit = new EditFacture();

            Edit.ShowDialog();
        }
    }
}
