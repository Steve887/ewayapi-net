using System.Collections.Generic;

namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Response class for customer queries
    /// </summary>
    public class CustomerQueryResponse : BaseResponse
    {
        /// <summary>
        /// List of customer data.
        /// </summary>
        public List<Customer> Customers { get; set; }
    }
}
