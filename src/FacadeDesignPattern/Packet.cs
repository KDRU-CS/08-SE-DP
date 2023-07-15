using static System.Console;

namespace FacadeDesignPattern;

public sealed class Packet
{
    public long Id { get; set; }
    public string? Data { get; set; }
    public string? IP { get; set; }

    public Packet(string ip)
    {
        IP = ip;
    }

    public void BuildPacket()
    {
        WriteLine("builds packet...");
    }
}