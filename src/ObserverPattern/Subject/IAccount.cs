namespace ObserverPattern.Subject
{
    public interface IAccount<in T>
    {
        void Attach(T subject);

        void Detach(T subject);

        void Notify(string message);
    }
}