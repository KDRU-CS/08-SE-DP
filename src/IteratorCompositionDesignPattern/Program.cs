using IteratorCompositionDesignPattern._01;

DinnerMenu menu = new(6);

menu.AddItem("Pizza", "A good fast food", true, 12.0);
menu.AddItem("Burger", "A good fast food", false, 22.0);
menu.AddItem("Meat", "A good fast food", false, 142.0);
menu.AddItem("Nuts", "A good fast food", true, 12.5);
menu.AddItem("Biryani", "A good fast food", false, 13.0);
menu.AddItem("Rice", "A good fast food", true, 15.23);


// loop using IEnumerable
// while(menu.MoveNext())
// {
//     Console.WriteLine(menu.Current.GetItem());
// }

// loop using IEnumerator
foreach (var item in menu)
{
    Console.WriteLine(item.GetItem());
}