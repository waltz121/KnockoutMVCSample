using InventorySalesSampleApi.Mappings;
using KnockoutMVCCommons;
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
            ApplicationSettings.Url = "https://localhost:44376/api/";
            UnityConfig.RegisterComponents();
            InventorySalesMapping.Execute();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
