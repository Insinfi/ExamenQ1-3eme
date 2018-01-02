using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ExamenWPFprep2
{
    public class UsersTemplateSelector:DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var User = (GetAllUsersResult)item;
            var window = Application.Current.MainWindow;
            if ( User.Prenom == "Jean")
            {
                return (DataTemplate)window.FindResource("ComboItem2");
            }
            else
            {
                return (DataTemplate)window.FindResource("ComboItem");
            }
        }

        
    }
}
