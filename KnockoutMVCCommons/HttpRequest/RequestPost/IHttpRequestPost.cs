using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestPost
{
    public interface IHttpRequestPost
    {
        string ExecutePost(string apiUrl, string apiKey, Object Param);
    }
}
