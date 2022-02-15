using Microsoft.AspNetCore.Mvc;
using SWP391_OnlineLearning_Platform.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Areas.Admin.Controllers
{
    public class TestController : Controller
    {
        private readonly OnlineLearningDbContext _db;

        public TestController(OnlineLearningDbContext db)
        {
            _db = db;
        }
        public IActionResult QuestionList()
        {
            return View();
        }
    }
}
