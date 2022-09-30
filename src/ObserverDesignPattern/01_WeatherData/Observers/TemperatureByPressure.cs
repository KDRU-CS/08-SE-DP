using ObserverDesignPattern._01_WeatherData.Display.Contracts;
using ObserverDesignPattern._01_WeatherData.Observers.Contracts.Contracts;
using ObserverDesignPattern._01_WeatherData.Subject;

namespace ObserverDesignPattern._01_WeatherData.Observers;

sealed class TemperatureByPressure : _IObserver, IDisplay
{
    private float temperature;
    private float pressure;

    public TemperatureByPressure(WeatherData weatherData)
    {
        weatherData.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine("{0} / {1} is : {2}", temperature, pressure, temperature/pressure);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        this.temperature = temp;
        this.pressure = pressure;
    }
}