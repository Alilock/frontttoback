using Microsoft.AspNetCore.Mvc;

namespace fronttoback.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    }
}
