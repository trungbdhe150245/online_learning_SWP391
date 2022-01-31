using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class AccountManagementController : Controller
    {
        private readonly OnlineLearningDbContext _db;

        public AccountManagementController(OnlineLearningDbContext db)
        {
            _db = db;
        }

        public IActionResult userProfile(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var user = _db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //GET - EDIT PROFILE
        public IActionResult editProfile(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var user = _db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }


        //POST - EDIT PROFILE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult editProfile(User obj)
        {
            var temp = _db.Users.Find(obj.Id);
            temp.Username = obj.Username;
            temp.Full_Name = obj.Full_Name;
            temp.Gender = obj.Gender;
            temp.Phone = obj.Phone;
            temp.Dob = obj.Dob;
            _db.Users.Update(temp);
            _db.SaveChanges();
            return RedirectToAction("userProfile");

        }

        //GET - CHANGE PASSWORD
        [HttpGet]
        public IActionResult changePassword(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var user = _db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //POST - CHANGE PASSWORD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult changePassword(User obj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("userProfile");
            }
            return View(obj);
        }


        public IActionResult changePhoto()
        {
            return View();
        }

        public IActionResult resetNewPassword()
        {
            return View();
        }
        public IActionResult resetPassword()
        {
            return View();
        }


    }
}
