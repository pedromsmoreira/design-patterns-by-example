namespace ObserverPattern.ConcreteObserver
{
    using System;
    using ConcreteSubject;
    using Observer;
    using Subject;

    public class BankClient : IClient
    {
        private readonly BankAccount clientAccount;

        public BankClient(string name, BankAccount account)
        {
            this.Name = name;
            this.AccessTime = DateTime.UtcNow;
            this.clientAccount = account;
        }

        public string Name { get; }

        public DateTime AccessTime { get; }

        public void Deposit(decimal amount)
        {
            this.clientAccount.Deposit(this.Name, amount);
        }

        public void Withdraw(decimal amount)
        {
            this.clientAccount.Withdraw(this.Name, amount);
        }

        public void Update(Account account, string message)
        {
            Console.WriteLine($"Notified {this.Name} about transaction in {this.clientAccount.Type}");
            Console.WriteLine(message);
        }
    }
}