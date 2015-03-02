using System.Net;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Transparent Redirect endpoint
    /// </summary>
    public class TransparentRedirectClient : BasePaymentClient
    {
        internal override string ClientEndpointName
        {
            get { return "AccessCodes"; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentRedirectClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public TransparentRedirectClient(string apiKey, string password, bool sandbox = false) : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentRedirectClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public TransparentRedirectClient(NetworkCredential credential, bool sandbox = false) : base(credential, sandbox)
        {
        }
    }
}
