
namespace EWay.Api.Model
{
    /// <summary>
    /// Details of the merchant’s customer. Used when creating and updating Token customers.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// An eWAY-issued ID that represents the Token customer to be loaded for this action.
        /// Required for UpdateTokenCustomer method.
        /// </summary>
        public long? TokenCustomerID { get; set; }

        /// <summary>
        /// The merchant's reference for this customer.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// The customer's title, empty string allowed, which will default to Mr.
        /// One of: Mr., Ms., Mrs., Miss, Dr., Sir., Prof.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The customer's company name.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The customer's job description/title.
        /// </summary>
        public string JobDescription { get; set; }

        /// <summary>
        /// The customer's street address.
        /// </summary>
        public string Street1 { get; set; }

        /// <summary>
        /// The customer's street address.
        /// </summary>
        public string Street2 { get; set; }

        /// <summary>
        /// The customer's city/town/suburb.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The customer's state/county.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The customer's post/zip code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The customer's country.
        /// Should be lower case two letter ISO 3166-1 alpha-2 code.
        /// Eg. Australia = au.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The customer's email address, correctly formatted.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The customer's mobile phone number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Any comments the merchant wishes to add about the customer.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// The customer's fax number.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The customer's website, correctly formatted.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Customer card details.
        /// For Direct Connection calls only
        /// </summary>
        public CardDetails CardDetails { get; set; }
    }
}
