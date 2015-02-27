
namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response for Shared Page requests
    /// </summary>
    public class SharedPageResponse : BaseCreateCodeResponse
    {
        /// <summary>
        /// A unique access code that is used to identify this transaction with Rapid API.
        /// This code will need to be present for all future requests associated with this transaction.
        /// </summary>
        public string AccessCode { get; set; }
        
        /// <summary>
        /// The URL to redirect the customer to enter their card details.
        /// </summary>
        public string SharedPaymentUrl { get; set; }

        /// <summary>
        /// Details of the customer.
        /// </summary>
        public CustomerResponse Customer { get; set; }
    }
}
