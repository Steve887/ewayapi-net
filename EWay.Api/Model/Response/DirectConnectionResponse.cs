
using System.Collections.Generic;

namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response object for Direct Connection calls
    /// </summary>
    public class DirectConnectionResponse : BaseCreateCodeResponse, IAccessResponse
    {        
        /// <summary>
        /// Details of the customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// An echo of the access code used in the request.
        /// </summary>
        public string AccessCode { get; set; }

        /// <summary>
        /// The authorisation code for this transaction as returned by the bank.
        /// </summary>
        public string AuthorisationCode { get; set; }

        /// <summary>
        /// The two digit response code returned from the bank.
        /// </summary>
        public string ResponseCode { get; set; }

        /// <summary>
        /// One or more Response Codes that describes the result of the action performed.
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// An echo of the merchant’s invoice number for this transaction.
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// An echo of the merchant’s reference number for this transaction.
        /// </summary>
        public string InvoiceReference { get; set; }

        /// <summary>
        /// The amount that was authorised for this transaction.
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// A unique identifier that represents the transaction in eWAY’s system.
        /// </summary>
        public int? TransactionID { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether the transaction was successful or not.
        /// </summary>
        public bool? TransactionStatus { get; set; }

        /// <summary>
        /// An eWAY-issued ID that represents the Token customer that was loaded or created for this transaction (if applicable).
        /// </summary>
        public long? TokenCustomerID { get; set; }

        /// <summary>
        /// Fraud score representing the estimated probability that the order is fraud, based off analysis of past Beagle Fraud Alerts transactions. 
        /// This field will only be returned for transactions using the Beagle Free gateway.
        /// </summary>
        public string BeagleScore { get; set; }

        /// <summary>
        /// List of additional options.
        /// </summary>
        public List<Option> Options { get; set; }

        /// <summary>
        /// Currently unused.
        /// </summary>
        public Verification Verification { get; set; }

        /// <summary>
        /// Results of the Beagle Verification identification checks that may have been performed.
        /// </summary>
        public BeagleVerification BeagleVerification { get; set; }
    }
}
