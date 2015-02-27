
namespace EWay.Api.Model
{
    /// <summary>
    /// Enumeration of possible request methods
    /// </summary>
    public enum Methods
    {
        /// <summary>
        /// This method allows merchants to process a standard payment.
        /// </summary>
        ProcessPayment,

        /// <summary>
        /// This method allows merchants to create token customers without processing a payment.
        /// </summary>
        CreateTokenCustomer,

        /// <summary>
        /// This method allows merchants to update existing token customers without processing a payment.
        /// </summary>
        UpdateTokenCustomer,

        /// <summary>
        /// This method allows merchants to process payments using Token customers they have stored with eWAY. 
        /// Merchants can either load an existing token customer by passing in their TokenCustomerID in the initial request, or create a new Token customer by leaving the TokenCustomerID field blank (Transparent Redirect and Responsive Shared Page only).
        /// </summary>
        TokenPayment,

        /// <summary>
        /// This transaction type will hold an amount on the customer’s card without charging it until a Capture request is sent. 
        /// Currently only available for Australian merchants.
        /// </summary>
        Authorise
    }
}
