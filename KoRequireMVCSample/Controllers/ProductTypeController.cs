using KnockoutMVCApplication.ProductType;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model;
using KnockoutMVCApplication.ProductType.DeleteProductTypeCommand;
using KnockoutMVCApplication.ProductType.GetViaIdProductTypesQuery;
using KnockoutMVCApplication.ProductType.UpdateProductTypesCommand;
using KoRequireMVCSample.Factory;
using System.Web.Mvc;

namespace KoRequireMVCSample.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeViewModelFactory productTypeViewModelFactory;
        private readonly IAddProductTypeCommand addProductTypeCommand;
        private readonly IDeleteProductTypeCommand deleteProductTypeCommand;
        private readonly IUpdateProductTypesCommand updateProductTypesCommand;
        public ProductTypeController(IProductTypeViewModelFactory productTypeViewModelFactory, IAddProductTypeCommand addProductTypeCommand,
                                     IDeleteProductTypeCommand deleteProductTypeCommand, IUpdateProductTypesCommand updateProductTypesCommand)
        {
            this.productTypeViewModelFactory = productTypeViewModelFactory;
            this.addProductTypeCommand = addProductTypeCommand;
            this.deleteProductTypeCommand = deleteProductTypeCommand;
            this.updateProductTypesCommand = updateProductTypesCommand;
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

        [Route("UpdateProductType")]
        [HttpPost]
        public ActionResult UpdateProductType(ProductTypeDetailModel productTypeDetailModel)
        {
            var vm = "";
            updateProductTypesCommand.ExecuteCommand(productTypeDetailModel);
            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}