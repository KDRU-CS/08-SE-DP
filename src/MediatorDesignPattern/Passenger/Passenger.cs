namespace MediatorDesignPattern;
using static System.Console;

public sealed class Passenger : IPassenger
{
    private readonly string _name;
    private readonly string _address;
    private readonly int _location;

    public Passenger(string name,
                     string address,
                     int location)
    {
        _name = name;
        _address = address;
        _location = location;
    }
    
    public string Name => _name;

    public string Address => _address;

    public int Location => _location;

    public void Acknowledge(string name)
    {
        WriteLine($"Dear {Name}, you are assigned to {name} Cab");
    }
}