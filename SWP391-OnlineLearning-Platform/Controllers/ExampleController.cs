using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
	public class ExampleController : Controller
	{


		public IActionResult Index()
		{
			return View();
		}
		public IActionResult StringOut(int id)
		{
			return Content($"Hello id: {id}");
		}

		public IActionResult JsonOut(int id, Student s)
		{
			var obj = new { Id = id, Student = s };
			return Json(obj);
		}



		public class Student
		{
			public int Id { get; set; }
			public string Fname { get; set; }
			public string Lname { get; set; }
		}
	}
}
