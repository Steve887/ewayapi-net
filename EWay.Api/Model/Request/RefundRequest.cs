
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
