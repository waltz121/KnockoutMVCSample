using KnockoutMVCSample.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutMVCSample.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeViewModelFactory productTypeViewModelFactory;
        public ProductTypeController(IProductTypeViewModelFactory productTypeViewModelFactory)
        {
            this.productTypeViewModelFactory = productTypeViewModelFactory;
        }
       
        // GET: ProductType
        public ActionResult Index()
        {
            return View();
        }

        [Route("Initialize")]
        [HttpGet]
        public ActionResult InitializeData()
        {
            var vm = productTypeViewModelFactory.CreateProductTypeViewModel();

            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}