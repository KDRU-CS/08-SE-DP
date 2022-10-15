using ChainOfResponsibilityDesignPattern.Contracts;
using ChainOfResponsibilityDesignPattern.Requests;

namespace ChainOfResponsibilityDesignPattern.Handlers;

sealed class EmailHandler : BaseHandler
{
    public override void Process(Request request)
    {
        if (request.Data is Person person)
        {
            if (person is not null && person.Email is not null)
                if (!person.Email.Contains("@gmail.com")) request.ValidationMessages.Add("Invalid Email Address");
            if (_handler is not null) _handler.Process(request);
        }
        else
        {
            throw new Exception("Invalid Message Data");
        }
    }
}