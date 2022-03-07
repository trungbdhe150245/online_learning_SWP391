using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
			IEnumerable<Course> courses = _db.Courses.OrderBy(s => s.FeaturedId);
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
	}
}
