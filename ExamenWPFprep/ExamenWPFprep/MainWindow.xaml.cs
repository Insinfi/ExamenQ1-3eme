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


            this.pgb.Alert += pgb_Alert;

            //CommandBinding cmdBind = new CommandBinding();
            //cmdBind.Command = ApplicationCommands.Close;
            //cmdBind.Executed += new ExecutedRoutedEventHandler(CloseCommandExecute);
            //this.CommandBindings.Add(cmdBind);

            //COMMANDE TARGET
            CommandManager.RegisterClassCommandBinding(typeof(MainWindow), new CommandBinding(ApplicationCommands.Close, CloseApplicationExecuted, CloseApplicationCanExecute));


            this.Heure.Text = DateTime.Now.ToString("HH:MM:ss");
            RefreshHour = new Timer(1000);
            RefreshHour.Elapsed += RefreshHour_Elapsed;
            RefreshHour.Enabled = true;
            RefreshHour.Start();
        }
        //COMMANDE TARGET

        private void CloseApplicationCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (this.Accept != null)
            {
                e.CanExecute = (bool)this.Accept.IsChecked;
            }
        }

            //COMMANDE TARGET
        private void CloseApplicationExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow test = (MainWindow)sender;
            test.Close();
        }

        void RefreshHour_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() => { this.Heure.Text = DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString(); if(pgb.Value<101) this.pgb.Value += 1; }));
        }

        private void Canvas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evenement au niveau du Canvas");
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Evenement au niveau du bouton");
            //e.Handled = true; //empecher la propagation de l'event
        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Evenement au niveau du bouton");

        }

        private void Canvas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Evenement au niveau du Canvas");

        }
        void pgb_Alert(object sender,RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pgb_Alert_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alert");
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (this.Accept != null) e.CanExecute = (bool)this.Accept.IsChecked;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CommandBinding_CanExecute_1(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Accept2 != null)
                e.CanExecute = (bool)this.Accept2.IsChecked;
        }
    }
}
