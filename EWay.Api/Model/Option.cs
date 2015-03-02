
namespace EWay.Api.Model
{
    /// <summary>
    /// This section is optional. Anything appearing in this section is not displayed to the customer, but it is returned to the merchant in the result. 
    /// Up to 99 options can be defined. 
    /// </summary>
    public class Option
    {
        /// <summary>
        /// This field is not displayed to the customer but is returned in the result. 
        /// Anything can be used here, which can be useful for tracking transactions. 
        /// Additional characters are truncated at 254.
        /// </summary>
        public string Value { get; set; }
    }
}
