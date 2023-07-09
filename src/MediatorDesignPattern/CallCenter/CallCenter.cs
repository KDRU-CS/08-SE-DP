namespace MediatorDesignPattern;

public sealed class CallCenter : ICallCenter
{
    private readonly Dictionary<string, ICab> cabs = new();

    public void BookCab(IPassenger passenger)
    {
        foreach (var cab in cabs.Values.Where(c => c.IsFree))
        {
            if(IsWithin5MilesRadius(cab.CurrentLocation, passenger.Location))
            {
                cab.Assign(passenger.Name, passenger.Address);
                passenger.Acknowledge(cab.Name);

                return;
            }
        }
    }

    public void Register(ICab cab)
    {
        if(!cabs.ContainsValue(cab)) cabs.Add(cab.Name, cab);
    }

    bool IsWithin5MilesRadius(int cabLocation, int passengerLocation) 
        => Math.Abs(cabLocation - passengerLocation) < 5;
}