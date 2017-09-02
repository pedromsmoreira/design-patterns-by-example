namespace ObserverPattern.Observer
{
    using Subject;

    public interface IClientObserver : IObserver<IAccount>
    {
        string Name { get; }
    }
}