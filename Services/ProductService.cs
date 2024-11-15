using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class ProductService
{
    private readonly string _productsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "products.json");

    public List<Product> GetProducts()
    {
        var json = File.ReadAllText(_productsFilePath);
        return JsonConvert.DeserializeObject<List<Product>>(json);
    }
}
