namespace ObserverDesignPattern._01_WeatherData.Observers.Contracts.Contracts;

interface _IObserver
{
    public void Update(float temp, float humidity, float pressure);
}