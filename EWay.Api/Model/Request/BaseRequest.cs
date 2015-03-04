using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Base object for making requests to the eWAY API.
    /// </summary>
    public abstract class BaseRequest
    {
        /// <summary>
        /// The customer's IP address.
        /// </summary>
        public string CustomerIP { get; set; }

        /// <summary>
        /// The action to perform with this request.
        /// One of: ProcessPayment, CreateTokenCustomer, UpdateTokenCustomer, TokenPayment, Authorise
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Methods Method { get; set; }

        /// <summary>
        /// The type of transaction being performed.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// The identification name/number for the device or application used to process the transaction.
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        /// The partner ID generated from an eWAY partner agreement.
        /// </summary>
        public string PartnerID { get; set; }

        /// <summary>
        /// Details of the customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Shipping details of the order.
        /// </summary>
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// List of items contained in the order.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// List of additional options.
        /// </summary>
        public List<Option> Options { get; set; }

        /// <summary>
        /// Order payment details.
        /// </summary>
        public Payment Payment { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequest"/> class.
        /// </summary>
        /// <param name="transactionType">Type of the transaction.</param>
        protected BaseRequest(TransactionType transactionType) : this()
        {
            TransactionType = transactionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRequest"/> class.
        /// </summary>
        protected BaseRequest()
        {
            Customer = new Customer();
            ShippingAddress = new ShippingAddress();
            Items = new List<Item>();
            Options = new List<Option>();
            Payment = new Payment();
        }
    }
}
