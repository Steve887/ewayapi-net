using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
