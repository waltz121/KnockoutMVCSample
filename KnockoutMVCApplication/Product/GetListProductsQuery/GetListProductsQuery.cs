using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySalesDomain;
using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestGet;
using Newtonsoft.Json;

namespace KnockoutMVCApplication.Product.GetListProductsQuery
{
    public class GetListProductsQuery : IGetListProductsQuery
    {
        private readonly IHttpRequestGet httpRequestGet;
        public GetListProductsQuery(IHttpRequestGet httpRequestGet)
        {
            this.httpRequestGet = httpRequestGet;
        }

        public List<ProductGridModel> Execute()
        {
            string url = ApplicationSettings.Url + "Product/GetListProducts";
            string key = "";
            var mapper = ProductMapping.MapConfig.CreateMapper();


            string result = httpRequestGet.ExecuteGet(url, key);
            
            var ProductDomainList = JsonConvert.DeserializeObject<List<ProductDomain>>(result);
            List<ProductGridModel> products = new List<ProductGridModel>();
            mapper.Map(ProductDomainList, products);

            return products;
        }
    }
}
