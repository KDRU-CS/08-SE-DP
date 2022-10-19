using System.Text;

namespace BuilderDesignPattern._2;

sealed class UrlTelescope
{
    private string? _protocol;
    private string? _hostname;
    private string? _port;
    private string? _pathParams;
    private string? _queryParams;

    public UrlTelescope() { }
    public UrlTelescope(string protocol, string hostname)
    {
        _protocol = protocol;
        _hostname = hostname;
    }

    public UrlTelescope(string protocol, string hostname, string port) : this(protocol, hostname)
    {
        _port = port;
    }

    public UrlTelescope(string protocol, string hostname, string port, string pathParams) : this(protocol, hostname, port)
    {
        _pathParams = pathParams;
    }

    public UrlTelescope(string protocol, string hostname, string port, string pathParams, string queryParams) : this(protocol, hostname, port, pathParams)
    {
        _queryParams = queryParams;
    }

    public string GetUrl()
    {
       return _protocol?.ToString() +
                "://" +
               _hostname?.ToString() +
               (_port is not null ? ":" : "") +
               _port?.ToString() +
               (_pathParams is not null ? "/" : "") +
               _pathParams?.ToString() +
               (_queryParams is not null ? "?" : "") +
               _queryParams?.ToString(); 
    }
}