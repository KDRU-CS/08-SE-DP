using ObserverDesignPattern._01_WeatherData.Observers.Contracts.Contracts;

namespace ObserverDesignPattern._01_WeatherData.Subject;

sealed class WeatherData : ISubject
{
    private List<_IObserver> Observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        Observers = new();
    }
    public void NotifyObserver()
    {
        foreach (var item in Observers)
        {
            item.Update(temperature, humidity, pressure);
        }
    }
    public void RegisterObserver(_IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(_IObserver observer)
    {
        Observers.Add(observer);
    }

    public void MeasurementChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementChanged();
    }
}