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
        List<GetRestoInfoResult> RestoList = new List<GetRestoInfoResult>();
        // GET: Home
        public ActionResult Index()
        {
            var client = new RestClient("http://192.168.1.29:9000/api/home/GetInfoResto");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            
            var test = JsonConvert.DeserializeObject<List<GetRestoInfoResult>>(response.Content);
            return View(test);
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
    }
}