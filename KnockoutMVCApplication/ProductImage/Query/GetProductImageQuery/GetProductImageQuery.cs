using InventorySalesDomain;
using KnockoutMVCApplication.Product;
using KnockoutMVCApplication.ProductImage.Model;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using Newtonsoft.Json;
using System;

namespace KnockoutMVCApplication.ProductImage.Query.GetProductImageQuery
{
    public class GetProductImageQuery : IGetProductImageQuery
    {
        private readonly IHttpRequestGet httpRequestGet;

        public GetProductImageQuery(IHttpRequestGet httpRequestGet)
        {
            this.httpRequestGet = httpRequestGet;
        }
        public ProductImageDetailModel ExecuteQuery(int id)
        {
            string url = ApplicationSettings.Url + "ProductImage/GetProductImageDomain";
            url = url + "?id="+ id;

            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();

            string result = httpRequestGet.ExecuteGet(url, key);

            var productImageDomain = JsonConvert.DeserializeObject<ProductImageDomain>(result);
            ProductImageDetailModel productImageDetailModel = new ProductImageDetailModel();

            mapper.Map(productImageDomain, productImageDetailModel);
            productImageDetailModel.Image = Convert.ToBase64String(productImageDomain.Image);
            return productImageDetailModel;
        }
    }
}
