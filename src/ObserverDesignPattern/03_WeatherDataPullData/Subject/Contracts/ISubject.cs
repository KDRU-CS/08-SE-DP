using ObserverDesignPattern._03_WeatherDataPullData.Observers.Contracts;

namespace ObserverDesignPattern._03_WeatherDataPullData.Subject.Contracts;

interface ISubject
{
    public void RegisterObserver(_IObserver observer);
    public void RemoveObserver(_IObserver observer);
    public void NotifyObserver();
}