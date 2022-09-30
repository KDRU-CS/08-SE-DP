namespace StrategyDesignPattern._02_InheritanceOverride;

sealed class RedHeadDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("RedHead duck displays");
    }

    public override void Fly()
    {
        Console.WriteLine("RedHead duck flies");
    }
}