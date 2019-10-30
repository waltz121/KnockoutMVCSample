using InventorySalesSampleApi.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace InventorySalesSampleApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            InventorySalesMapping.Execute();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
