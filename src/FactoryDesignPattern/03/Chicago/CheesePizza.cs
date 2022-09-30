namespace FactoryDesignPattern._03.Chicago;

sealed class CheesePizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Chicago Cheeze Piza Baked");
    }
}