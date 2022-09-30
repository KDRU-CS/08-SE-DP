using ObserverDesignPattern._02_ObserverAsSecondSubject.Display.Contracts;
using ObserverDesignPattern._02_ObserverAsSecondSubject.Observers.Contracts;
using ObserverDesignPattern._02_ObserverAsSecondSubject.Subject;
using ObserverDesignPattern._02_ObserverAsSecondSubject.Subject.Contracts;

namespace ObserverDesignPattern._02_ObserverAsSecondSubject.Observers;
sealed class CurrentConditionDisplay : _IObserver, IDisplay, ISubject
{
    private float humidity;
    private float temperature;
    private WeatherData weatherData;
    private List<_IObserver> CurrentConditionObserver;
    public CurrentConditionDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);

        CurrentConditionObserver = new();
        NotifyObserver();
    }
    public void Display()
    {
        Console.WriteLine("Today weather report\nTemperature: {0}, Humidity is: {1}", temperature, humidity);
    }

    public void NotifyObserver()
    {
        foreach (var item in CurrentConditionObserver)
        {
            item.Update(temperature, humidity, 12);
        }
    }

    public void RegisterObserver(_IObserver observer)
    {
        CurrentConditionObserver.Add(observer);
    }

    public void RemoveObserver(_IObserver observer)
    {
        CurrentConditionObserver.Remove(observer);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity;
    }
}