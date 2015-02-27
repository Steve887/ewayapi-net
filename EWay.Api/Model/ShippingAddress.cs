
namespace EWay.Api.Model
{
    /// <summary>
    /// The Shipping Address section is optional. It is used by Beagle Fraud Alerts (Enterprise) to calculate a risk score for this transaction.
    /// </summary>
    public class ShippingAddress
    {
        /// <summary>
        /// The method used to ship the customer's order.
        /// One of: Unknown, LowCost, DesignatedByCustomer, International, Military, NextDay, StorePickup, TwoDayService, ThreeDayService, Other
        /// </summary>
        public string ShippingMethod { get; set; }

        /// <summary>
        /// The first name of the person the order is shipped to.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person the order is shipped to.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The street address the order is shipped to.
        /// </summary>
        public string Street1 { get; set; }

        /// <summary>
        /// The street address the order is shipped to.
        /// </summary>
        public string Street2 { get; set; }

        /// <summary>
        /// The shipping city/town/suburb.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The shipping state/county.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The shipping post/zip code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The shipping country.
        /// Should be lower case two letter ISO 3166-1 alpha-2 code.
        /// Eg. Australia = au.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The shipping email address, correctly formatted.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the person the order is shipped to.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The fax number of the shipping location.
        /// </summary>
        public string Fax { get; set; }
    }
}
