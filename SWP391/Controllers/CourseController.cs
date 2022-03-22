using Braintree;
using Microsoft.AspNetCore.Authorization;
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
using SWP391.Utility;
using SWP391.Utility.BraintreeService;
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
    public class Products <T>
    {
        public int Id { get; set; }
        public string[] Ids { get; set; }
        public List<T> products { get; set; }
        public string Nonce { get; set; }
        public double Price { get; set; }
        public Products()
        {

        }
        public Products(List<T> p, string n, string[] n1) => (products, Nonce, Ids) = (p, n, n1);
    }

    public class CourseController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly IWebHostEnvironment WebHostEnvironment;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IBraintreeService _braintreeService;
        public CourseController(IBraintreeService braintreeService, LearningDbContext db, IWebHostEnvironment webHostEnvironment, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _db = db;
            WebHostEnvironment = webHostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _braintreeService = braintreeService;
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
            var course_details = from course in _db.Courses
                                 where course.CourseId.Equals(id)
                                 join topic in _db.Topics
                                 on course equals topic.Course
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
        [HttpGet]
        [Route("/Quiz/Topic/{topicid}/Attempt")]
        public IActionResult QuizAttempt(string topicid)
        {
            var topic_quiz = (from quiz in _db.Quizzes where quiz.TopicId.Equals(topicid) join attempt in _db.Attempts on quiz equals attempt.Quiz
                              into gj from x in gj.DefaultIfEmpty()
                              select new Quiz {
                                    QuizId = quiz.QuizId,
                                    Description = quiz.Description,
                                    Duration = quiz.Duration,
                                    Name = quiz.Name,
                                    QuestionNum = quiz.QuestionNum,
                                    TopicId = quiz.TopicId,
                                    QuizType = (from tp in _db.QuizTypes where tp.QuizTypeId.Equals(quiz.QuizTypeId) select tp).FirstOrDefault(),
                                    QuizLevel = (from lv in _db.QuizLevels where lv.QuizLevelId.Equals(quiz.QuizLevelId) select lv).FirstOrDefault(),
                                    Attempts = (from at in _db.Attempts where at.QuizId.Equals(quiz.QuizId) select at).ToList()
                              }).ToList();
            ViewData["TopicName"] = (from tp in _db.Topics where tp.TopicId.Equals(topicid) select tp.TopicName).FirstOrDefault();
            return View(topic_quiz);
        }


        [HttpGet]
        [Route("/Quiz/{quizid}/Attempts")]
        public IActionResult AttemptDetail(string quizid) 
        {
            var attempt_detailed = (from at in _db.Attempts
                                    where at.QuizId.Equals(quizid)
                                    select new Attempt
                                    {
                                        AttemptId = at.AttemptId,
                                        Quiz = (from q in _db.Quizzes where q.QuizId.Equals(quizid) select q).FirstOrDefault(),
                                        StartTime = at.StartTime,
                                        TotalMark = at.TotalMark,
                                        User = _userManager.GetUserAsync(User).Result,
                                        AttemptDetaileds = (from ad in _db.AttemptDetaileds where ad.AttemptId.Equals(at.AttemptId) select ad).ToList()
                                    }).ToList();
            //ViewData["QuestionAnswer"] = (from qb in _db.QuestionBanks join ad in _db.AttemptDetaileds)
            return View(attempt_detailed);
        }

        [AllowAnonymous]
        /// add course to cart
        [Route("AddCart/{courseId}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] string courseId)
        {

            var course = _db.Courses
                           .Where(c => c.CourseId.Equals(courseId))
                            .FirstOrDefault();
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
                return RedirectToRoute(nameof(cart));
            }
            else
            {
                cart.Add(course);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }
        [AllowAnonymous]
        [Route("/RemoveCart/{courseId}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] string courseId)
        {
            var cart = GetCartItems();
            var course = cart.Find(p => p.CourseId == courseId);
            cart.Remove(course);


            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }
        [AllowAnonymous]
        [Route("/UpdateCart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] string courseId)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.CourseId.Equals(courseId));
            if (cartitem != null)
            {
                return null;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        [AllowAnonymous]
        [Route("/Cart", Name = "cart")]
        public IActionResult Cart()
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  
            ViewBag.ClientToken = clientToken;
            Products<Course> products = new Products<Course>() {Id = new Random().Next(), products = GetCartItems(), Nonce = ""};
            return View(products);
        }


        //[Route("/Checkout")]
        //public IActionResult CheckOut()
        //{
        //    return View();
        //}

        public const string CARTKEY = "cart";
        [AllowAnonymous]
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
        [AllowAnonymous]
        public IActionResult ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
            return RedirectToAction(nameof(Cart));
        }
        [AllowAnonymous]
        void SaveCartSession(List<Course> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
        [ServiceFilter(typeof(MyFilter))]
        [HttpPost]
        public IActionResult CheckoutCourse(Products<Course> model)
        {
            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal(model.Price),
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };
            Result<Transaction> result = gateway.Transaction.Sale(request);
            if (result.IsSuccess())
            {

                foreach (var course in model.Ids)
                {
                    CourseOwner courseOwner = new CourseOwner { CourseId = course, CourseOwnerId = _userManager.GetUserAsync(User).Result.Id , PurchaseTime = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", DateTime.Now.Date))};
                    _db.CourseOwners.Add(courseOwner);
                    _db.SaveChanges();
                }
                ClearCart();
                return View("Cart");
            }
            else
            {
                return View("Cart");
            }
        }

        [Route("/Course/Attempt/{quizid}")]
        public IActionResult Attempt(string quizid) 
        {

            return View();
        }

    }
}
