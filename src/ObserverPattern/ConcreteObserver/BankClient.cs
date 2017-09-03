namespace ObserverPattern.ConcreteObserver
{
    using System;
    using ConcreteSubject;
    using Observer;
    using Subject;

    public class BankClient : IBankClient, IBankClientObserver
    {
        private readonly IBankAccount clientAccount;

        public BankClient(string name, IBankAccount account)
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

        public void Update(IAccount subject, ITransaction observedEvent)
        {
            Console.WriteLine($"Notified {this.Name} about transaction in {this.clientAccount.Type}");
            TransactionDetails(observedEvent);
        }

        private static void TransactionDetails(ITransaction transaction)
        {
            Console.WriteLine($"Transaction Executed By: {transaction.ExecutedBy}");
            Console.WriteLine($"Transaction Type: {transaction.TransactionType}");
            Console.WriteLine($"Transaction Status: {transaction.Status}");
            Console.WriteLine($"Transaction Amount Transactioned: {transaction.AmountTransactioned}");
            Console.WriteLine($"Transaction Total Amount: {transaction.TotalAmount}");
        }
    }
}