using System.Text;

namespace BuilderDesignPattern._1;

sealed class UrlGenerator
{
    private string? _protocol;
    private string? _hostname;
    private string? _port;
    private string? _pathParams;
    private string? _queryParams;

    public UrlGenerator() { }
    public UrlGenerator(string protocol, string hostname)
    {
        _protocol = protocol;
        _hostname = hostname;
    }

    public UrlGenerator(string protocol, string hostname, string port)
    {
        _protocol = protocol;
        _hostname = hostname;
        _port = port;
    }

    public UrlGenerator(string protocol, string hostname, string port, string pathParams)
    {
        _protocol = protocol;
        _hostname = hostname;
        _port = port;
        _pathParams = pathParams;
    }

    public UrlGenerator(string protocol, string hostname, string port, string pathParams, string queryParams)
    {
        _protocol = protocol;
        _hostname = hostname;
        _port = port;
        _pathParams = pathParams;
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