
namespace EWay.Api.Model
{
    /// <summary>
    /// Results of the Beagle Verification identification checks that may have been performed.
    /// </summary>
    public class BeagleVerification
    {
        /// <summary>
        /// The result of the email verification.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// The result of the phone verification.
        /// </summary>
        public string Phone { get; set; }
    }
}
