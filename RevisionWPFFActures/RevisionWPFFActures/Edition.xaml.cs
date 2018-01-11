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

namespace RevisionWPFFActures
{
    /// <summary>
    /// Logique d'interaction pour Edition.xaml
    /// </summary>
    public partial class Edition : Window
    {
        public Guid FactureID { get; set; }
        public Edition(Guid FactureID)
        {
            InitializeComponent();
            this.FactureID = FactureID;
        }
    }
}
