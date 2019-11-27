using InventorySalesDomain;
using KnockoutMVCApplication.Product;
using KnockoutMVCApplication.ProductImage.Model;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KnockoutMVCApplication.ProductImage.Query.GetAllProductImageQuery
{
    public class GetAllProductImageQuery : IGetAllProductImageQuery
    {
        private readonly IHttpRequestGet httpRequestGet;
        public GetAllProductImageQuery(IHttpRequestGet httpRequestGet)
        {
            this.httpRequestGet = httpRequestGet;
        }
        public List<ProductImageListModel> ExecuteGetAllProductImage()
        {
            string url = ApplicationSettings.Url + "ProductImage/GetListProductImageDomain";
            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();

            string result = httpRequestGet.ExecuteGet(url, key);

            var productImageDomainList = JsonConvert.DeserializeObject<List<ProductImageDomain>>(result);
            List<ProductImageListModel> productImageListModels = new List<ProductImageListModel>();

            mapper.Map(productImageDomainList, productImageListModels);

            return productImageListModels;
        }
    }
}
