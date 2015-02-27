
namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Base class for API responses
    /// </summary>
    public abstract class BaseResponse
    {
        /// <summary>
        /// A comma separated list of any error encountered.
        /// </summary>
        public string Errors { get; set; }
    }
}
