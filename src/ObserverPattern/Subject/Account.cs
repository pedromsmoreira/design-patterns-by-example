namespace ObserverPattern.Subject
{
    using System.Collections.Generic;
    using Observer;

    public abstract class Account : IAccount, IObservable<IBankClientObserver>
    {
        private readonly IList<IBankClientObserver> observers;

        protected Account(string type)
        {
            this.Type = type;
            this.observers = new List<IBankClientObserver>();
        }

        public string Type { get; }

        public void Attach(IBankClientObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IBankClientObserver
            observer)
        {
            this.observers.Remove(observer);
        }

        protected virtual void Notify(ITransaction transactionEvent)
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this, transactionEvent);
            }
        }
    }
}