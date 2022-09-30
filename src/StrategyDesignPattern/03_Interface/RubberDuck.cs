using StrategyDesignPattern._03_Interface.Contracts;

namespace StrategyDesignPattern._03_Interface;

sealed class RubberDuck : Duck, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Rubber duck displays");
    }

    public void Quack()
    {
        Console.WriteLine("Rubber duck quacks");
    }
}
