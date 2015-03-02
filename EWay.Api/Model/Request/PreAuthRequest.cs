
namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Pre Auth request
    /// </summary>
    public class PreAuthRequest : BaseRequest
    {
        /// <summary>
        /// Transaction ID of the Authorisation to capture.
        /// </summary>
        public string TransactionId { get; set; }
    }
}
