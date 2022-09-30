using StrategyDesignPattern._04_StrategyPattern.FlyBeahavior.Contracts;
using StrategyDesignPattern._04_StrategyPattern.QuackBehavior.Contracts;

namespace StrategyDesignPattern._04_StrategyPattern;

abstract class Duck
{
    protected IFlyBehavior? flyBehavior;
    protected IQuackBehavoir? quackBehavoir;

    public void Quack()
    {
        Console.WriteLine("It quackes");
    }
    public void Swim()
    {
        Console.WriteLine("It swims");
    }

    public void PerformQuack()
    {
        quackBehavoir?.Quack();
    }

    public void PerformFly()
    {
        flyBehavior?.Fly();
    }

    public void SetQuackBehavoir(IQuackBehavoir quack)
    {
        quackBehavoir = quack;
    }
    public void SetFlyBehavoir(IFlyBehavior fly)
    {
        flyBehavior = fly;
    }

    // These methods varies
    // So we are pulling them to their own classes
    // We are separating vary aspects from non changeable aspects
    //public abstract void Display();
    //public abstract void Fly();
}
