using FactoryDesignPattern._03;

namespace FactoryPattern._03.NY;
sealed class GreekPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("NY Greek pizza Baked");
    }
}