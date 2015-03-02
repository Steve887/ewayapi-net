
namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response class for pre auth
    /// </summary>
    public class PreAuthResponse : BaseResponse
    {
        /// <summary>
        /// The authorisation code for this transaction as returned by the bank.
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// One or more response codes that describes the reqult of the action performed.
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Whether the transaction succeeded.
        /// </summary>
        public bool TransactionStatus { get; set; }

        /// <summary>
        /// A unique identifier that represents the transaction in eWay's system.
        /// </summary>
        public int? TransactionID { get; set; }
    }
}
