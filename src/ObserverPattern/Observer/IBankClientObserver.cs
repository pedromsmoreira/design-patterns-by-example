namespace ObserverPattern.Observer
{
    using Subject;

    public interface IBankClientObserver : IObserver<IAccount, ITransaction>
    {
    }
}