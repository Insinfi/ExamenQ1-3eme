using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

using System.Net.Http.Headers;
using System.Drawing;
using System.IO;

namespace WebApi2.Controllers
{
    public class HomeController : ApiController
    {
        DataClasses1DataContext mycontext = new DataClasses1DataContext();
        // GET: api/Home


        public IEnumerable<GetInfoResult> GetInfo()
        {
            return mycontext.GetInfo();

        }
        public HttpResponseMessage GetImage(string id)
        {
            Guid testID = Guid.Parse(id);
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            var test = mycontext.GetImage(testID).FirstOrDefault();

            byte[] bytes = test.photo.ToArray();

            
            MemoryStream ms = new MemoryStream(bytes);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StreamContent(ms);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/png");

            return response;

        }
    }
}
