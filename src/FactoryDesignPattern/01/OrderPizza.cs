namespace FactoryDesignPattern._01;

sealed class OrderPizza
{
    public void Order(Pizza pizza)
    {
        if (pizza is GreekPizza)
        {
            pizza = new GreekPizza();
        }
        if (pizza is CheesePiza)
        {
            pizza = new CheesePiza();
        }

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
    }
}
