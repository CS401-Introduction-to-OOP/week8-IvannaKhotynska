using Week8;

public class Program
{
    public static void Main()
    {
        Letter myLetter1 = new Letter("24FHK", 3);
        Letter myLetter2 = new Letter("12DTG", 5);

        Parcel myParcel1 = new Parcel("30*10*5", "374GHD", 20);
        Parcel myParcel2 = new Parcel("35*10*20", "123UYD", 20);

        myParcel2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(myParcel1);
        myCargo.AddItem(myParcel2);
        myCargo.AddItem(myLetter1);
        myCargo.AddItem(myLetter2);

        Console.WriteLine($"Сумарна вартість - {myCargo.GetTotalCost()}");

    }
}