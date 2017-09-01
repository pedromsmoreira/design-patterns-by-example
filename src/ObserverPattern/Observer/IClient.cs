namespace ObserverPattern.Observer
{
    using Subject;

    public interface IClient
    {
        string Name { get; }

        void Update(Account account, string message);
    }
}