using StrategyDesignPattern._04_StrategyPattern.FlyBeahavior.Contracts;

namespace StrategyDesignPattern._04_StrategyPattern.FlyBeahavior;

sealed class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("It flies");
    }
}