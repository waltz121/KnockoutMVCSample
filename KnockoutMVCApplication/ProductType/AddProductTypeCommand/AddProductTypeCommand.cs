using InventorySalesDomain.Factory;
using KnockoutMVCApplication.Product;
using KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.AddProductTypeCommand
{
    public class AddProductTypeCommand : IAddProductTypeCommand
    {
      
        private readonly IProductTypeDomainFactory productTypeDomainFactory;
        private readonly IHttpRequestPost httpRequestPost;

        public AddProductTypeCommand(IProductTypeDomainFactory productTypeDomainFactory,
                                     IHttpRequestPost httpRequestPost)
        {
            this.productTypeDomainFactory = productTypeDomainFactory;
            this.httpRequestPost = httpRequestPost;
        }

        public void ExecuteCommand(AddProductTypeModel addProductTypeModel)
        {
            string url = ApplicationSettings.Url + "ProductType/AddProductType";
            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();
            var ProductTypeDomain = productTypeDomainFactory.CreateProductTypesDomain();

            mapper.Map(addProductTypeModel, ProductTypeDomain);
            
            string result = httpRequestPost.ExecutePost(url,key, ProductTypeDomain);

            
        }
    }
}
