namespace StrategyDesignPattern._02_InheritanceOverride;

abstract class Duck
{
    public void Quack()
    {
        Console.WriteLine("It quackes");
    }
    public void Swim()
    {
        Console.WriteLine("It swims");
    }
    public abstract void Display();
    public abstract void Fly();
}
