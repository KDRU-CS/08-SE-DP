namespace FactoryDesignPattern._02;


sealed class CheesePiza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Cheeze Piza Baked");
    }
}