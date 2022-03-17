using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nancy.Json;
using Newtonsoft.Json;
using SWP391.Data;
using SWP391.Models;
using SWP391.Views.ViewModel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWP391.Controllers
{
    public class CourseController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly IWebHostEnvironment WebHostEnvironment;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public CourseController(LearningDbContext db, IWebHostEnvironment webHostEnvironment, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _db = db;
            WebHostEnvironment = webHostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult CourseList(string key, string sortOrder, string cate, int page)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            var courses = Search(key, sortOrder, cate, page).ToList();
            dy.courses = Search(key, sortOrder, cate, page);
            var user = _userManager.GetUserAsync(User).Result;
            if (user != null)
            {
                List<CourseOwner> list = _db.CourseOwners.Where(c => c.User.Id.Equals(user.Id)).ToList();
                this.ViewBag.CourseOwners = list;
            }
            return View(dy);
        }
        public IActionResult CourseDetail(string id)
        {
            dynamic dy = new ExpandoObject();
            dy.categories = GetCategories();
            //dy.course = GetCourse(id);
            var coursed = GetCourse(id);
            var user = _userManager.GetUserAsync(User).Result;
            bool isMyCourse = false;
            if (user != null)
            {
                List<CourseOwner> list = _db.CourseOwners.Where(c => c.User.Id.Equals(user.Id)).ToList();
                foreach (var item in list)
                {
                    if (item.CourseId.Equals(id))
                    {
                        isMyCourse = true;
                        break;
                    }
                }
            }
            var listtopics = _db.Topics.Where(t => t.CourseId.Equals(id)).ToList();
            foreach (var t in listtopics)
            {
                var listless = _db.Lessons.Where(l => l.TopicId.Equals(t.TopicId)).ToList();
                t.Lessons = listless;
            }
            coursed.Topics = listtopics;
            dy.course = coursed;
            this.ViewBag.ismyCourse = isMyCourse;
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

        public IActionResult SearchInput()
        {
            IEnumerable<Course> list = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44351/");
            var search = hc.GetAsync("Index");
            search.Wait();
            var readdata = search.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var display = readdata.Content.ReadAsAsync<IList<Course>>();
                display.Wait();
                list = display.Result;
            }
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
                list = list.Where(l => l.CategoryId == Int32.Parse(cate));
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
            //JavaScriptSerializer js = new JavaScriptSerializer();
            return list;
        }

        public Course GetCourse(string id)
        {
            Course c = _db.Courses.Find(id);
            c.Category = _db.Categories.Find(c.CategoryId);
            this.ViewBag.Category = c.Category;
            return c;
        }




        [HttpGet]
        [Route("/Course/{id}/Lesson")]
        public IActionResult Lesson(string id)
        {
            //var course_detail = from course in _db.Courses where course.CourseId.Equals(id) join topic in _db.Topics
            //                    on course equals topic.Course join lesson in _db.Lessons
            //                    on topic equals lesson.Topic
            //                    select new Lesson {
            //                        LessonId = lesson.LessonId,
            //                        LessonName = lesson.LessonName,
            //                        LessonOrder = lesson.LessonOrder,
            //                        Script = lesson.Script,
            //                        Topic = lesson.Topic,
            //                        VideoURL = lesson.VideoURL
            //                    };
            var course_details = from course in _db.Courses
                                 where course.CourseId.Equals(id)
                                 join topic in _db.Topics
                                on course equals topic.Course
                                 // join lesson in _db.Lessons
                                 //on topic equals lesson.Topic
                                 select new Topic
                                 {
                                     TopicId = topic.TopicId,
                                     Lessons = (from lesson in _db.Lessons
                                                where lesson.TopicId.Equals(topic.TopicId)
                                                select new Lesson
                                                {
                                                    LessonId = lesson.LessonId,
                                                    LessonName = lesson.LessonName,
                                                    LessonOrder = lesson.LessonOrder,
                                                    Script = lesson.Script,
                                                    VideoURL = lesson.VideoURL,
                                                    Topic = topic
                                                }).ToList(),
                                     Course = topic.Course,
                                     TopicName = topic.TopicName,
                                     TopicOrder = topic.TopicOrder,
                                     Quizzes = topic.Quizzes

                                 };
            return View(course_details.ToList());
        }
        /// add course to cart
        [Route("Addcart/{courseId}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] string courseId)
        {

            var course = _db.Courses
                           .Where(c => c.CourseId.Equals(courseId))
                            .FirstOrDefault();
            //if (course == null)
            //    return NotFound("Course not found!");

            //Putin cart
            var cart = GetCartItems();
            bool add = false;
            foreach (var product in cart)
            {
                if (course.CourseId.Equals(product.CourseId))
                {
                    add = true;
                    break;
                }
            }

            if (add)
            {
                //return this.PartialView("~/Views/Shared/CustomLayout/_ModalCart.cshtml");
                return RedirectToRoute(nameof(cart));

                //RedirectToAction(nameof(Cart));
            }
            else
            {
                //  Thêm mới
                cart.Add(course);
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }


        // Remove item in cart
        [Route("/Removecart/{courseId}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] string courseId)
        {
            var cart = GetCartItems();
            var course = cart.Find(p => p.CourseId == courseId);
            cart.Remove(course);


            SaveCartSession(cart);
            // Remove 1 entry of Cart ...
            return RedirectToAction(nameof(Cart));
        }

        /// Update
        [Route("/Updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] string courseId)
        {
            // Update quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.CourseId.Equals(courseId));
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                return null;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }


        // Display cart
        [Route("/Cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }

        [Route("/Checkout")]
        public IActionResult CheckOut()
        {
            // Order handler
            return View();
        }



        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";

        // Lấy cart từ Session (danh sách CartItem)
        List<Course> GetCartItems()
        {

            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<Course>>(jsoncart);
            }
            return new List<Course>();
        }

        // Xóa cart khỏi session
        public IActionResult ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
            return RedirectToAction(nameof(Cart));
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<Course> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

    }
}
