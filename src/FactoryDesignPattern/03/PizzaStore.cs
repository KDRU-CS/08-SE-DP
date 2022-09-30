namespace FactoryDesignPattern._03;

abstract class PizzaStore
{
    public void Order(Pizza pizza)
    {
        pizza = CreatePizza(pizza);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }

    public abstract Pizza CreatePizza(Pizza pizza);
}
