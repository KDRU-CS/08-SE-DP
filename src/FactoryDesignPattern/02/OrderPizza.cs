namespace FactoryDesignPattern._02;

sealed class OrderPizza
{
    public void Order(Pizza pizza)
    {
        Factory factory = new Factory();
        pizza = factory.CreatePizza(pizza);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }
}
