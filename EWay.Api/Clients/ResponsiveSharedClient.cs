using System.Net;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Responsive Shared page endpoint
    /// </summary>
    public class ResponsiveSharedClient : BasePaymentClient
    {
        internal override string ClientEndpointName
        {
            get { return "AccessCodesShared"; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsiveSharedClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public ResponsiveSharedClient(string apiKey, string password, bool sandbox = false) 
            : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsiveSharedClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public ResponsiveSharedClient(NetworkCredential credential, bool sandbox = false) 
            : base(credential, sandbox)
        {
        }
    }
}
