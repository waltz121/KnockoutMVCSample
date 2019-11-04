using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestGet
{
    public class HttpRequestGet : IHttpRequestGet
    {       
        public string ExecuteGet(string apiUrl, string apiKey)
        {
            string responseData = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiUrl);
                if(apiKey != string.Empty)
                {
                    request.Headers.Add("Authorization", apiKey);
                }
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);

                    responseData = reader.ReadToEnd();

                    reader.Close();
                    dataStream.Close();
                }

                return responseData;

            }
            catch(Exception ex)
            {
                throw new System.InvalidOperationException(ex.Message);
            }
        }
    }
}
