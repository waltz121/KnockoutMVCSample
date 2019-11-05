using KnockoutMVCSample.Factory;
using KnockoutMVCSample.Models;
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

        [Route("Initialize")]
        [HttpGet]
        public ActionResult InitializeData()
        {
            var vm = productViewModelFactory.CreateProductViewModel();

            return Json(vm, JsonRequestBehavior.AllowGet);
        }

        [Route("PostTest")]
        [HttpPost]
        public JsonResult PostTest(TestPostDataFormModel form)
        {
            Console.WriteLine("Posted From Knockout JS: TestProductVar1 - " + form.TestProductVar1 + 
                              "TestProductVar2 - " + form.TestProductVar2);

            return Json(form, JsonRequestBehavior.AllowGet);
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