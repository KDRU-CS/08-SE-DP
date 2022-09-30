using StrategyDesignPattern._04_StrategyPattern.QuackBehavior.Contracts;

namespace StrategyDesignPattern._04_StrategyPattern.QuackBehavior;

sealed class Squeak : IQuackBehavoir
{
    public void Quack()
    {
        Console.WriteLine("It squeaks");
    }
}
