namespace SingletonDesignPattern._01;

sealed class SingletonObj
{
    private static SingletonObj? uniqueSingleton;
    private SingletonObj() { }
    public static SingletonObj GetInstance()
    {
        if(uniqueSingleton is null)
        {
            uniqueSingleton = new SingletonObj();
        }
        return uniqueSingleton;
    }
    public void Print()
    {
        Console.WriteLine("Assalamu Alaikum!");
    }
}
