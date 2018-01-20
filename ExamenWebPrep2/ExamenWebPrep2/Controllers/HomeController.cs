using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using RestSharp.Deserializers;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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

            var client = new RestClient("http://192.168.1.29:8080/api/home/"+id);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                //enregistrer l'image dans un dossier
                string filename = string.Empty;
                MemoryStream img = new MemoryStream(response.RawBytes);
                Image imgDb = Image.FromStream(img);
                filename = "imgDB.png";
                var path = Server.MapPath("/Images/");
                string FullPath = path + @"\" + filename;
                imgDb.Save(FullPath);
                //
                return File(response.RawBytes, "image/png");

            }
            else
            {
                return File("~/Images/Kappa.png", "image/png");

            }

        }
    }
}