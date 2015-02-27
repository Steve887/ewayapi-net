
namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Request object for the Direct Connection endpoint
    /// </summary>
    public class DirectConnectionRequest : BaseRequest
    {
        /// <summary>
        /// The wallet ID of a third party wallet used for a payment.
        /// Currently used for Visa Checkout transactions.
        /// </summary>
        public string ThirdPartyWalletID { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectConnectionRequest"/> class.
        /// </summary>
        /// <param name="transactionType">Type of the transaction.</param>
        public DirectConnectionRequest(TransactionType transactionType) 
            : base(transactionType)
        {
        }
    }
}
