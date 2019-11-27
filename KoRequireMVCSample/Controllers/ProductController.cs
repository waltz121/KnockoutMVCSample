using KnockoutMVCApplication.ProductImage.Command.AddProductImageCommand;
using KnockoutMVCApplication.ProductImage.Model;
using KoRequireMVCSample.Factory;
using KoRequireMVCSample.Models;
using System;
using System.Web.Mvc;

namespace KoRequireMVCSample.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductViewModelFactory productViewModelFactory;
        private readonly IAddProductImageCommand addProductImageCommand;

        public ProductController(IProductViewModelFactory productViewModelFactory, IAddProductImageCommand addProductImageCommand)
        {
            this.productViewModelFactory = productViewModelFactory;
            this.addProductImageCommand = addProductImageCommand;
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

        //[Route("SaveProductImage")]
        //[HttpPost]
        //public ActionResult SaveProductImage(AddProductImageModel addProductImageModel)
        //{
        //    var vm = addProductImageCommand.ExecuteAddProductImage(addProductImageModel);

        //    return Json(vm, JsonRequestBehavior.AllowGet);
        //}


        [Route("SaveProductImage")]
        [HttpPost]
        public ActionResult SaveProductImage(AddProductWithImageModel addProductImageModel)
        {
            AddProductImageModel addProductImageModelApplication = new AddProductImageModel();
            addProductImageModelApplication.id = addProductImageModel.id;
            addProductImageModelApplication.Description = addProductImageModel.Description;
            addProductImageModelApplication.ProductId = addProductImageModel.ProductId;

            addProductImageModelApplication.Image = Convert.FromBase64String(addProductImageModel.Image);

            var vm = addProductImageCommand.ExecuteAddProductImage(addProductImageModelApplication);

            return Json(vm, JsonRequestBehavior.AllowGet);
        }

        [Route("UploadImage")]
        [HttpPost]
        public void UploadImage(string imageData)
        {
            Console.WriteLine(imageData);
        }
    }
}