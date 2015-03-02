
namespace EWay.Api.Model
{
    /// <summary>
    /// Response object for Customer
    /// </summary>
    public class CustomerResponse : Customer
    {
        /// <summary>
        /// The Token customer’s masked credit card number.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// The Token customer’s card holder name.
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// The Token customer’s card expiry month.
        /// </summary>
        public string CardExpiryMonth { get; set; }

        /// <summary>
        /// The Token customer’s card expiry year.
        /// </summary>
        public string CardExpiryYear { get; set; }

        /// <summary>
        /// The Token customer’s card valid from month.
        /// UK Only.
        /// </summary>
        public string CardStartMonth { get; set; }

        /// <summary>
        /// The Token customer’s card valid from year.
        /// UK Only.
        /// </summary>
        public string CardStartYear { get; set; }

        /// <summary>
        /// The Token customer’s card issue number.
        /// UK Only.
        /// </summary>
        public string CardIssueNumber { get; set; }
    }
}
