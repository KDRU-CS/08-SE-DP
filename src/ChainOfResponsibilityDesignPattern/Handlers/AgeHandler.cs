using ChainOfResponsibilityDesignPattern.Contracts;
using ChainOfResponsibilityDesignPattern.Requests;

namespace ChainOfResponsibilityDesignPattern.Handlers;
sealed class AgeHandler : BaseHandler
{
    public override void Process(Request request)
    {
        if (request.Data is Person person)
        {
            if (person.Age > 55) request.ValidationMessages.Add("Age out of boundaries");
            if (_handler is not null) _handler.Process(request);
        }
        else
        {
            throw new Exception("Invalid Message Data");
        }
    }
}