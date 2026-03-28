namespace Week8;

public class Parcel: DeliveryItem
{
    private string Dimensions { get; }
    public Parcel(string dimensions, string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + Weight * 25;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Габарити - {Dimensions}");
    }
}