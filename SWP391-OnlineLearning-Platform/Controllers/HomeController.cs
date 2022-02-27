using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
	public class HomeController : Controller
	{
		private readonly OnlineLearningDbContext _db;

		public HomeController(OnlineLearningDbContext db)
		{
			_db = db;
		}
		
		public IActionResult Index()
		{
			var courses = (IEnumerable<Course>)_db.Courses.OrderBy(s => s.Featured);
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
	}
}
