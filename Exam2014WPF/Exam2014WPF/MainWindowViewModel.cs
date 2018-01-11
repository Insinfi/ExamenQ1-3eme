using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2014WPF
{
    public class MainWindowViewModel
    {
        public List<GetInfoUserResult>Clients { get; set; }
        public MainWindowViewModel()
        {
            Clients = new List<GetInfoUserResult>();
            DataClasses1DataContext myContext = new DataClasses1DataContext();
            Clients=myContext.GetInfoUser().ToList();
        }
    }
}
