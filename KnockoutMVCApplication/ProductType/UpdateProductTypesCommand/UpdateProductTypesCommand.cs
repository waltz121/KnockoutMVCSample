using InventorySalesDomain.Factory;
using KnockoutMVCApplication.Product;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestPost;
using KnockoutMVCCommons.HttpRequest.RequestPut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.UpdateProductTypesCommand
{
    public class UpdateProductTypesCommand : IUpdateProductTypesCommand
    {
        private readonly IProductTypeDomainFactory productTypeDomainFactory;
        private readonly IHttpRequestPut httpRequestPut;

        public UpdateProductTypesCommand(IProductTypeDomainFactory productTypeDomainFactory,
                                         IHttpRequestPut httpRequestPut)
        {
            this.productTypeDomainFactory = productTypeDomainFactory;
            this.httpRequestPut = httpRequestPut;
        }

        public void ExecuteCommand(ProductTypeDetailModel productTypeDetailModel)
        {
            string url = ApplicationSettings.Url + "ProductType/EditProductType";
            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();
            var ProductTypeDomain = productTypeDomainFactory.CreateProductTypesDomain();

            mapper.Map(productTypeDetailModel, ProductTypeDomain);

            string result = httpRequestPut.ExecutePut(url, key, ProductTypeDomain);
        }
    }
}
