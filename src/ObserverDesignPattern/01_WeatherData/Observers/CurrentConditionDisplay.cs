using ObserverDesignPattern._01_WeatherData.Display.Contracts;
using ObserverDesignPattern._01_WeatherData.Observers.Contracts.Contracts;
using ObserverDesignPattern._01_WeatherData.Subject;

namespace ObserverDesignPattern._01_WeatherData.Observers;

sealed class CurrentConditionDisplay : _IObserver, IDisplay
{
    private float humidity;
    private float temperature;
    private WeatherData weatherData;

    public CurrentConditionDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine("Today weather report\nTemperature: {0}, Humidity is: {1}", temperature, humidity);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.humidity = humidity;
    }
}