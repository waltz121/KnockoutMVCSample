using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestDelete
{
    public class HttpRequestDelete : IHttpRequestDelete
    {
        public string ExecuteDelete(string url, string apikey)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "DELETE";
                request.Headers.Add("Authorization", apikey);

                string message = String.Empty;

                using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    message = response.StatusDescription;
                }

                return message;
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }

            
        }
    }
}
