using ObserverDesignPattern._01_WeatherData.Observers.Contracts.Contracts;

namespace ObserverDesignPattern._01_WeatherData.Subject;

interface ISubject
{
    public void RegisterObserver(_IObserver observer);
    public void RemoveObserver(_IObserver observer);
    public void NotifyObserver();
}