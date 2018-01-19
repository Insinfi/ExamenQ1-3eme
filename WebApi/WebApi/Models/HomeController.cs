using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Models
{
    public class HomeController : ApiController
    {
        DataClasses1DataContext mycontext = new DataClasses1DataContext();
        // GET: api/Home
        

        public IEnumerable<GetInfoResult> GetInfo()
        {
             return mycontext.GetInfo();

        }
        public GetImageResult GetImage(string id)
        {
            Guid testID = Guid.Parse(id);
            DataClasses1DataContext mycontext = new DataClasses1DataContext();
            var test = mycontext.GetImage(testID).FirstOrDefault();
            return test;

        }
    }
}
