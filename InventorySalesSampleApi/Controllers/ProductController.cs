using InventorySalesDomain;
using InventorySalesSampleApi.Mappings;
using InventorySalesSampleApi.Models;
using InventorySalesSampleApi.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventorySalesSampleApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IUnitOfWork InventorySalesUnitOfWork;

        public ProductController(IUnitOfWork InventorySalesUOW)
        {
            InventorySalesUnitOfWork = InventorySalesUOW;
        }

        [HttpGet]
        public List<ProductDomain> GetListProducts()
        {
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();
            var ListOfProducts = InventorySalesUnitOfWork.ProductRepository.GetAll().ToList();
            List<ProductDomain> productDomains = new List<ProductDomain>();

            mapper.Map(ListOfProducts, productDomains);

            return productDomains;
        }

        [HttpPost]
        public HttpResponseMessage AddProduct([FromBody]ProductDomain productDomain)
        {
            Product product = new Product();
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();

            mapper.Map(productDomain, product);

            InventorySalesUnitOfWork.ProductRepository.Add(product);

            InventorySalesUnitOfWork.Commit();
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }
    }
}
