using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestDelete
{
    public interface IHttpRequestDelete
    {
        string ExecuteDelete(string url, string apikey);
    }
}
