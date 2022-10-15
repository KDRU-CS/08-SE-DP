using ChainOfResponsibilityDesignPattern.Requests;

namespace ChainOfResponsibilityDesignPattern.Contracts;
class BaseHandler : IHandler
{
    protected IHandler? _handler;
    public BaseHandler()
    {
        _handler = null;
    }
    public virtual void Process(Request request)
    {
        throw new NotImplementedException();
    }

    public void SetNextHandler(IHandler handler)
    {
        _handler = handler;
    }
}