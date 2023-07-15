using static System.Console;

namespace FacadeDesignPattern;

public sealed class Transmission
{
    public long Id { get; set; }
    public string? Name { get; set; }

    public Transmission(string protocolName)
    {
        Name = protocolName;
    }

    public void SendTransmission()
    {
        WriteLine("sending transmission...");
        WriteLine("done");
    }
}