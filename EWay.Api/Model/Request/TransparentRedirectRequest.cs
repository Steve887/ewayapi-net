
namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Request object for the Transparent Redirect endpoint
    /// </summary>
    public class TransparentRedirectRequest : BaseRequest
    {
        /// <summary>
        /// The web address the customer is redirected to with the result of the action.
        /// </summary>
        public string RedirectUrl { get; set; }
        
        /// <summary>
        /// If true, will process a PayPal Checkout payment.
        /// </summary>
        internal bool CheckoutPayment { get; set; }

        /// <summary>
        /// When CheckoutPayment is true, must be specified for customer to be returned to after logging into their PayPal account.
        /// </summary>
        public string CheckoutUrl { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentRedirectRequest" /> class.
        /// </summary>
        /// <param name="redirectUrl">The web address the customer is redirected to with the result of the action.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        public TransparentRedirectRequest(string redirectUrl, TransactionType transactionType) 
            : base (transactionType)
        {
            RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransparentRedirectRequest" /> class.
        /// </summary>
        /// <param name="redirectUrl">The web address the customer is redirected to with the result of the action.</param>
        /// <param name="checkoutUrl">The URL the customer is to be returned to after logging into their PayPal account.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        public TransparentRedirectRequest(string redirectUrl, string checkoutUrl, TransactionType transactionType)
            : base(transactionType)
        {
            RedirectUrl = redirectUrl;
            CheckoutPayment = true;
            CheckoutUrl = checkoutUrl;
        }
    }
}
