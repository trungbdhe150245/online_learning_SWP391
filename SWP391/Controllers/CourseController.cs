using Microsoft.AspNetCore.Mvc;
using SWP391.Data;
using System.Collections.Generic;
using System.Linq;
namespace SWP391.Controllers
{
    public class CourseController : Controller
    {
        private readonly LearningDbContext _db;
        public CourseController(LearningDbContext db)
        {
            _db = db; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lesson(int? id)
        {
            return Ok(id);
        }
        public IActionResult Content() 
        {

            return Ok();
        }


    }
}
