using Microsoft.AspNetCore.Mvc;

namespace SWP391.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
