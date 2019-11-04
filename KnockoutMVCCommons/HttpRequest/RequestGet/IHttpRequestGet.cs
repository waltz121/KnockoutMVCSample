using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestGet
{
    public interface IHttpRequestGet
    {
        string ExecuteGet(string apiUrl, string apiKey);
    }
}
