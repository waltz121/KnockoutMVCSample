using KnockoutMVCSample.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutMVCSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductViewModelFactory productViewModelFactory;

        public HomeController(IProductViewModelFactory productViewModelFactory)
        {
            this.productViewModelFactory = productViewModelFactory;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}