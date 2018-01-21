using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Web_Resto_Examen.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(GetCategorie());
        }

        public IEnumerable<GetAllCategorieResult> GetCategorie()
        {
            var client = new RestClient("http://localhost:4242/api/home/getallcategorie");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse reponse = client.Execute(request);
            if (reponse.IsSuccessful)
            {
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                var categorie =jsonSerializer.Deserialize<List<GetAllCategorieResult>>(reponse.Content);
                categorie.Insert(0, new GetAllCategorieResult{ Nom="Toutes" });
                return categorie;
            }
            else
            {
                return null;
            }
        }

        public ActionResult ListRestoView(Guid id) {
            DataClasses1DataContext mc = new DataClasses1DataContext();
            var restostri = mc.GetAllRestorant().ToList();
            if (id != Guid.Empty) {
                restostri = (List<GetAllRestorantResult>)restostri.Where(x => x.CategorieId == id).ToList();
            }
            return PartialView(restostri);
        }

    }
}