using InventorySalesDomain;
using KnockoutMVCApplication.Product;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.GetViaIdProductTypesQuery
{
    public class GetViaIdProductTypesQuery : IGetViaIdProductTypesQuery
    {
        private readonly IHttpRequestGet httpRequestGet;
        public GetViaIdProductTypesQuery(IHttpRequestGet httpRequestGet)
        {
            this.httpRequestGet = httpRequestGet;
        }
        public ProductTypeDetailModel ExecuteQuery(int id)
        {
            string url = ApplicationSettings.Url + "ProductType/GetProductTypesViaId";
            url = url + "?id=" + id;

            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();

            string result = httpRequestGet.ExecuteGet(url, key);

            var ProductTypeDomainDetail = JsonConvert.DeserializeObject<ProductTypesDomain>(result);
            ProductTypeDetailModel productTypeDetailModel = new ProductTypeDetailModel();
            mapper.Map(ProductTypeDomainDetail, productTypeDetailModel);

            return productTypeDetailModel;
        }
    }
}
