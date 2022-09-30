namespace DecoratorDesignPattern._02.Beverages;

sealed class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend coffee";
    }

    public override double Cost()
    {
        return .89;
    }
}