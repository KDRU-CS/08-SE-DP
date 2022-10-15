using ChainOfResponsibilityDesignPattern.Handlers;
using ChainOfResponsibilityDesignPattern.Requests;

Person person = new()
{
    FullName = "Mohammad Younus Khan",
    Email = "Mohammad@gmail.com",
    Age = 56
};

Request request = new() { Data = person };
FullNameHandler fullNameHandler = new();
EmailHandler emailHandler = new();
AgeHandler ageHandler = new();

fullNameHandler.SetNextHandler(emailHandler);
emailHandler.SetNextHandler(ageHandler);
fullNameHandler.Process(request);

foreach (var item in request.ValidationMessages)
{
    Console.WriteLine(item);
}