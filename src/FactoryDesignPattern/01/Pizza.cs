namespace FactoryDesignPattern._01;

abstract class Pizza
{
    public void Prepare()
    {
        Console.WriteLine("It is prepared");
    }

    public abstract void Bake();
    public void Cut()
    {
        Console.WriteLine("cutting pizza");
    }
    public void Box()
    {
        Console.WriteLine("Boxing pizza");
    }
}