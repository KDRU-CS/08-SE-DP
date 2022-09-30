using StrategyDesignPattern._03_Interface.Contracts;

namespace StrategyDesignPattern._03_Interface;

sealed class MallarDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Mallar duck displays");
    }

    public void Fly()
    {
        Console.WriteLine("Mallar duck flies");
    }

    public void Quack()
    {
        Console.WriteLine("Mallar duck quackes");
    }
}