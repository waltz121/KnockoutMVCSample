using KnockoutMVCApplication.ProductType.AddProductTypeCommand;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model;
using KnockoutMVCApplication.ProductType.DeleteProductTypeCommand;
using KoRequireMVCSample.Factory;
using System.Web.Mvc;

namespace KoRequireMVCSample.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeViewModelFactory productTypeViewModelFactory;
        private readonly IAddProductTypeCommand addProductTypeCommand;
        private readonly IDeleteProductTypeCommand deleteProductTypeCommand;
        public ProductTypeController(IProductTypeViewModelFactory productTypeViewModelFactory, IAddProductTypeCommand addProductTypeCommand,
                                     IDeleteProductTypeCommand deleteProductTypeCommand)
        {
            this.productTypeViewModelFactory = productTypeViewModelFactory;
            this.addProductTypeCommand = addProductTypeCommand;
            this.deleteProductTypeCommand = deleteProductTypeCommand;
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

        [Route("DeleteProductType")]
        [HttpGet]
        public ActionResult DeleteProductType(int id)
        {
            var vm = "";
            deleteProductTypeCommand.ExecuteCommand(id);
            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}