using AdapterDesignPattern.Duck;
using AdapterDesignPattern.Turkey;

namespace AdapterDesignPattern;

sealed class TurkeyAdapter : IDuck
{
    ITurkey Turkey { get; }
    public TurkeyAdapter(ITurkey turkey)
    {
        Turkey = turkey;
    }

    public void Fly()
    {
        for (int i = 0; i < 5; ++i)
        {
            Turkey.Fly();
        }
    }

    public void Quack()
    {
        Turkey.Gobble();
    }
}
