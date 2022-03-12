using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility;
using SWP391.Views.ViewModel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Controllers.Admin
{
    [ServiceFilter(typeof(Filter))]
    public class DashBoardController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public object WebHostEnvironment { get; private set; }

        public DashBoardController(LearningDbContext db, UserManager<AppUser> userManager, IWebHostEnvironment WebHostEnvironment)
        {
            _db = db;
            _userManager = userManager;
            _WebHostEnvironment = WebHostEnvironment;
        }


        public IActionResult DashBoard()
        {
            dynamic dy = new ExpandoObject();
            dy.courses = _db.Courses.Count();
            dy.users = _db.Users.Count();
            return View(dy);
        }


        public IActionResult RegistrationList()
        {
            var obj = GetCurrentUser();
            IEnumerable<Course> list = _db.Courses.Where(c => c.StatusId == 3);
            ViewBag.CourseRegis = list;
            return View(list);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeStatus(string id, string approve, string cancel)
        {
            var course = _db.Courses.Find(id);
            if (ModelState.IsValid)
            {
                if (approve != null)
                {
                    course.StatusId = 1;
                }
                if (cancel != null)
                {
                    course.StatusId = 2;
                }
                //course.StatusId = "1";
                _db.Courses.Update(course);
                _db.SaveChanges();
                return RedirectToAction("RegistrationList");
            }
            return View(course);
        }

        public IActionResult CreateCourse()
        {
            IEnumerable<Course> list = _db.Courses;
            this.ViewBag.Courses = list;
            NewCourseVM newCourseVM = new NewCourseVM()
            {
                Course = new Course(),
                TypeDropDown = _db.Categories.Select(i => new SelectListItem
                {
                    Text = i.CategoryValue,
                    Value = i.CategoryId.ToString()
                })
            };
            return View(newCourseVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse(NewCourseVM obj)
        {
            int id = 30;
            if (ModelState.IsValid)
            {
                string wwwroot = _WebHostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(obj.Course.ImgFile.FileName);
                string ex = Path.GetExtension(obj.Course.ImgFile.FileName);
                obj.Course.ThumbnailURL = filename = filename + DateTime.Now.ToString("yymmssfff") + ex;
                string path = Path.Combine(wwwroot + "/img/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await obj.Course.ImgFile.CopyToAsync(filestream);
                }
                obj.Course.CourseId = id.ToString();
                id++;
                obj.Course.StatusId = 3;
                obj.Course.SlideId = 20;
                _db.Courses.Add(obj.Course);
                _db.SaveChanges();
                return RedirectToAction("~/Index");
            }
            return View(obj);
        }

        public IActionResult UserList()
        {
            IEnumerable<AppUser> list = _db.Users;
            return View(list);
        }

        public IActionResult UserDetail(string id)
        {
            AppUser user = _db.Users.Find(id);
            return PartialView(user);
        }

        public Task<AppUser> GetCurrentUser()
        {
            var user = HttpContext.User;
            var obj = _userManager.GetUserAsync(user);
            this.ViewBag.User = obj.Result;
            return obj;
        }
    }
}
