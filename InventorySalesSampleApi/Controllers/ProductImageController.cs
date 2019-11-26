using AutoMapper;
using InventorySalesDomain;
using InventorySalesDomain.Factory;
using InventorySalesSampleApi.Mappings;
using InventorySalesSampleApi.Models;
using InventorySalesSampleApi.UnitOfWork;
using System;
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
        private readonly IProductTypeDomainFactory productTypeDomainFactory;
        
        public ProductImageController(IUnitOfWork InventorySalesUnitOfWork, IProductTypeDomainFactory productTypeDomainFactory)
        {
            this.InventorySalesUnitOfWork = InventorySalesUnitOfWork;
            this.productTypeDomainFactory = productTypeDomainFactory;
            mapper = InventorySalesMapping.MapConfig.CreateMapper();
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
