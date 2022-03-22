using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWP391.Data;
using SWP391.Models;

namespace SWP391.Areas.Identity.Pages.Account.Manage
{
    public class CourseModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly LearningDbContext _db;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public CourseModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IWebHostEnvironment WebHostEnvironment,
            LearningDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _WebHostEnvironment = WebHostEnvironment;
            _db = db;
        }

        public List<Course> Courses { get; set; }
        public Paginated Paginated { get; set; }

        private async Task LoadAsync(int pge, int keyy)
        {
            var user = await _userManager.GetUserAsync(User);
            List<Course> courses = new List<Course>();
            //List<CourseOwner> courseOwners = _db.CourseOwners.Where(c => c.User.Id.Equals(user.Id)).ToList();
            //foreach (var c in courseOwners)
            //{
            //    Course course = _db.Courses.Find(c.CourseId);
            //    if (course != null)
            //    {
            //        Category category = _db.Categories.Find(course.CategoryId);
            //        course.Category = category;
            //        courses.Add(course);
            //    }
            //}
            if (keyy == 2)
            {
                courses = _db.Courses.Where(c => c.UserId.Equals(user.Id)).ToList();
                foreach (var c in courses)
                {
                    Category cate = _db.Categories.Find(c.CategoryId);
                    c.Category = cate;
                }

            }
            else
            {
                List<CourseOwner> courseOwners = _db.CourseOwners.Where(c => c.User.Id.Equals(user.Id)).ToList();
                foreach (var c in courseOwners)
                {
                    Course course = _db.Courses.Find(c.CourseId);
                    if (course != null)
                    {
                        Category category = _db.Categories.Find(course.CategoryId);
                        course.Category = category;
                        courses.Add(course);
                    }
                }
            }
            const int pageSize = 3;
            if (pge < 1)
            {
                pge = 1;
            }

            int resCount = courses.Count();
            var pager = new Paginated(resCount, pge, pageSize);
            Paginated = pager;
            int recSkip = (pge - 1) * pageSize;
            var data = courses.Skip(recSkip).Take(pager.PageSize).OrderBy(s => s.SlideId);
            this.ViewData["Key"] = keyy;
            Courses = data.ToList();
        }

        public async Task<IActionResult> OnGetAsync(int pge, int keyy)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(pge, keyy);
            return Page();
        }


    }
}
