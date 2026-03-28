namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
        Console.WriteLine($"{item.TrackingNumber} - був доданий, тип - {typeof(T)}");
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (T item in _items)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}