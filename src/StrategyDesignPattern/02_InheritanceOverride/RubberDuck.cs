namespace StrategyDesignPattern._02_InheritanceOverride;

sealed class RubberDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("Rubber duck displays");
    }

    // The problem with this approach is, when you add methods and functions to superclass
    // all its subclass implements it.
    // In this example rubber ducks don't fly, but you must implement it.
    public override void Fly()
    {
        Console.WriteLine("Rubber duck flies");
    }
}
