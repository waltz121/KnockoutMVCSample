using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestPut
{
    public interface IHttpRequestPut
    {
        string ExecutePut(string apiUrl, string apiKey, Object Param);
    }
}
