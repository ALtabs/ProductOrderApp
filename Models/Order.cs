public class Order
{
    public int Id { get; set; }
    public bool Validated { get; set; }
    public required string Status { get; set; }
    public required List<OrderItem> Items { get; set; }
}

public class OrderItem
{
    public int ProductId { get; set; }
    public decimal NetCost { get; set; }
}
