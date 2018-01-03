using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenWeb01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public Models.ListeArticle listeArticle = new Models.ListeArticle();
        public ActionResult Index()
        {
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            listeArticle.GenreList= mycontext.GetAllGenre().ToList < GetAllGenreResult >();
            listeArticle.ArticleList = mycontext.GetAllArticle().ToList<GetAllArticleResult>();
            listeArticle.CollList = mycontext.GetAllColl().ToList<GetAllCollResult>();
            return View(listeArticle);
        }

        public ActionResult Tester()
        {
            return Index();
        }

        public JsonResult GetArticleInfo(string id)
        {
            DataClasses1DataContext myContext = new DataClasses1DataContext();
            var article = myContext.GetArticle(Guid.Parse(id)).FirstOrDefault();
            return Json(article);
        }

        [HttpPost]
        public ActionResult UpdateDB(String idArticle, String idGenre, String idColl, String Nom, String Des )
        {
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            mycontext.UpdateByID( Guid.Parse(idArticle), Guid.Parse(idGenre), Guid.Parse(idColl),Nom,Des);
            return RedirectToAction("Index");
        }

    }
}