
namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Settlement request
    /// </summary>
    public class SettlementRequest : BaseRequest
    {
        /// <summary>
        /// One of Both, SummaryOnly or TransactionOnly.
        /// </summary>
        public string ReportMode { get; set; }

        /// <summary>
        /// A settlement date to query.
        /// Formatted as YYYY-MM-DD
        /// </summary>
        public string SettlementDate { get; set; }

        /// <summary>
        /// The start date of the filtered date range.
        /// Formatted as YYYY-MM-DD
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// The end date of the filtered date range.
        /// Formatted as YYYY-MM-DD
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// The code for the card type to filter.
        /// One of: ALL, VI (Visa), MC (Mastercard), AX (AMEX), DC (Diners Club), JC (JCB), MD (Maestro UK), MI (Maestro International), SO (Solo), LA (Laser), DS (Discover)
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// The ISO 4217 formatted currency to filter the report by.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The page number to retrieve.
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// The number of records to retrieve per page.
        /// </summary>
        public int? PageSize { get; set; }
    }
}
