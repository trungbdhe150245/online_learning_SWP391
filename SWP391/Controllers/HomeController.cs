using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SWP391.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LearningDbContext _db;
        public HomeController(ILogger<HomeController> logger, LearningDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Course> courses = _db.Courses.Where(c => c.SlideId == 1);
            this.ViewBag.Course = courses;
            return View(courses);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("/About")]
        [Route("/Home/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Membership")]
        [Route("/Home/Membership")]
        public IActionResult Membership() 
        {
            List<PricePackage> packages = (from pricepackage in _db.PricePackages select pricepackage).ToList();
            return View(packages);
        }
    }
}
