using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIExamenResto.Controllers
{
    public class HomeController : ApiController
    {
        
        DataClasses1DataContext mycontext = new DataClasses1DataContext();

        
        public IEnumerable<GetRestoInfoResult> GetInfoResto()
        {
            var Resto=mycontext.GetRestoInfo();
            return Resto;
        }
        

        public IEnumerable<GetComFromRestoResult>GetCom(string id)
        {
            Guid guid = Guid.Parse(id);
            var com = mycontext.GetComFromResto(guid);
            return com;
        }
        
        public HttpResponseMessage GetImage(string id)
        {
            Guid testID = Guid.Parse(id);
            
            var test = mycontext.GetImage(testID).FirstOrDefault();

            byte[] bytes = test.Photo.ToArray();

            MemoryStream ms = new MemoryStream(bytes);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(ms);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");

            return response;
        }
    }
}
