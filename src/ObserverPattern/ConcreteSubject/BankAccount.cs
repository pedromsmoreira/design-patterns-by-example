namespace ObserverPattern.ConcreteSubject
{
    using System.Transactions;
    using Subject;

    public class BankAccount : Account, IBankAccount
    {
        public BankAccount(string type) : base(type)
        {
            this.Amount = decimal.Zero;
        }

        public decimal Amount { get; private set; }

        public void Deposit(string owner, decimal amount)
        {
            if (amount > decimal.Zero)
            {
                this.Amount += amount;
                this.Notify(new BankAccountTransaction(owner, amount, this.Amount, TransactionType.Deposit, TransactionStatus.Committed));
            }
            else
            {
                this.Notify(new BankAccountTransaction(owner, amount, this.Amount, TransactionType.Deposit, TransactionStatus.Aborted));
            }
        }

        public void Withdraw(string owner, decimal amount)
        {
            if (amount > decimal.Zero && this.Amount > decimal.Zero && amount < this.Amount)
            {
                this.Amount -= amount;
                this.Notify(new BankAccountTransaction(owner, amount, this.Amount, TransactionType.Withdraw, TransactionStatus.Committed));
            }
            else
            {
                this.Notify(new BankAccountTransaction(owner, amount, this.Amount, TransactionType.Withdraw, TransactionStatus.Aborted));
            }
        }
    }
}