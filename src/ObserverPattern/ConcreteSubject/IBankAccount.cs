namespace ObserverPattern.ConcreteSubject
{
    using Subject;

    public interface IBankAccount : IAccount
    {
        void Deposit(string owner, decimal amount);

        void Withdraw(string owner, decimal amount);
    }
}