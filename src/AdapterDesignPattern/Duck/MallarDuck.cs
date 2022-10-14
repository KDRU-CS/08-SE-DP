namespace AdapterDesignPattern.Duck;

sealed class MallarDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("Duck flies");
    }

    public void Quack()
    {
        Console.WriteLine("Duck quacks");
    }
}
