using ObserverDesignPattern._02_ObserverAsSecondSubject.Observers.Contracts;

namespace ObserverDesignPattern._02_ObserverAsSecondSubject.Subject.Contracts;
interface ISubject
{
    public void RegisterObserver(_IObserver observer);
    public void RemoveObserver(_IObserver observer);
    public void NotifyObserver();
}