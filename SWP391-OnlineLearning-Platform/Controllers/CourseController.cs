using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        public IActionResult CourseList(string key, string sortOrder, string cate,int page)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.courses = Search(key, sortOrder,cate,page);
            return View(dy);
        }

        public IActionResult CourseDetail(int id)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.course = GetCourse(id);
            return View(dy);
        }

        public IActionResult CourseRegister()
        {

            IEnumerable<Price_Package> list = _db.Price_Packages;
            //var userInfor = HttpContext.Session.GetString("SessionUser");
            //if (userInfor == null && price_Id != null)
            //{
            //    return Redirect($"~/AccountManagement/Register");
            //}
            return View(list);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CourseRegister(int priceId)
        {
            IEnumerable<Price_Package> list = _db.Price_Packages;
            var userInfor = HttpContext.Session.GetString("SessionUser");
            if (userInfor == null)
            {
                return Redirect($"~/AccountManagement/Register");
            } else
            {
                User_Course uc = new User_Course();
                
                
            }
            return View(list);
        }

        public IEnumerable<Course> Search(string key,string sortOrder,string cate, int page)
        {
            ViewData["TitleSort"] = String.IsNullOrEmpty(sortOrder) ? "titleDesc" : "";
            ViewData["DateSort"] = sortOrder == "date" ? "dateDesc" : "date";
            IEnumerable<Course> list = GetCourses();
            
            if(!string.IsNullOrEmpty(key))
            {
                list = GetCourses().Where(l => l.Title.Contains(key));
            }
            switch (sortOrder)
            {
                case "titleDesc":
                    list = list.OrderByDescending(s => s.Title);
                    break;
                case "date":
                    list = list.OrderBy(s => s.Created_Date);
                    break;
                case "dateDesc":
                    list = list.OrderByDescending(s => s.Created_Date);
                    break;
                default:
                    list = list.OrderBy(s => s.Title);
                    break;
            }

            const int pageSize = 3;
            if(page < 1)
            {
                page = 1;
            }
            if (!string.IsNullOrEmpty(cate))
            {
                list = list.Where(l => l.Category_Id.Equals(Int32.Parse(cate)));
            }
            
            int resCount = list.Count();

            var pager = new Paginated(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize);
            this.ViewBag.Paginated = pager;
            this.ViewBag.Category = cate;
            return data;

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

        public Course GetCourse(int id)
        {
            Course c = _db.Courses.Find(id);
            c.Category = _db.Categories.Find(c.Category_Id);
            this.ViewBag.Category = c.Category;
            return c;
        }
    }
}
