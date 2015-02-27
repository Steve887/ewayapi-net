
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using EWay.Api.Model;
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
        /// <summary>
        /// The name of the client endpoint being used.
        /// </summary>
        internal abstract string ClientEndpointName { get; }

        /// <summary>
        /// The formatted endpoint URL.
        /// </summary>
        internal string ClientEndpoint
        {
            get { return string.Format(sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, ClientEndpointName); }
        }

        private readonly bool sandbox;
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
            this.sandbox = sandbox;
        }

        /// <summary>
        /// Allows merchants to process a standard payment.
        /// </summary>
        /// <typeparam name="T">Request object type</typeparam>
        /// <param name="request">The concrete request class.</param>
        /// <returns>The appropriate response class</returns>
        public virtual T ProcessPayment<T>(BaseRequest request) where T : BaseCreateCodeResponse
        {
            request.Method = Methods.ProcessPayment;
            return RunHttpRequest<T>(request);
        }

        /// <summary>
        /// Allows merchants to create token customers without processing a payment.
        /// </summary>
        /// <typeparam name="T">Request object type</typeparam>
        /// <param name="request">The concrete request class.</param>
        /// <returns>The appropriate response class</returns>
        public virtual T CreateTokenCustomer<T>(BaseRequest request) where T : BaseCreateCodeResponse
        {
            request.Method = Methods.CreateTokenCustomer;
            return RunHttpRequest<T>(request);
        }

        /// <summary>
        /// Allows merchants to update existing token customers without processing a payment.
        /// </summary>
        /// <typeparam name="T">Request object type</typeparam>
        /// <param name="request">The concrete request class.</param>
        /// <returns>The appropriate response class</returns>
        public virtual T UpdateTokenCustomer<T>(BaseRequest request) where T : BaseCreateCodeResponse
        {
            request.Method = Methods.UpdateTokenCustomer;
            return RunHttpRequest<T>(request);
        }

        /// <summary>
        /// Allows merchants to process payments using Token customers they have stored with eWAY.
        /// </summary>
        /// <typeparam name="T">Request object type</typeparam>
        /// <param name="request">The concrete request class.</param>
        /// <returns>The appropriate response class</returns>
        public virtual T TokenPayment<T>(BaseRequest request) where T : BaseCreateCodeResponse
        {
            request.Method = Methods.TokenPayment;
            return RunHttpRequest<T>(request);
        }

        /// <summary>
        /// This method allows merchants to process a standard payment.
        /// </summary>
        /// <typeparam name="T">Request object type</typeparam>
        /// <param name="request">The concrete request class.</param>
        /// <returns>The appropriate response class</returns>
        public virtual T Authorise<T>(BaseRequest request) where T : BaseCreateCodeResponse
        {
            request.Method = Methods.Authorise;
            return RunHttpRequest<T>(request);
        }

        /// <summary>
        /// Gets the result of a previous request.
        /// </summary>
        /// <param name="accessCode">The access code.</param>
        /// <returns>Response class</returns>
        public virtual AccessResponse GetAccessCodeResult(string accessCode)
        {
             return RunHttpRequest<AccessResponse>(null, string.Format(sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "AccessCode/" + accessCode), Verb.Get);
        }

        /// <summary>
        /// Refunds a transaction.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>
        /// Response class
        /// </returns>
        public virtual AccessResponse RefundTransaction(RefundRequest request, string transactionId)
        {
            return RunHttpRequest<AccessResponse>(null, string.Format(sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "Transaction/" + transactionId + "/Refund"));
        }

        /// <summary>
        /// Queries a previous transaction.
        /// </summary>
        /// <param name="transactionId">The transaction ID OR Access Code.</param>
        /// <returns></returns>
        public virtual TransactionQueryResponse QueryTransaction(string transactionId)
        {
            return RunHttpRequest<TransactionQueryResponse>(null, string.Format(sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "Transaction/" + transactionId), Verb.Get);
        }

        private T RunHttpRequest<T>(BaseRequest request, string endpoint = null, Verb verb = Verb.Post) where T : BaseResponse
        {
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
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint ?? ClientEndpoint);
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
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                responseString = streamReader.ReadToEnd();
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
