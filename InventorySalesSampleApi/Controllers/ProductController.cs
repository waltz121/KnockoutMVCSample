using InventorySalesDomain;
using InventorySalesDomain.Factory;
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
        private readonly IProductDomainFactory productDomainFactory;

        public ProductController(IUnitOfWork InventorySalesUOW, IProductDomainFactory productDomainFactory)
        {
            InventorySalesUnitOfWork = InventorySalesUOW;
            this.productDomainFactory = productDomainFactory;
        }

        [HttpGet]
        public List<ProductDomain> GetListProducts()
        {
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();
            var ListOfProducts = InventorySalesUnitOfWork.ProductRepository.GetAll().ToList();
            var productDomains = productDomainFactory.CreateListofProductDomain();

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

        [HttpGet]
        public ProductDomain GetProduct(int id)
        {
            Product product = InventorySalesUnitOfWork.ProductRepository.Get(id);
            var ProductDomain = productDomainFactory.CreateProductDomain();
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();

            mapper.Map(product, ProductDomain);

            return ProductDomain;
        }
    }
}
