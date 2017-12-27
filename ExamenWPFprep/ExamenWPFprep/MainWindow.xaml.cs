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

namespace ExamenWPFprep
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Timer RefreshHour;
        public MainWindow()
        {
            InitializeComponent();
            this.Heure.Text = DateTime.Now.ToString("HH:MM:ss");
            RefreshHour = new Timer(1000);
            RefreshHour.Elapsed += RefreshHour_Elapsed;
            RefreshHour.Enabled = true;
            RefreshHour.Start();
        }



        void RefreshHour_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() => { this.Heure.Text = DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString(); }));
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evenement au niveau du Canvas");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evenement au niveau du bouton");
            e.Handled = true;
        }
    }
}
