using ChainOfResponsibilityDesignPattern.Contracts;
using ChainOfResponsibilityDesignPattern.Requests;

namespace ChainOfResponsibilityDesignPattern.Handlers;

sealed class FullNameHandler : BaseHandler
{
    public override void Process(Request request)
    {
        if (request.Data is Person person)
        {
            if (person is not null && person.FullName is not null)
            {
                var p = person.FullName.Count();
                if (p < 10) request.ValidationMessages.Add("Invalid Full Name");
                if (_handler is not null) _handler.Process(request);
            }
        }
        else
        {
            throw new Exception("Invalid Message Data");
        }
    }
}