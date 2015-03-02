using System.Net;
using EWay.Api.Model;
using EWay.Api.Model.Request;
using EWay.Api.Model.Response;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Base class for API clients
    /// </summary>
    public abstract class BasePaymentClient : BaseClient
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
            get { return string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, ClientEndpointName); }
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BasePaymentClient" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        protected BasePaymentClient(string apiKey, string password, bool sandbox = false) : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePaymentClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        protected BasePaymentClient(NetworkCredential credential, bool sandbox = false) : base(credential, sandbox)
        {
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
             return RunHttpRequest<AccessResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "AccessCode/" + accessCode), Verb.Get);
        }

        internal override T RunHttpRequest<T>(BaseRequest request, string endpoint = null, Verb verb = Verb.Post)
        {
            return base.RunHttpRequest<T>(request, endpoint ?? ClientEndpoint, verb);
        }
    }
}
