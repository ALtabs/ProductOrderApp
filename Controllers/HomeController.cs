using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductOrderApp.Models;

namespace ProductOrderApp.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;
    private readonly OrderService _orderService;

    public HomeController(ProductService productService, OrderService orderService)
    {
        _productService = productService;
        _orderService = orderService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Store()
    {
        var products = _productService.GetProducts();
        return View(products);
    }

    public IActionResult MyOrders()
    {
        var orders = _orderService.GetOrders();
        return View(orders);
    }
}

