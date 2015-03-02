using System.Collections.Generic;

namespace EWay.Api.Model
{
    /// <summary>
    /// Settlement summary model
    /// </summary>
    public class SettlementSummary
    {
        /// <summary>
        /// The unique ID of the settlement.
        /// </summary>
        public string SettlementID { get; set; }

        /// <summary>
        /// The numeric code for the currency of the settlement.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The ISO 4217 code that represents the currency for the settlement.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The total amount credited in the settlement in cents.
        /// </summary>
        public int? TotalCredit { get; set; }

        /// <summary>
        /// The total amount debited in the settlement in cents.
        /// </summary>
        public int? TotalDebit { get; set; }

        /// <summary>
        /// The total balance settled in this settlement in cents.
        /// </summary>
        public int? TotalBalance { get; set; }

        /// <summary>
        /// Balance for each card type.
        /// </summary>
        public List<BalanceCardType> BalancePerCardType { get; set; }
    }

    /// <summary>
    /// Card Type balances
    /// </summary>
    public class BalanceCardType
    {
        /// <summary>
        /// The code of the card type of this settlement.
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// The number of transactions in this settlement.
        /// </summary>
        public int? NumberOfTransactions { get; set; }

        /// <summary>
        /// The amount credited in this settlement.
        /// </summary>
        public int? Credit { get; set; }

        /// <summary>
        /// The amount debited in this settlement.
        /// </summary>
        public int? Debit { get; set; }

        /// <summary>
        /// The balance settlted in this settlement.
        /// </summary>
        public int? Balance { get; set; }
    }

    /// <summary>
    /// Settlement Transaction model
    /// </summary>
    public class SettlementTransaction
    {
        /// <summary>
        /// The unique ID of the settlement.
        /// </summary>
        public string SettlementID { get; set; }

        /// <summary>
        /// The eWAY Customer ID associated with this settlement transaction.
        /// </summary>
        public int? eWAYCustomerID { get; set; }

        /// <summary>
        /// The unique ID of the transaction.
        /// </summary>
        public int? TransactionID { get; set; }

        /// <summary>
        /// The unique Transaction ID as returned from the bank.
        /// </summary>
        public string TxnReference { get; set; }

        /// <summary>
        /// The amount of the settlement transaction in cents.
        /// </summary>
        public int? Amount { get; set; }

        /// <summary>
        /// A numeric representation of the transaction type.
        /// 1 = Purchase, 4 = Refund, 8 = Capture
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// The date and time of the transasction.
        /// </summary>
        public string TransactionDateTime { get; set; }

        /// <summary>
        /// The date and time the transaction settled.
        /// </summary>
        public string SettlementDateTime { get; set; }
    }
}
