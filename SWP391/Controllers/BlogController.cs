using Microsoft.AspNetCore.Mvc;

namespace SWP391.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
