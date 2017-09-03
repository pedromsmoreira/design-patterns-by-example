namespace ObserverPattern.Subject
{
    public interface IObservable<in T>
    {
        void Attach(T observer);

        void Detach(T observer);
    }
}