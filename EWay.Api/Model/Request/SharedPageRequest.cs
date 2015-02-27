
namespace EWay.Api.Model.Request
{
    /// <summary>
    /// Request object for the Shared Page endpoint
    /// </summary>
    public class SharedPageRequest : BaseRequest
    {
        /// <summary>
        /// The URL that the shared page redirects to after a payment is processed.
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The URL that the shared page redirects to if a customer cancels the transaction.
        /// </summary>
        public string CancelUrl { get; set; }

        /// <summary>
        /// The URL of the merchant's logo to display on the shared page.
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// Short text description to be placed under the logo on the shared page.
        /// </summary>
        public string HeaderText { get; set; }

        /// <summary>
        /// Language code determines the language that the shared page will be displayed in.
        /// One of: EN (English - default), ES (Spanish)
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// If false, cardholders will be able to edit the information on the shared page.
        /// </summary>
        public bool CustomerReadOnly { get; set; }

        /// <summary>
        /// Set the theme of the Responsive Shared Page.
        /// One of: Bootstrap, BootstrapAmelia, BootstrapCerulean, BootstrapCosmo, BootstrapCyborg, BootstrapFlatly, BootstrapJournal, BootstrapReadable, BootstrapSimplex, BootstrapSlate, BootstrapSpacelab, BootstrapUnited
        /// </summary>
        public string CustomView { get; set; }

        /// <summary>
        /// If true, verify the customer's phone number using Beagle Verify.
        /// </summary>
        public bool VerifyCustomerPhone { get; set; }

        /// <summary>
        /// If true, verify the customer's email using Beagle Verify.
        /// </summary>
        public bool VerifyCustomerEmail { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedPageRequest"/> class.
        /// </summary>
        /// <param name="redirectUrl">The redirect URL.</param>
        /// <param name="cancelUrl">The cancel URL.</param>
        /// <param name="transactionType">Type of the transaction.</param>
        public SharedPageRequest(string redirectUrl, string cancelUrl, TransactionType transactionType)
            : base(transactionType)
        {
            RedirectUrl = redirectUrl;
            CancelUrl = cancelUrl;
        }
    }
}
