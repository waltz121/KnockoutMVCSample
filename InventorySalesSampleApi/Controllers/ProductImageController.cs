using AutoMapper;
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
    public class ProductImageController : ApiController
    {
        private readonly IUnitOfWork InventorySalesUnitOfWork;
        private readonly IMapper mapper;
        private readonly IProductImageDomainFactory productImageDomainFactory;

        public ProductImageController(IUnitOfWork InventorySalesUnitOfWork, IProductImageDomainFactory productImageDomainFactory)
        {
            this.InventorySalesUnitOfWork = InventorySalesUnitOfWork;
            this.productImageDomainFactory = productImageDomainFactory;
            mapper = InventorySalesMapping.MapConfig.CreateMapper();
        }

        [HttpGet]
        public List<ProductImageDomain> GetListProductImageDomain()
        {
            var ListOfProductImage = InventorySalesUnitOfWork.ProductImageRepository.GetAll().ToList();
            var ListOfProductImageDomains = productImageDomainFactory.CreateListOfProductImageDomain();

            mapper.Map(ListOfProductImage, ListOfProductImageDomains);

            return ListOfProductImageDomains;
        }

        [HttpGet]
        public ProductImageDomain GetProductImageDomain(int id)
        {
            var ProductImage = InventorySalesUnitOfWork.ProductImageRepository.Get(id);
            var ProductImageDomain = productImageDomainFactory.CreateProductImageDomain();
            
            mapper.Map(ProductImage, ProductImageDomain);

            return ProductImageDomain;
        }

        [HttpPost]
        public HttpResponseMessage AddProductImage([FromBody]ProductImageDomain productImageDomain)
        {
            Product_Image product_Image = new Product_Image();
            mapper.Map(productImageDomain, product_Image);

            InventorySalesUnitOfWork.ProductImageRepository.Add(product_Image);

            InventorySalesUnitOfWork.Commit();
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }

    }
}
