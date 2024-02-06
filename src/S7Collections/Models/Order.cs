namespace S7Collections.Models;

public class Order
{
    public int OrderId { get; set; }
    
    public int OrderQuantity { get; set; }

    public Order(int id, int orderQuantity)
    {
        this.OrderId = id;
        this.OrderQuantity = orderQuantity;
    }

    public void ProcessOrder()
    {
        Console.WriteLine($"Order {OrderId} has been processed.");
    }
}