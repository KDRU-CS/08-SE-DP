namespace ChainOfResponsibilityDesignPattern.Requests;

sealed class Request
{
    public object? Data { get; set; }
    public List<string> ValidationMessages { get; set; }

    public Request()
    {
        ValidationMessages = new();
    }
}