using LR8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LR8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { ID = 1, Name = "Pizza", Price = 10.99m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Burger", Price = 8.49m, CreatedDate = DateTime.Now.AddDays(-2) },
            new Product { ID = 3, Name = "Salad", Price = 6.99m, CreatedDate = DateTime.Now.AddDays(-5) }
        };
            return View(products);
        }
    }
}
