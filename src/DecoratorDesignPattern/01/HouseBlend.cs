namespace DecoratorDesignPattern._01;

sealed class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "HouseBlend Coffee";
    }
    protected override double Cost()
    {
        return 12.23;
    }
}
