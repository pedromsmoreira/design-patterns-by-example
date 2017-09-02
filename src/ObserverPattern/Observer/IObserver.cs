namespace ObserverPattern.Observer
{
    using System;

    public interface IObserver<in TSubject, in TEvent>
    {
        void Update(TSubject subject, TEvent observedEvent);
    }
}