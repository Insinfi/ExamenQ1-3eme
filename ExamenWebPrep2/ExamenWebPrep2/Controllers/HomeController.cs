using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;
namespace ExamenWebPrep2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public FileResult image(string id)
        {

            Guid testID = Guid.Parse(id);
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            var test = mycontext.GetImage(testID).FirstOrDefault();

            byte[] photo;



            if (test.GetType() == typeof(System.DBNull))
            {
                photo = System.IO.File.ReadAllBytes(Server.MapPath("~/Images/Kappa.png"));
            }
            else
            {
                photo = test.photo.ToArray();
            }
            
            return File(photo, "image/png");

        }
    }
}