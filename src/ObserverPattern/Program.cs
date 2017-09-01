namespace ObserverPattern
{
    using System;
    using ConcreteObserver;
    using ConcreteSubject;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern");

            // Subject
            var savingsAccount = new BankAccount("Savings Account");

            // Create Concrete Observers
            var homer = new BankClient("Homer Simpson", savingsAccount);
            var marge = new BankClient("Marge Simpson", savingsAccount);

            // Attach observers
            savingsAccount.Attach(homer);
            savingsAccount.Attach(marge);

            // Lets observe the transactions
            homer.Deposit(100);
            marge.Withdraw(50);
            homer.Withdraw(51);
            marge.Deposit(-100);

            // Final value should be $350
            marge.Deposit(300);

            Console.ReadLine();
        }
    }
}