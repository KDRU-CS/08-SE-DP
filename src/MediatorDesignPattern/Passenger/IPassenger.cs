namespace MediatorDesignPattern;

public interface IPassenger
{
    string Name { get; }
    string Address { get; }
    int Location { get; }

    void Acknowledge(string name);
}