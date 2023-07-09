namespace MediatorDesignPattern;

public interface ICallCenter
{
    void Register(ICab cab);
    void BookCab(IPassenger passenger);
}