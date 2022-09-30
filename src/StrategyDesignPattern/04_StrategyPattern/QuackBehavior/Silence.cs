using StrategyDesignPattern._04_StrategyPattern.QuackBehavior.Contracts;

namespace StrategyDesignPattern._04_StrategyPattern.QuackBehavior;

sealed class Silence : IQuackBehavoir
{
    public void Quack()
    {
        Console.WriteLine("It silence");
    }
}