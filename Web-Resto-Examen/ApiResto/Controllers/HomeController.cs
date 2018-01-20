using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiResto.Controllers
{
    public class HomeController : ApiController
    {
        DataClasses1DataContext myContext = new DataClasses1DataContext();
        // GET: Home
        public IEnumerable<GetAllCategorieResult> GetAllCategorie()
        {
            var categories = myContext.GetAllCategorie().ToList();
            return categories;
        }
    }
}
