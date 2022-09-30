using ObserverDesignPattern._02_ObserverAsSecondSubject.Display.Contracts;
using ObserverDesignPattern._02_ObserverAsSecondSubject.Observers;
using ObserverDesignPattern._02_ObserverAsSecondSubject.Observers.Contracts;

namespace ObserverDesignPattern._02_ObserverAsSecondSubject.CurrentConditionObservers;

sealed class CurrentConditionObserver1 : _IObserver, IDisplay
{
    private float temp;
    private float humidity;
    private float pressure;

    public CurrentConditionObserver1(CurrentConditionDisplay current)
    {
        current.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine("This is nested one {0}, {1}, {2}", temp, humidity, pressure);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        this.temp = temp;
        this.humidity = humidity;
        this.pressure = pressure;
    }
}