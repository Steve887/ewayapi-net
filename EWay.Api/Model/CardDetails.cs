
using System.Security.Principal;

namespace EWay.Api.Model
{
    /// <summary>
    /// Customer card details
    /// </summary>
    public class CardDetails
    {
        /// <summary>
        /// The name of the card holder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The card number that is to be processed for this transaction.
        /// Not required when processing using an existing CustomerTokenID with TokenPayment method.
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// The month that the card expires.
        /// Not required when processing using an existing CustomerTokenID with TokenPayment method.
        /// </summary>
        public int? ExpiryMonth { get; set; }

        /// <summary>
        /// The year that the card expires.
        /// Not required when processing using an existing CustomerTokenID with TokenPayment method.
        /// </summary>
        public int? ExpiryYear { get; set; }

        /// <summary>
        /// The month that the card is valid from.
        /// UK Only.
        /// </summary>
        public int? StartMonth { get; set; }

        /// <summary>
        /// The year that the card is valid from.
        /// UK Only.
        /// </summary>
        public int? StartYear { get; set; }

        /// <summary>
        /// The card’s issue number.
        /// UK Only.
        /// </summary>
        public int? IssueNumber { get; set; }

        /// <summary>
        /// The Card Verification Number.
        /// </summary>
        public int? CVN { get; set; }
    }
}
