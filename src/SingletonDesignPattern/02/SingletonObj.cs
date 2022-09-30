namespace SingletonDesignPattern._02;

sealed class SingletonObj
{
    private static SingletonObj uniqueSingleton = new SingletonObj();
    private SingletonObj() { }
    public static SingletonObj GetInstance()
    {
        return uniqueSingleton;
    }
    public void Print()
    {
        Console.WriteLine("Assalamu Alaikum!");
    }
}
