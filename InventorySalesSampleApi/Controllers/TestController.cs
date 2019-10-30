using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventorySalesSampleApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string GetTest()
        {
            return "Testing this Api";
        }
    }
}
