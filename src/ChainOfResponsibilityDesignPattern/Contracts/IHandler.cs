using ChainOfResponsibilityDesignPattern.Requests;

namespace ChainOfResponsibilityDesignPattern.Contracts;

interface IHandler
{
    void SetNextHandler(IHandler handler);
    void Process(Request request);
}