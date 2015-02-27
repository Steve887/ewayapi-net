
namespace EWay.Api.Model
{
    /// <summary>
    /// Transaction type of the request
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Default transaction type and refers to a standard eCommerce transaction using CVN and 3D Secure if available.
        /// </summary>
        Purchase,

        /// <summary>
        /// Allows a merchant to process transactions through their system on behalf of the customer. 
        /// Used in situations such as manual orders through a shopping cart admin area when taking a payment over the phone.
        /// </summary>
        MOTO,

        /// <summary>
        /// When using an automated billing system you must flag transactions as recurring. 
        /// This means that the CVN is not required to process the transaction. 
        /// Note that usually the merchants bank requires that they have already processed a fully authorised transaction with CVN for that credit card for a recurring transaction to be approved.
        /// </summary>
        Recurring
    }
}
