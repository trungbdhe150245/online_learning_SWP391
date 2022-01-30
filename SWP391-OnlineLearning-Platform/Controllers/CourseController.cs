using Microsoft.AspNetCore.Mvc;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class CourseController : Controller
    {
        private readonly OnlineLearningDbContext _db;

        public CourseController(OnlineLearningDbContext db)
        {
            _db = db;
        }

        public IActionResult CourseList()
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.courses = GetCourses();
            return View(dy);
        }

        public IEnumerable<Category> GetCategories()
        {
            IEnumerable<Category> list = _db.Categories;
            return list;
        }

        public IEnumerable<Course> GetCourses()
        {
            IEnumerable<Course> list = _db.Courses;
            return list;
        }
    }
}
