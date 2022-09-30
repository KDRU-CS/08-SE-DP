using ObserverDesignPattern._03_WeatherDataPullData.Display.Contracts;
using ObserverDesignPattern._03_WeatherDataPullData.Observers.Contracts;
using ObserverDesignPattern._03_WeatherDataPullData.Subject;

namespace ObserverDesignPattern._03_WeatherDataPullData.Observers;

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

    public void Notify()
    {
        this.temperature = weatherData.GetTemperature();
        this.humidity = weatherData.GetHumidity();
    }
}