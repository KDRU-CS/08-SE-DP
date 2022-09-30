namespace ObserverDesignPattern._02_ObserverAsSecondSubject.Observers.Contracts;
interface _IObserver
{
    public void Update(float temp, float humidity, float pressure);
}