namespace ObserverPattern.Subject
{
    using System.Collections.Generic;
    using Observer;

    public abstract class Account : IAccount
    {
        private readonly IList<IClientObserver> observers;

        protected Account(string type)
        {
            this.Type = type;
            this.observers = new List<IClientObserver>();
        }

        public string Type { get; }

        public void Attach(IClientObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IClientObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this, message);
            }
        }
    }
}