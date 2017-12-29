using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWPFprep2
{
    public class MainWindowViewModel //met ca en public ca ira mieux dans le xaml.cs
    {
        public List<GetAllUsersResult> UsersList { get; set; }

        public MainWindowViewModel()
        {
            try
            {
                DataClasses1DataContext MyContext = new DataClasses1DataContext();
                UsersList = new List<GetAllUsersResult>(MyContext.GetAllUsers().ToList());
            }
            catch(Exception e)
            {

            }
        }

    }
}
