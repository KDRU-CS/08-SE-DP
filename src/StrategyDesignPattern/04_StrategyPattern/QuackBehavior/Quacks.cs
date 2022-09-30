using StrategyDesignPattern._04_StrategyPattern.QuackBehavior.Contracts;

namespace StrategyDesignPattern._04_StrategyPattern.QuackBehavior;

sealed class Quacks : IQuackBehavoir
{
    public void Quack()
    {
        Console.WriteLine("Quacks");
    }
}