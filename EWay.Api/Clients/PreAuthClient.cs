using System.Net;
using EWay.Api.Model.Request;
using EWay.Api.Model.Response;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Pre Auth endpoint
    /// </summary>
    public class PreAuthClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreAuthClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public PreAuthClient(string apiKey, string password, bool sandbox = false)
            : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreAuthClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public PreAuthClient(NetworkCredential credential, bool sandbox = false)
            : base(credential, sandbox)
        {
        }

        /// <summary>
        /// Completes a pre-authorised payment.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public PreAuthResponse CapturePayment(PreAuthRequest request)
        {
            return RunHttpRequest<PreAuthResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "CapturePayment"));
        }

        /// <summary>
        /// Cancels a pre-authorised payment.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public PreAuthResponse CancelAuthorisation(PreAuthRequest request)
        {
            return RunHttpRequest<PreAuthResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "CancelAuthorisation"));
        }
    }
}
