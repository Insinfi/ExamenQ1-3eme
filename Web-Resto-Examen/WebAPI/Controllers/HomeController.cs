using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        DataClasses1DataContext myContext = new DataClasses1DataContext();
        // GET: Home
        public IEnumerable<GetAllCategorieResult> GetAllCategorie()
        {
            var categories = myContext.GetAllCategorie().ToList();
            return categories;
        }
    }
}