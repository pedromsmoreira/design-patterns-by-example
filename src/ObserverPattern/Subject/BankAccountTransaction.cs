namespace ObserverPattern.Subject
{
    using System.Transactions;

    public class BankAccountTransaction : ITransaction
    {
        public BankAccountTransaction(string owner, decimal amountTransactioned, decimal totalAmount, TransactionType type, TransactionStatus status)
        {
            this.ExecutedBy = owner;
            this.AmountTransactioned = amountTransactioned;
            this.TotalAmount = totalAmount;
            this.TransactionType = type;
            this.Status = status;
        }

        public string ExecutedBy { get; }

        public decimal AmountTransactioned { get; }

        public decimal TotalAmount { get; }

        public TransactionType TransactionType { get; }

        public TransactionStatus Status { get; }
    }
}