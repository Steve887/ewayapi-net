using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWay.Api.Model
{
    /// <summary>
    /// This set of fields contains the details of the payment being processed. This section is required when the Method field is set to ProcessPayment or TokenPayment.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// The amount of the transaction in the lowest denomination for the currency.
        /// Must be 0 for CreateTokenCustomer and UpdateTokenCustomer requests.
        /// Required for ProcessPayment and TokenPayment requests.
        /// Eg. 2700 for $27.00.
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// The merchant's invoice number for this transaction.
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// A short description of the purchase that the customer is making.
        /// </summary>
        public string InvoiceDescription { get; set; }

        /// <summary>
        /// The merchant's reference number for this transaction.
        /// </summary>
        public string InvoiceReference { get; set; }

        /// <summary>
        /// The uppercase ISO 4217 3 character code that represents the currency this transaction is the be processed in.
        /// If no value is provided, the merchant's default current is used.
        /// Eg. Australian Dollars = AUD
        /// </summary>
        public string CurrencyCode { get; set; }
    }
}
