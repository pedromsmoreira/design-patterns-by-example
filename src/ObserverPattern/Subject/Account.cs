namespace ObserverPattern.Subject
{
    using System.Collections.Generic;
    using Observer;

    public abstract class Account : IAccount
    {
        protected Account(string type)
        {
            this.Type = type;
            this.Owners = new List<IClient>();
        }

        public string Type { get; }

        public IList<IClient> Owners { get; }

        public void Attach(IClient subject)
        {
            this.Owners.Add(subject);
        }

        public void Detach(IClient subject)
        {
            this.Owners.Remove(subject);
        }

        public void Notify(string message)
        {
            foreach (var user in this.Owners)
            {
                user.Update(this, message);
            }
        }
    }
}