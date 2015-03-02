using System.Collections.Generic;

namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response class for settlement
    /// </summary>
    public class SettlementResponse : BaseResponse
    {
        /// <summary>
        /// List of settlement queried.
        /// </summary>
        public List<SettlementSummary> SettlementSummaries { get; set; }

        /// <summary>
        /// List of transactions that occured in the settlement.
        /// </summary>
        public List<SettlementTransaction> SettlementTransactions { get; set; }
    }
}
