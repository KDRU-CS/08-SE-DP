using ObserverDesignPattern._03_WeatherDataPullData.Observers.Contracts;
using ObserverDesignPattern._03_WeatherDataPullData.Subject.Contracts;

namespace ObserverDesignPattern._03_WeatherDataPullData.Subject;

sealed class WeatherData : ISubject
{
    List<_IObserver> Observers;
    float temperature;
    float humidity;
    float pressure;

    public WeatherData()
    {
        Observers = new();
    }
    public float GetTemperature()
    {
        return this.temperature;
    }
    public float GetHumidity()
    {
        return this.humidity;
    }
    public float GetPressure()
    {
        return this.pressure;
    }
    public void NotifyObserver()
    {
        foreach (var item in Observers)
        {
            item.Notify();
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