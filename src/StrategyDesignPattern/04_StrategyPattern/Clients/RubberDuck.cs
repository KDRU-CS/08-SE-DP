using StrategyDesignPattern._04_StrategyPattern.FlyBeahavior;
using StrategyDesignPattern._04_StrategyPattern.QuackBehavior;

namespace StrategyDesignPattern._04_StrategyPattern.Clients;

sealed class RubberDuck : Duck
{
    public RubberDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavoir = new Silence();
    }
}
