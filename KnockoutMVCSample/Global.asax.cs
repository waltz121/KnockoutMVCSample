using KnockoutMVCApplication.Product;
using KnockoutMVCBootstrap;
using KnockoutMVCCommons;
using KnockoutMVCSample.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KnockoutMVCSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ProductMapping.Execute();

            UnityConfigPresentation.RegisterComponents(UnityConfig.RegisterComponents());

            ApplicationSettings.Url = "https://localhost:44376/api/";
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
