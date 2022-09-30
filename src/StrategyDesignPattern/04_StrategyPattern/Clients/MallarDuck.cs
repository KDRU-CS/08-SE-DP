using StrategyDesignPattern._04_StrategyPattern.FlyBeahavior;
using StrategyDesignPattern._04_StrategyPattern.QuackBehavior;

namespace StrategyDesignPattern._04_StrategyPattern.Clients;

sealed class MallarDuck : Duck
{
    public MallarDuck()
    {
        quackBehavoir = new Quacks();
        flyBehavior = new FlyNoWay();
    }
}