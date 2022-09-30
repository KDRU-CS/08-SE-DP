using FactoryDesignPattern._03;

namespace FactoryPattern._03.NY;

sealed class CheesePiza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("NY Cheeze Piza Baked");
    }
}