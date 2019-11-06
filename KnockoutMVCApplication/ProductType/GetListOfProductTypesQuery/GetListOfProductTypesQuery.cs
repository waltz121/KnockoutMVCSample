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

namespace KnockoutMVCApplication.ProductType.GetListOfProductTypesQuery
{
    public class GetListOfProductTypesQuery : IGetListOfProductTypesQuery
    {
        private readonly IHttpRequestGet httpRequestGet;

        public GetListOfProductTypesQuery(IHttpRequestGet httpRequestGet)
        {
            this.httpRequestGet = httpRequestGet;
        }
        public List<ProductTypeListModel> Execute()
        {
            string url = ApplicationSettings.Url + "ProductType/GetAllListProductTypes";
            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();

            string result = httpRequestGet.ExecuteGet(url, key);

            var ProductTypeDomainList = JsonConvert.DeserializeObject<List<ProductTypesDomain>>(result);
            List<ProductTypeListModel> ProductTypeList = new List<ProductTypeListModel>();
            mapper.Map(ProductTypeDomainList, ProductTypeList);

            return ProductTypeList;

        }
    }
}