namespace ObserverPattern.Subject
{
    using Observer;

    public interface IAccount
    {
        void Attach(IClient subject);

        void Detach(IClient subject);

        void Notify(string message);
    }
}