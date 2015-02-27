
namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response for Transparent Redirect requests
    /// </summary>
    public class TransparentRedirectResponse : BaseCreateCodeResponse
    {
        /// <summary>
        /// A unique access code that is used to identify this transaction with Rapid API.
        /// This code will need to be present for all future requests associated with this transaction.
        /// </summary>
        public string AccessCode { get; set; }
        
        /// <summary>
        /// The URL that the form should be POSTed to.
        /// </summary>
        public string FormActionURL { get; set; }
        
        /// <summary>
        /// Gets or sets the complete checkout URL.
        /// </summary>
        public string CompleteCheckoutURL { get; set; }

        /// <summary>
        /// Details of the customer.
        /// </summary>
        public CustomerResponse Customer { get; set; }
    }
}
