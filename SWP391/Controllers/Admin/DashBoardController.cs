using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SWP391.Data;
using SWP391.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SWP391.Controllers.Admin
{
    public class DashBoardController : Controller
    {
        private readonly LearningDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public DashBoardController(LearningDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }


        public IActionResult DashBoard()
        {
            var user = HttpContext.User;
            if(!user.Identity.IsAuthenticated)
            {
                return Redirect($"~/Home/Index");
            }
            var obj = _userManager.GetUserAsync(user);
            this.ViewBag.User = obj.Result;
            return View(obj);
        }

        
        public async Task<IActionResult> GetProfile()
        {
            var user = HttpContext.User;
            if (!user.Identity.IsAuthenticated)
            {
                return Redirect($"~/Home/Index");
            }
            var obj = _userManager.GetUserAsync(user);


            return new OkObjectResult(obj);
        }

        public IActionResult RegistrationList()
        {
            return View();
        }
    }
}
