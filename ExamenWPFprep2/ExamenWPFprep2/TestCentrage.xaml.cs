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
using System.Windows.Shapes;

namespace ExamenWPFprep2
{
    /// <summary>
    /// Logique d'interaction pour TestCentrage.xaml
    /// </summary>
    public partial class TestCentrage : Window
    {
        public Client client2 { get; set; }

        public TestCentrage()
        {
            client2 = MaClasseStatic.client1;
            InitializeComponent();
        }
    }
}
