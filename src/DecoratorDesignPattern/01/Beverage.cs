namespace DecoratorDesignPattern._01;

abstract class Beverage
{
    protected string? Description;

    protected string GetDescription()
    {
        if(Description is null) Description = "";
        
        return Description;
    }

    protected abstract double Cost();
}