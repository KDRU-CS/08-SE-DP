using ObserverDesignPattern._03_WeatherDataPullData.Display.Contracts;
using ObserverDesignPattern._03_WeatherDataPullData.Observers.Contracts;
using ObserverDesignPattern._03_WeatherDataPullData.Subject;

namespace ObserverDesignPattern._03_WeatherDataPullData.Observers;

sealed class TemperatureByPressure : _IObserver, IDisplay
{
    private float temperature;
    private float pressure;
    WeatherData weatherData;
    public TemperatureByPressure(WeatherData weatherData)
    {
        weatherData.RegisterObserver(this);
        this.weatherData = weatherData;
    }
    public void Display()
    {
        Console.WriteLine("{0} / {1} is : {2}", temperature, pressure, temperature/pressure);
    }

    public void Notify()
    {
        this.temperature = weatherData.GetTemperature();
        this.pressure = weatherData.GetPressure();
    }
}