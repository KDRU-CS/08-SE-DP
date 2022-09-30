using DecoratorDesignPattern._02.Beverages;
using DecoratorDesignPattern._02.Beverages.Contracts;

namespace DecoratorDesignPattern._02.Condiments;

abstract class CondimentDecorator : IBeverage
{
    protected Beverage? beverage;

    public abstract double Cost();

    public abstract string GetDescription();
}
