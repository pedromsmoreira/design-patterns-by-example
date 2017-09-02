namespace ObserverPattern.Subject
{
    public interface IAccount
    {
        string Type { get; }

        void Notify(string message);
    }
}