using Microsoft.AspNetCore.Mvc;

namespace SuperBuy
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Dictionary<string, object>> data = new()
            {
                new() {{"Id", 1}, {"Name", "Fruits & Veg"}},
                new() {{"Id", 2}, {"Name", "Snacks"}},
                new() {{"Id", 3}, {"Name", "Spices"}},
                new() {{"Id", 4}, {"Name", "Dry Fruits"}},
            };
            return View(data);
        }
    }
}