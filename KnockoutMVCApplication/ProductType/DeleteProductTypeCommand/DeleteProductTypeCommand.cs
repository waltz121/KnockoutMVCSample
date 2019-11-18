using KnockoutMVCCommons;
using KnockoutMVCCommons.HttpRequest.RequestDelete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.DeleteProductTypeCommand
{
    public class DeleteProductTypeCommand : IDeleteProductTypeCommand
    {
        private readonly IHttpRequestDelete httpRequestDelete;

        public DeleteProductTypeCommand(IHttpRequestDelete httpRequestDelete)
        {
            this.httpRequestDelete = httpRequestDelete;
        }
        public string ExecuteCommand(int id)
        {
            string url = ApplicationSettings.Url + "ProductType/DeleteProductType";
            url = url + "?productTypeCode=" + id;
            string key = "";

            string result = httpRequestDelete.ExecuteDelete(url, key);

            return result;
           
        }
    }
}
