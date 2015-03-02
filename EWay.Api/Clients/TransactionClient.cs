using System.Net;
using EWay.Api.Model.Request;
using EWay.Api.Model.Response;

namespace EWay.Api.Clients
{
    /// <summary>
    /// Client for the Transaction endpoint
    /// </summary>
    public class TransactionClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="password">The password.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public TransactionClient(string apiKey, string password, bool sandbox = false) 
            : base(apiKey, password, sandbox)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionClient"/> class.
        /// </summary>
        /// <param name="credential">The network credential.</param>
        /// <param name="sandbox">if set to <c>true</c> [sandbox].</param>
        public TransactionClient(NetworkCredential credential, bool sandbox = false) 
            : base(credential, sandbox)
        {
        }

        /// <summary>
        /// Refunds a transaction.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>
        /// Response class
        /// </returns>
        public AccessResponse RefundTransaction(RefundRequest request, string transactionId)
        {
            return RunHttpRequest<AccessResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "Transaction/" + transactionId + "/Refund"));
        }

        /// <summary>
        /// Queries a previous transaction.
        /// </summary>
        /// <param name="transactionId">The transaction ID OR Access Code.</param>
        /// <returns></returns>
        public TransactionQueryResponse QueryTransaction(string transactionId)
        {
            return RunHttpRequest<TransactionQueryResponse>(null, string.Format(Sandbox ? Endpoints.SandboxUrlFormat : Endpoints.LiveUrlFormat, "Transaction/" + transactionId), Verb.Get);
        }
    }
}
