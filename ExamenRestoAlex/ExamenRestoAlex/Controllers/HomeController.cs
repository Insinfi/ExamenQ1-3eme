using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenRestoAlex.Controllers
{
    public class HomeController : Controller
    {
        List<GetRestoInfoResult> RestoAllList = new List<GetRestoInfoResult>();
        List<GetRestoInfoResult> RestoList = new List<GetRestoInfoResult>();

        List<GetCategorieResult> Categorie = new List<GetCategorieResult>();
        List<GetComFromRestoResult> CommentaireList = new List<GetComFromRestoResult>();

        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult HeaderView()
        {
            return PartialView("HeaderView");
        }
        public FileResult image(string id)
        {

            var client = new RestClient("http://192.168.1.29:9000/api/home/GetImage/" + id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                ////enregistrer l'image dans un dossier
                //string filename = string.Empty;
                //MemoryStream img = new MemoryStream(response.RawBytes);
                //Image imgDb = Image.FromStream(img);
                //filename = "imgDB.png";
                //var path = Server.MapPath("/Images/");
                //string FullPath = path + @"\" + filename;
                //imgDb.Save(FullPath);
                ////
                return File(response.RawBytes, "image/png");

            }
            else
            {
                return File("~/Images/Kappa.png", "image/png");

            }

        }
        public ActionResult RestoView(string id)
        {
            var client = new RestClient("http://192.168.1.29:9000/api/home/GetInfoResto");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            RestoAllList = JsonConvert.DeserializeObject<List<GetRestoInfoResult>>(response.Content);
            RestoList = RestoAllList;
            if (id != null)
            {
                if (Guid.Parse(id) == Guid.Empty)
                {
                    RestoList = RestoAllList;
                }
                else
                {
                    RestoList = RestoAllList.Where(x => Guid.Parse(id) == x.CategorieId).Select(x => { return x; }).ToList();
                }
            }


            return PartialView(RestoList);
        }

        public ActionResult CategorieView()
        {
            var client = new RestClient("http://192.168.1.29:9000/api/home/GetCategorie");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);

            Categorie = JsonConvert.DeserializeObject<List<GetCategorieResult>>(response.Content);
            Categorie.Insert(0, new GetCategorieResult { CategorieId = Guid.Empty, Nom = "Toutes les catégories" });

            return PartialView(Categorie);
        }

        public ActionResult CommentaireView(string restoid)
        {
            var client = new RestClient("http://192.168.1.29:9000/api/home/GetCom/" + restoid);
            //var client = new RestClient("http://192.168.1.29:9000/api/home/GetCom/b109e736-8146-45ad-9bc3-05962165b19b");

            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);


            if (response.IsSuccessful)
            {
                CommentaireList = JsonConvert.DeserializeObject<List<GetComFromRestoResult>>(response.Content);
                return PartialView(CommentaireList);
            }
            else
                return PartialView("CommentaireView");
        }

        public FileResult Star(string id)
        {
            
            return File("~/Images/star" + id + ".png", "image/png");
        }
    }
}