using Microsoft.AspNetCore.Mvc;
using SWP391.DAO;
using SWP391.Data;
using SWP391.Models;
using System.Collections.Generic;
using System.Linq;
namespace SWP391.Controllers
{
    public class CourseController : Controller
    {
        private LessonDAO lessonDAO = new LessonDAO();
        public CourseController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

       


        //public IActionResult Lesson(int? id)
        //{
        //    return Ok(id);
        //}
        public IActionResult Content() 
        {
            List<Lesson> lessons = lessonDAO.GetLessons();
            return View(lessons);
        }


    }
}
