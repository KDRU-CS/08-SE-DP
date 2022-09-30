namespace StrategyDesignPattern._02_InheritanceOverride;

sealed class MallarDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("Mallar Duck displays");
    }

    public override void Fly()
    {
        Console.WriteLine("Mallar Duck Flies");
    }
}