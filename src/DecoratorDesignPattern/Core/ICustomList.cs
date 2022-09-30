namespace DecoratorDesignPattern.Core;

sealed class ICustomList<T>
{
    public ICustomList(List<T> ts)
    {
        Ts = ts;
    }

    List<T> Ts { get; }

    public void PrintAll()
    {
        var n = Ts.GetEnumerator();

        foreach (var item in Ts)
        {
            n.MoveNext();
            System.Console.WriteLine(n.Current);
        }
    }
}
