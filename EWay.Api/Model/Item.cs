using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWay.Api.Model
{
    /// <summary>
    /// The Items section is optional. If provided, it should contain a list of line items purchased by the customer, up to a maximum of 99 items.
    /// It is used by Beagle Fraud Alerts (Enterprise) to calculate a risk score for this transaction.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The stock keeping unit or name used to identify this line item.
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// A brief description of the product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The purchased quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The pre-tax cost per unit of the product in the lowest denomination.
        /// Eg. 500 for $5.00
        /// </summary>
        public int UnitCost { get; set; }

        /// <summary>
        /// The tax amount that applies to this line item in the lowest denomination.
        /// Eg. 500 for $5.00
        /// </summary>
        public int Tax { get; set; }

        /// <summary>
        /// The total amount charged for this line item in the lowest denomination.
        /// Eg. 500 for $5.00
        /// </summary>
        public int Total { get; set; }
    }
}
