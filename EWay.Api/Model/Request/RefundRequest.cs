using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Refund request
    /// </summary>
    public class RefundRequest : BaseRequest
    {
        /// <summary>
        /// Details of the refund.
        /// </summary>
        public Payment Refund { get; set; }
    }
}
