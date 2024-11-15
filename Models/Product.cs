using Newtonsoft.Json;

public class Product
{
    public int ProductId { get; set; }

    public int SiteId { get; set; }

    [JsonProperty("product_name")]
    public required string ProductName { get; set; }

    public decimal Cost { get; set; }

    public bool InventoryOnly { get; set; }

    public bool Private { get; set; }
}
