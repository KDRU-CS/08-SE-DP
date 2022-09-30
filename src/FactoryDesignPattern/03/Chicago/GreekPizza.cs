namespace FactoryDesignPattern._03.Chicago;

sealed class GreekPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Chicago Greek pizza Baked");
    }
}