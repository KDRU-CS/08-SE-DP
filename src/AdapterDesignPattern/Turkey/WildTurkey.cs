namespace AdapterDesignPattern.Turkey;

sealed class WildTurkey : ITurkey
{
    public void Fly()
    {
        Console.WriteLine("Turkey flies");
    }

    public void Gobble()
    {
        Console.WriteLine("Turkey Gobbles");
    }
}
