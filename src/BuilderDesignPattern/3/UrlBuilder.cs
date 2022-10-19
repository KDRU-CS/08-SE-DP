namespace BuilderDesignPattern._3;

public class UrlBuilder
{
    private string? _protocol;
    private string? _hostname;
    private string? _port;
    private string? _pathParams;
    private string? _queryParams;

    private UrlBuilder()
    {
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

    // Nested Builder Class
    public class Builder
    {
        private readonly UrlBuilder url;
        public Builder()
        {
            url = new();
        }

        public Builder WithProtocol(string protocol)
        {
            url._protocol = protocol;
            return this;
        }

        public Builder WithHostname(string hostname)
        {
            url._hostname = hostname;
            return this;
        }

        public Builder WithPort(string port)
        {
            url._port = port;
            return this;
        }

        public Builder WithPathParams(string pathParams)
        {
            url._pathParams = pathParams;
            return this;
        }

        public Builder WithQueryParams(string queryParams)
        {
            url._queryParams = queryParams;
            return this;
        }

        public UrlBuilder Build() => url;
    }
}