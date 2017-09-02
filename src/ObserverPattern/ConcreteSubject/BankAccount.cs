namespace ObserverPattern.ConcreteSubject
{
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
                this.Notify($"{owner} Deposited ${amount} | Total Amount: ${this.Amount}");
            }
            else
            {
                this.Notify($"{owner} tried to deposit an invalid amount. | Amount: ${amount}");
            }
        }

        public void Withdraw(string owner, decimal amount)
        {
            if (amount > decimal.Zero && this.Amount > decimal.Zero && amount < this.Amount)
            {
                this.Amount -= amount;
                this.Notify($"{owner} withdrawed ${amount} | Total Amount: ${this.Amount}");
            }
            else
            {
                this.Notify($"{owner} tried to withdraw an invalid amount. | Amount: ${amount}");
            }
        }
    }

    public interface IBankAccount
    {
        void Deposit(string owner, decimal amount);

        void Withdraw(string owner, decimal amount);
    }
}