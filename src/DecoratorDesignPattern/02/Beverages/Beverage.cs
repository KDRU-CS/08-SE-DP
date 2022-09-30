using DecoratorDesignPattern._02.Beverages.Contracts;

namespace DecoratorDesignPattern._02.Beverages;

abstract class Beverage : IBeverage
{
    protected string Description = "Unknown beverage";

    public string GetDescription()
    {
        return Description;
    }
    public abstract double Cost();
}
