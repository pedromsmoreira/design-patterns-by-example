namespace ObserverPattern.Observer
{
    public interface IObserver<in T>
    {
        void Update(T account, string message);
    }
}