using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.Data;
using SWP391.Models;
using SWP391.Views.ViewModel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Controllers
{
    public class CourseController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly IWebHostEnvironment WebHostEnvironment;
        public CourseController(LearningDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            WebHostEnvironment = webHostEnvironment;
        }
        //private LessonDAO lessonDAO = new LessonDAO();
        //public CourseController()
        //{
            
        //}

        //public IActionResult Lesson(int? id)
        //{
        //    return Ok(id);
        //}
        //public IActionResult Content() 
        //{
        //    List<Lesson> lessons = lessonDAO.GetLessons();
        //    return View(lessons);
        //}

        public IActionResult CourseList(string key, string sortOrder, string cate, int page)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.courses = Search(key, sortOrder, cate, page);
            return View(dy);
        }

        public IActionResult CourseDetail(int id)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.course = GetCourse(id);
            return PartialView("CourseDetail", dy);
        }

        public IActionResult CreateCourse()
        {
            NewCourseVM newCourseVM = new NewCourseVM()
            {
                Course = new Course(),
                TypeDropDown = _db.Categories.Select(i => new SelectListItem
                {
                    Text = i.Value,
                    Value = i.CategoryId.ToString()
                })
            };
            return PartialView(newCourseVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse(NewCourseVM obj)
        {
            if (ModelState.IsValid)
            {
                string wwwroot = WebHostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(obj.Course.ImgFile.FileName);
                string ex = Path.GetExtension(obj.Course.ImgFile.FileName);
                obj.Course.ThumbnailURL = filename = filename + DateTime.Now.ToString("yymmssfff") + ex;
                string path = Path.Combine(wwwroot + "/img/", filename);
                using (var filestream = new FileStream(path, FileMode.Create))
                {
                    await obj.Course.ImgFile.CopyToAsync(filestream);
                }
                obj.Course.StatusId = "3";
                //obj.Course.Featured = 20;
                _db.Courses.Add(obj.Course);
                _db.SaveChanges();
                return RedirectToAction("CourseList");
            }
            return View(obj);
        }

        private string UploadFile(NewCourseVM obj)
        {
            string fileName = null;
            if (obj.Course.ImgFile != null)
            {
                string uploadDir = Path.Combine(WebHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + obj.Course.ImgFile;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    obj.Course.ImgFile.CopyTo(filestream);
                }
            }
            return fileName;
        }

        public IActionResult CourseRegister(int courseId)
        {

            IEnumerable<PricePackage> list = _db.PricePackages;
            //var userInfor = HttpContext.Session.GetString("SessionUser");
            //if (userInfor == null && price_Id != null)
            //{
            //    return Redirect($"~/AccountManagement/Register");
            //}
            var userInfor = HttpContext.Session.GetString("SessionUser");
            if (userInfor != null)
            {
                var obj = userInfor.Replace("\"", string.Empty).Replace("{", string.Empty).Replace("}", string.Empty);
                string[] prop = obj.Split(",");
                var userId = prop[0].Replace("Id:", string.Empty);
                this.ViewBag.UserId = userId;
            }
            this.ViewBag.CourseId = courseId;
            return View(list);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CourseRegister(int priceId, int courseId, string userId)
        {
            IEnumerable<PricePackage> list = _db.PricePackages;
            //var userInfor = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
            var check = HttpContext.Session.GetString("SessionUser");
            if (check == null)
            {
                return Redirect($"~/AccountManagement/Login");
            }
            else
            {
                UserCourse uc = new UserCourse();
                uc.PricePackage = _db.PricePackages.Find(priceId);
                uc.User = _db.Users.Find(Int32.Parse(userId));
                uc.Course = _db.Courses.Find(courseId);
                //uc.StartDate = DateTime.Now;
                //uc.EndDate = DateTime.Now.AddMonths(1);
                _db.UserCourses.Add(uc);
                _db.SaveChanges();
                return Redirect($"~/Home/Index");
            }
            //return View(list);
        }

        public IEnumerable<Course> Search(string key, string sortOrder, string cate, int page)
        {
            ViewData["TitleSort"] = String.IsNullOrEmpty(sortOrder) ? "titleDesc" : "";
            ViewData["DateSort"] = sortOrder == "date" ? "dateDesc" : "date";
            IEnumerable<Course> list = GetCourses();

            if (!string.IsNullOrEmpty(key))
            {
                list = GetCourses().Where(l => l.Title.Contains(key));
            }
            switch (sortOrder)
            {
                case "titleDesc":
                    list = list.OrderByDescending(s => s.Title);
                    break;
                case "date":
                    list = list.OrderBy(s => s.CreatedDate);
                    break;
                case "dateDesc":
                    list = list.OrderByDescending(s => s.CreatedDate);
                    break;
                default:
                    list = list.OrderBy(s => s.Title);
                    break;
            }

            const int pageSize = 6;
            if (page < 1)
            {
                page = 1;
            }
            if (!string.IsNullOrEmpty(cate))
            {
                list = list.Where(l => l.CategoryId.Equals(Int32.Parse(cate)));
            }

            int resCount = list.Count();
            var pager = new Paginated(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).OrderBy(s => s.Featured);
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
            IEnumerable<Course> list = _db.Courses.OrderBy(s => s.Featured);
            return list;
        }

        public Course GetCourse(int id)
        {
            Course c = _db.Courses.Find(id);
            c.Category = _db.Categories.Find(c.CategoryId);
            this.ViewBag.Category = c.Category;
            return c;
        }
    }
}
