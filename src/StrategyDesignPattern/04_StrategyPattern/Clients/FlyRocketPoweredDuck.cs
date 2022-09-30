using StrategyDesignPattern._04_StrategyPattern.FlyBeahavior;
using StrategyDesignPattern._04_StrategyPattern.QuackBehavior;

namespace StrategyDesignPattern._04_StrategyPattern.Clients;
sealed class FlyRocketPoweredDuck : Duck
{
    public FlyRocketPoweredDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavoir = new Quacks();
    }
    // The default fly behavoir is flying, and quack is quack
    // You can change it at runtime, using SetFlyBehavoir, and SetQuackBehavoir methods
}
