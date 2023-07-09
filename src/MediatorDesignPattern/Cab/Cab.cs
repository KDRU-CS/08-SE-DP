namespace MediatorDesignPattern;
using static System.Console;

public sealed class Cab : ICab
{
    private readonly string _name;
    private readonly int _currentLocation;
    private readonly bool _isFree;

    public Cab(string name,
               int currentLocation,
               bool isFree)
    {
        _name = name;
        _currentLocation = currentLocation;
        _isFree = isFree;
    }

    public string Name => _name;

    public int CurrentLocation => _currentLocation;

    public bool IsFree => _isFree;

    public void Assign(string name, string address)
    {
        WriteLine($"{name} at {address} is assigned to {Name}'s cab");
    }
}