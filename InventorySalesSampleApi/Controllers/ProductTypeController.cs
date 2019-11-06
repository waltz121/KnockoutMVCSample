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
    public class ProductTypeController : ApiController
    {
        private readonly IUnitOfWork InventorySalesUOW;
        private readonly IProductTypeDomainFactory productTypeDomainFactory;

        public ProductTypeController(IUnitOfWork InventorySalesUOW)
        {
            this.InventorySalesUOW = InventorySalesUOW;
        }

        [HttpGet]
        public List<ProductTypesDomain> GetAllListProductTypes()
        {
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();
            var ListOfProductTypes = InventorySalesUOW.ProductTypeRepository.GetAll().ToList();
            var ProductTypeDomains = productTypeDomainFactory.CreateListofProductTypesDomain();

            mapper.Map(ListOfProductTypes, ProductTypeDomains);

            return ProductTypeDomains;
        }

        [HttpGet]
        public ProductTypesDomain GetProductTypesViaId(int id)
        {
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();
            var ProductType = InventorySalesUOW.ProductTypeRepository.Get(id);
            var ProductTypeDomain = productTypeDomainFactory.CreateProductTypesDomain();

            mapper.Map(ProductType, ProductTypeDomain);

            return ProductTypeDomain;
        }

        [HttpPost]
        public HttpResponseMessage AddProductType([FromBody]ProductTypesDomain productTypesDomain)
        {
            Product_Types product_Types = new Product_Types();
            var mapper = InventorySalesMapping.MapConfig.CreateMapper();

            mapper.Map(productTypesDomain, product_Types);

            InventorySalesUOW.ProductTypeRepository.Add(product_Types);

            InventorySalesUOW.Commit();
            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }



    }
}
