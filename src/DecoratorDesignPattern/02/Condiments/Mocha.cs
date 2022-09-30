using DecoratorDesignPattern._02.Beverages;

namespace DecoratorDesignPattern._02.Condiments;

sealed class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        if(beverage is null) throw new NullReferenceException();
        return beverage.GetDescription() + ", Mocha";
    }
    public override double Cost()
    {
        if(beverage is null) throw new NullReferenceException();
        return beverage.Cost() + .20;
    }
}
