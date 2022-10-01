namespace IteratorCompositionDesignPattern._01;

public sealed class MenuItem
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool Vegeterian { get; set; }
    public double Price { get; set; }
    
    public void SetItem(string name, string description, bool vegeterian, double price)
    {
        Name = name;
        Description = description;
        Vegeterian = vegeterian;
        Price = price;
    }
    public string GetItem() => $"Name: {Name}, Price: {Price}, IsVegeterian: {Vegeterian}, Description: {Description}";
}
