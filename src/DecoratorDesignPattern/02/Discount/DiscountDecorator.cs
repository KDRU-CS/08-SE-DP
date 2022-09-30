using DecoratorDesignPattern._02.Beverages;

namespace DecoratorDesignPattern._02.Discount;
sealed class DiscountDecorator : Beverage
{
    public Beverage Beverage { get; }
    public double Discount { get; }
    public DiscountDecorator(Beverage beverage, double discount)
    {
        Beverage = beverage;
        Discount = discount;
    }

    public override double Cost()
    {
        return Beverage.Cost() - Discount;
    }

}