using System.IO;
using System.Net;
using EWay.Api.Model.Request;
using EWay.Api.Model.Response;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Base class for API clients
    /// </summary>
    public abstract class BaseClient
    {
        internal readonly bool Sandbox;
        private readonly NetworkCredential credential;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClient" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        protected BaseClient(string apiKey, string password, bool sandbox = false) : this(new NetworkCredential(apiKey, password), sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        protected BaseClient(NetworkCredential credential, bool sandbox = false)
        {
            this.credential = credential;
            Sandbox = sandbox;
        }

        internal virtual T RunHttpRequest<T>(BaseRequest request, string endpoint = null, Verb verb = Verb.Post) where T : BaseResponse
        {
            if (endpoint == null)
            {
                return null;
            }

            string action;
            string responseString = string.Empty;

            switch (verb)
            {
                case Verb.Get:
                    action = "GET";
                    break;
                default:
                    action = "POST";
                    break;
            }

            ServicePointManager.Expect100Continue = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint);
            httpWebRequest.ContentType = "application/json; charset=utf-8;";
            httpWebRequest.Method = action;
            httpWebRequest.Credentials = credential;
            
            if (action != "GET")
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(JsoNify(request));
                    streamWriter.Flush();
                }
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var responseStream = httpResponse.GetResponseStream();
            if (responseStream != null)
            {
                using (var streamReader = new StreamReader(responseStream))
                {
                    responseString = streamReader.ReadToEnd();
                }
            }

            return JsonConvert.DeserializeObject<T>(responseString);
        }

        private static string JsoNify(BaseRequest request)
        {
            return JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
       
        internal enum Verb
        {
            Get,
            Post,
        }
    }
}
