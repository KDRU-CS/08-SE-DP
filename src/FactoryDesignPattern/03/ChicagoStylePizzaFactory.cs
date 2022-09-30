using FactoryDesignPattern._03.Chicago;

namespace FactoryDesignPattern._03;
sealed class ChicagoStylePizzaFactory : PizzaStore
{
    public override Pizza CreatePizza(Pizza pizza)
    {
        if (pizza is GreekPizza)
        {
            pizza = new GreekPizza();
        }
        if (pizza is CheesePizza)
        {
            pizza = new CheesePizza();
        }

        return pizza;
    }
}