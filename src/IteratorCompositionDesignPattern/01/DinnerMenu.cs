using System.Collections;

namespace IteratorCompositionDesignPattern._01;

public class DinnerMenu : IEnumerator<MenuItem>, IEnumerable<MenuItem>
{
    int maxItems = 0;
    int NumberOfItems = 0;
    MenuItem[] menuItems;
    int position = 0;

    public DinnerMenu(int maxItems)
    {
        this.maxItems = maxItems;
        menuItems = new MenuItem[maxItems];
    }
    
    // Implementation of MenuItem

    public void AddItem(string name, string description, bool vegeterian, double price)
    {
        MenuItem menuItem = new();
        menuItem.SetItem(name, description, vegeterian, price);

        if (NumberOfItems >= maxItems)
        {
            Console.WriteLine("Menu is full");
        }
        else
        {
            menuItems[NumberOfItems] = menuItem;
            NumberOfItems++;
        }
    }
    
    
    // Implementation of IEnumeratable

    public MenuItem Current => new MenuItem()
    {
        Description = menuItems[position].Description,
        Name = menuItems[position].Name,
        Price = menuItems[position].Price,
        Vegeterian = menuItems[position].Vegeterian
    };
    object IEnumerator.Current => Current;
    public bool MoveNext()
    {
       if(position < menuItems.Length - 1)
        {
            position++;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Reset()
    {
        position = 0;
    }

    
    // Implementation of IEnumerator for foreach loop

    public IEnumerator<MenuItem> GetEnumerator()
    {
        return this;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Dispose()
    {
        // We have not used any resource to dispose
    }
}
