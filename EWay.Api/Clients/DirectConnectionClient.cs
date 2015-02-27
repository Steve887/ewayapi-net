using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EWay.Api.Model.Response;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Direct Connection endpoint
    /// </summary>
    public class DirectConnectionClient : BaseClient
    {
        internal override string ClientEndpointName
        {
            get { return "Transaction"; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectConnectionClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public DirectConnectionClient(string apiKey, string password, bool sandbox = false) 
            : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectConnectionClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public DirectConnectionClient(NetworkCredential credential, bool sandbox = false) 
            : base(credential, sandbox)
        {
        }

    }
}
