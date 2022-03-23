using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility.BraintreeService;
using SWP391.Views.ViewModel;
using System;
using System.Collections.Generic;
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
            return RedirectToAction("course","user");
        }

        public IActionResult CreateTopic(int i)
        {
            NewCourseVM nc = new NewCourseVM();
            Topic t = nc.Topics[i];
            return PartialView("CreateTopic",t);
        } 

    }
}
