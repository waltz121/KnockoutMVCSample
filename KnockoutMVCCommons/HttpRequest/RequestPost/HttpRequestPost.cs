using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons.HttpRequest.RequestPost
{
    public class HttpRequestPost : IHttpRequestPost
    {
        public string ExecutePost(string apiUrl, string apiKey, Object Param)
        {
            string responsedata = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiUrl);
                request.Headers.Add("Authorization", apiKey);
                request.ContentType = "application/json";
                request.Method = "POST";

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

                    responsedata = reader.ReadToEnd();

                    reader.Close();
                    dataStream.Close();
                }

                return responsedata;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
