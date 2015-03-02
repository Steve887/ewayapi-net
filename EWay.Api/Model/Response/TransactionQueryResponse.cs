using System.Collections.Generic;

namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response class for transaction queries
    /// </summary>
    public class TransactionQueryResponse : BaseResponse
    {
        /// <summary>
        /// List of transaction data.
        /// </summary>
        public List<AccessResponse> Transactions { get; set; }
    }
}
