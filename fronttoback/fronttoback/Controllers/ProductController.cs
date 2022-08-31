using Microsoft.AspNetCore.Mvc;

namespace fronttoback.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
