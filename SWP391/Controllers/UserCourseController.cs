using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility.BraintreeService;
using SWP391.Views.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Controllers
{
    public class UserCourseController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly IWebHostEnvironment WebHostEnvironment;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IBraintreeService _braintreeService;
        public UserCourseController(IBraintreeService braintreeService, LearningDbContext db, IWebHostEnvironment webHostEnvironment, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _db = db;
            WebHostEnvironment = webHostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _braintreeService = braintreeService;
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            var course = _db.Courses.Find(id);
            _db.Courses.Remove(course);
            _db.SaveChanges();
            return RedirectToAction("course", "user");
        }

        public IActionResult CreateTopic(int i)
        {
            NewCourseVM nc = new NewCourseVM();
            Topic t = new Topic();
            return PartialView("CreateTopic", t);
        }

        public IActionResult EditCourse(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NewCourseVM newCourseVM = new NewCourseVM()
            {
                Course = new Course(),
                TypeDropDown = _db.Categories.Select(i => new SelectListItem
                {
                    Text = i.CategoryValue,
                    Value = i.CategoryId.ToString()
                })

            };
            Course c = _db.Courses.Find(id);
            newCourseVM.Course = c;
            if (newCourseVM.Course == null)
            {
                return NotFound();
            }
            newCourseVM.Course.Category = _db.Categories.Find(newCourseVM.Course.CategoryId);
            return View(newCourseVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCourse(NewCourseVM c)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (ModelState.IsValid)
            {
                if (c.Course.ImgFile != null)
                {
                    string wwwroot = WebHostEnvironment.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(c.Course.ImgFile.FileName);
                    string ex = Path.GetExtension(c.Course.ImgFile.FileName);
                    c.Course.ThumbnailURL = filename = filename + ex;
                    string path = Path.Combine(wwwroot + "/img/", filename);
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await c.Course.ImgFile.CopyToAsync(filestream);
                    }
                }
                
                c.Course.UserId = user.Id;
                c.Course.SlideId = 1;
                c.Course.StatusId = 1;
                _db.Update(c.Course);
                _db.SaveChanges();
                return RedirectToAction("course", "user");
            }
            return View(c);
        }
    }
}
