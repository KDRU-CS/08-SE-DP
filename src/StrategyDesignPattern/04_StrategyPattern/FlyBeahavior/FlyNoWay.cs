using StrategyDesignPattern._04_StrategyPattern.FlyBeahavior.Contracts;

namespace StrategyDesignPattern._04_StrategyPattern.FlyBeahavior;

sealed class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("It doesn't fly");
    }
}