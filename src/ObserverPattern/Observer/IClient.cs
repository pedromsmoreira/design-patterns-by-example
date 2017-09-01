namespace ObserverPattern.Observer
{
    using Subject;

    public interface IClient
    {
        string Name { get; }

        void Update(IAccount account, string message);
    }
}