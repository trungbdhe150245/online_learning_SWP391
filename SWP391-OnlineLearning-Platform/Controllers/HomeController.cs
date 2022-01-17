using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SWP391_OnlineLearning_Platform.Utils;
using static SWP391_OnlineLearning_Platform.Controllers.ExampleController;

namespace SWP391_OnlineLearning_Platform.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		readonly Utils.SmtpHandling _smtpHandling;
		/*
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		*/
		public HomeController(SmtpHandling smtpHandling)
		{
			_smtpHandling = smtpHandling;
		}
		public IActionResult Index()
		{
			var students = new List<Student>
			{
				new Student {Id = 10, Fname = "bui", Lname = "trung"},
				new Student {Id = 11, Fname = "bui1", Lname = "trung1"},
				new Student {Id = 12, Fname = "bui2", Lname = "trung2"},
				new Student {Id = 13, Fname = "bui3", Lname = "trung3"},
			};
			//using viewbag
			//ViewBag.students = students;
			//using viewdata
			//ViewData["students"] = students;
			//using model
			return View(students);
		}
		[HttpPost]
		public IActionResult Contact(Contact formContact)
		{
			_smtpHandling.SendEmail(formContact.Email, "Test1", "lmao", "");
			return Json(formContact);
		}
		public IActionResult Contact()
		{
			return View();
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
