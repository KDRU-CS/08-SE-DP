namespace DecoratorDesignPattern._01;

sealed class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "DarkRoast Hot Coffee";
    }
    protected override double Cost()
    {
        return 11.29;
    }
}
