using static System.Console;

namespace FacadeDesignPattern;

public sealed class Socket
{
    public long Id { get; set; }
    public int Port { get; set; }
    public string? Protocol { get; set; }

    public Socket(string protocol)
    {
        Protocol = protocol;
    }

    public void BuildSocket()
    {
        WriteLine("builds socket...");
    }
}