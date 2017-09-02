namespace ObserverPattern.Subject
{
    using System.Transactions;

    public interface ITransaction
    {
        string ExecutedBy { get; }

        decimal AmountTransactioned { get; }

        decimal TotalAmount { get; }

        TransactionType TransactionType { get; }

        TransactionStatus Status { get; }
    }
}