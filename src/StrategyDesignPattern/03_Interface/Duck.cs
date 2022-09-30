namespace StrategyDesignPattern._03_Interface;

abstract class Duck
{
    public void Swim()
    {
        Console.WriteLine("It swims");
    }
    public abstract void Display();
}
