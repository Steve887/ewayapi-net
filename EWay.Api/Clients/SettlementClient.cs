using System.Net;
using EWay.Api.Model.Request;
using EWay.Api.Model.Response;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Settlement endpoint
    /// </summary>
    public class SettlementClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public SettlementClient(string apiKey, string password, bool sandbox = false)
            : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public SettlementClient(NetworkCredential credential, bool sandbox = false)
            : base(credential, sandbox)
        {
        }

        /// <summary>
        /// Completes a pre-authorised payment.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public SettlementResponse Search(SettlementRequest request)
        {
            return RunHttpRequest<SettlementResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "Search/Settlement", Verb.Get));
        }
    }
}
