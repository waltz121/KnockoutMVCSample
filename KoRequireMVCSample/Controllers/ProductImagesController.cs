using KnockoutMVCApplication.ProductImage.Model;
using KnockoutMVCApplication.ProductImage.Query.GetProductImageQuery;
using KoRequireMVCSample.Factory;
using KoRequireMVCSample.Models.ViewModels;
using System.Web.Mvc;

namespace KoRequireMVCSample.Controllers
{
    [Authorize]
    public class ProductImagesController : Controller
    {
        IProductImageViewModelFactory ProductImageViewModelFactory;
        IEditProductImageViewModelFactory editProductImageViewModelFactory;
        IGetProductImageQuery getProductImageQuery;

        public ProductImagesController(IProductImageViewModelFactory ProductImageViewModelFactory, 
                                       IEditProductImageViewModelFactory editProductImageViewModelFactory,
                                       IGetProductImageQuery getProductImageQuery)
        {
            this.ProductImageViewModelFactory = ProductImageViewModelFactory;
            this.editProductImageViewModelFactory = editProductImageViewModelFactory;
            this.getProductImageQuery = getProductImageQuery;
        }
        // GET: ProductImages
        public ActionResult Index()
        {
            return View();
        }

        [Route("InitializeData")]
        [HttpGet]
        public ActionResult InitializeData()
        {
            var vm = ProductImageViewModelFactory.CreateProductImagesViewModel();

            return Json(vm.ProductImageLists, JsonRequestBehavior.AllowGet);
        }

        [Route("Get64ByteString")]
        [HttpGet]
        public ActionResult GetImage64ByteString(int id)
        {
            ProductImageDetailModel vm = getProductImageQuery.ExecuteQuery(id);

            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}