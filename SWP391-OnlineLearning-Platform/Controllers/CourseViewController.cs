using Microsoft.AspNetCore.Mvc;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
	public class CourseViewController : Controller
	{
		private readonly OnlineLearningDbContext _onlineLearningDbContext;
		public CourseViewController(OnlineLearningDbContext onlineLearningDbContext)
		{
			_onlineLearningDbContext = onlineLearningDbContext;
		}

		public IActionResult Index()
		{
			IEnumerable<Role> roles = _onlineLearningDbContext.Roles;
			return View(roles);
		}
	}
}
