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

        public IActionResult CourseList(string key, string sortOrder, string cate, int page)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.courses = Search(key, sortOrder, cate, page);
            return View(dy);
        }

        public IActionResult CourseDetail(string id)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            dy.course = GetCourse(id);
            return View(dy);
        }

        public IActionResult CreateCourse()
        {
            NewCourseVM newCourseVM = new NewCourseVM()
            {
                Course = new Course(),
                TypeDropDown = _db.Categories.Select(i => new SelectListItem
                {
                    Text = i.CategoryValue,
                    Value = i.CategoryId.ToString()
                })
            };
            return PartialView(newCourseVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse(NewCourseVM obj)
        {
            int id = 30;
            obj.Course.CourseId = id.ToString();
            id++;
            //IEnumerable<Course> list = _db.Courses;
            //string id = (list.Count() + 1).ToString();
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

                obj.Course.StatusId = 3;
                obj.Course.CourseId = id.ToString();
                id++;
                obj.Course.SlideId = 30;
                _db.Courses.Add(obj.Course);
                _db.SaveChanges();
                return RedirectToAction("CourseList");
            }
            return View(obj);
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
                list = list.Where(l => l.CategoryId.Equals(cate));
            }

            int resCount = list.Count();
            var pager = new Paginated(resCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;

            var data = list.Skip(recSkip).Take(pager.PageSize).OrderBy(s => s.SlideId);
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
            IEnumerable<Course> list = _db.Courses.OrderBy(s => s.SlideId).Where(s => s.StatusId == 1);
            return list;
        }

        public Course GetCourse(string id)
        {
            Course c = _db.Courses.Find(id);
            c.Category = _db.Categories.Find(c.CategoryId);
            this.ViewBag.Category = c.Category;
            return c;
        }



        public IActionResult Lesson(string id)
        {
            return View();
        }
        /*

        /// add course to cart
        [Route("addcart/{courseId}")]
        public IActionResult AddToCart([FromRoute] string courseId)
        {

            var product = _db.Courses
                            .Where(c => c.CourseId == courseId)
                            .FirstOrDefault();
            if (product == null)
                return NotFound("Cart empty!");

            //Putin cart


            return RedirectToAction(nameof(Cart));
        }


        // Remove item in cart
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid)
        {

            // Remove 1 entry of Cart ...
            return RedirectToAction(nameof(Cart));
        }

        /// Update
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {
            // Update quantity ...

            return RedirectToAction(nameof(Cart));
        }


        // Display cart
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            // Order handler
            return View();
        }
        */
    }
}
