namespace MediatorDesignPattern;

public interface ICab
{
    string Name { get; }
    int CurrentLocation { get; }
    bool IsFree { get; }

    void Assign(string name, string address);
}