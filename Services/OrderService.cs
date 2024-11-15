using Newtonsoft.Json;
public class OrderService
{
    private readonly string _ordersFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "orders.json");

    public List<Order> GetOrders()
    {
        var json = File.ReadAllText(_ordersFilePath);
        return JsonConvert.DeserializeObject<List<Order>>(json);
    }
}
