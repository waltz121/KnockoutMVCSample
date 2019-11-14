using KnockoutMVCApplication.ProductType.AddProductTypeCommand;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model;
using KnockoutMVCSample.Factory;
using System.Web.Mvc;

namespace KnockoutMVCSample.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeViewModelFactory productTypeViewModelFactory;
        private readonly IAddProductTypeCommand addProductTypeCommand;
        public ProductTypeController(IProductTypeViewModelFactory productTypeViewModelFactory, 
                                     IAddProductTypeCommand addProductTypeCommand)
        {
            this.productTypeViewModelFactory = productTypeViewModelFactory;
            this.addProductTypeCommand = addProductTypeCommand;
        }

        // GET: ProductType
        public ActionResult Index()
        {
            return View();
        }

        [Route("InitializeData")]
        [HttpGet]
        public ActionResult InitializeData()
        {
            var vm = productTypeViewModelFactory.CreateProductTypeViewModel();

            return Json(vm, JsonRequestBehavior.AllowGet);
        }

        [Route("AddProductType")]
        [HttpPost]
        public JsonResult AddProductType(AddProductTypeModel addProductTypeModel)
        {
            var vm = "";
            addProductTypeCommand.ExecuteCommand(addProductTypeModel);
            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}