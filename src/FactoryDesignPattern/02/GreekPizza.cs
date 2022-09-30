namespace FactoryDesignPattern._02;

sealed class GreekPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Greek pizza Baked");
    }
}