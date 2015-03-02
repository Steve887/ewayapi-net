using System.Net;
using EWay.Api.Model.Response;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Token Customer endpoint
    /// </summary>
    public class TokenClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public TokenClient(string apiKey, string password, bool sandbox = false) 
            : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public TokenClient(NetworkCredential credential, bool sandbox = false) 
            : base(credential, sandbox)
        {
        }

        /// <summary>
        /// Queries a token customer.
        /// </summary>
        /// <param name="tokenCustomerId">The Token Customer ID.</param>
        /// <returns></returns>
        public CustomerQueryResponse QueryCustomer(string tokenCustomerId)
        {
            return RunHttpRequest<CustomerQueryResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "Customer/" + tokenCustomerId), Verb.Get);
        }
    }
}
