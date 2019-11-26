using InventorySalesDomain;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.Product.GetProductsDetailsQuery
{
    public class GetProductDetailsQuery : IGetProductDetailsQuery
    {
        private readonly IHttpRequestGet httpRequestGet;
        public GetProductDetailsQuery(IHttpRequestGet httpRequestGet)
        {
            this.httpRequestGet = httpRequestGet;
        }
        public ProductDetailModel Execute(int id)
        {
            string url = ApplicationSettings.Url + "Product/GetProduct";
            url = url + "/?id=" + id;

            string key = "";

            var mapper = ProductMapping.MapConfig.CreateMapper();

            string result = httpRequestGet.ExecuteGet(url, key);

            var productDomain = JsonConvert.DeserializeObject<ProductDomain>(result);

            ProductDetailModel productDetailModel = new ProductDetailModel();
            mapper.Map(productDomain, productDetailModel);

            return productDetailModel;
        }
    }
}
