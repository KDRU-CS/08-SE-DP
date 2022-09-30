namespace FactoryDesignPattern._02;

sealed class Factory
{
    public Pizza CreatePizza(Pizza pizza)
    {
        if (pizza is GreekPizza)
        {
            pizza = new GreekPizza();
        }
        if (pizza is CheesePiza)
        {
            pizza = new CheesePiza();
        }

        return pizza;
    }
}
