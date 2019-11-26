using KoRequireMVCSample.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KoRequireMVCSample.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductViewModelFactory productViewModelFactory;

        public ProductController(IProductViewModelFactory productViewModelFactory)
        {
            this.productViewModelFactory = productViewModelFactory;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [Route("InitializeData")]
        [HttpGet]
        public ActionResult InitializeData()
        {
            var vm = productViewModelFactory.CreateProductViewModel();

            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}