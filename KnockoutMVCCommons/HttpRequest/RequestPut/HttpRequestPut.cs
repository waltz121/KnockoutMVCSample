using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestPut
{
    public class HttpRequestPut : IHttpRequestPut
    {

        public string ExecutePut(string apiUrl, string apiKey, object Param)
        {
            string responseData = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiUrl);
                request.Headers.Add("Authorization", apiKey);
                request.ContentType = "application/json";
                request.Method = "PUT";

                using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(Param);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }


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
                throw new InvalidOperationException(ex.Message);
            }

        }
    }
}
