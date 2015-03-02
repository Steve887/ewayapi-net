
namespace EWay.Api.Model.Response
{
    /// <summary>
    /// Base class for create access code calls
    /// </summary>
    public class BaseCreateCodeResponse : BaseResponse
    {        
        /// <summary>
        /// Order payment details.
        /// </summary>
        public Payment Payment { get; set; }
    }
}
