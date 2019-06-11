using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace csharpRestClient
{
    public enum HttpVerb
    {
        Get,
        Post,
        Put,
        Delete
    }
    public enum AuthenticationType
    {
        Basic,
        NTLM
    }
    public enum AuthenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }
    class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb HttpMethod { get; set; }
        public AuthenticationType AuthType { get; set; }
        public AuthenticationTechnique AuthTechnique { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public RestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = HttpVerb.Get;
        }
        public string MakeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);

            request.Method = HttpMethod.ToString();

            if (AuthTechnique == AuthenticationTechnique.RollYourOwn)
            {
                string authHeader = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(UserName + ":" + UserPassword));
                request.Headers.Add("Authorization", "Basic " + authHeader);
            }
            else
            {
                NetworkCredential networkCredential = new NetworkCredential(UserName, UserPassword);
                request.Credentials = networkCredential;
            }


            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();

                //Process the response stream... (could be JSON, XM, HTML..)
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//End of StreamReader
                    }
                }// End of using ResponseStream
            }
            catch (Exception e)
            {
                strResponseValue = "{\"errorMessages\":[\"" + e.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }
        public async Task<string> MakeRequest2Async()
        {
            string response = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    response = await client.GetStringAsync(EndPoint);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine($"Message: {e.Message}");
                }
                return response;
            }
        }
    }
}
