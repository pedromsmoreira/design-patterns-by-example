namespace ObserverPattern.Subject
{
    using Observer;

    public interface IAccount : IObservable<IClientObserver>
    {
        string Type { get; }

        void Notify(string message);
    }
}