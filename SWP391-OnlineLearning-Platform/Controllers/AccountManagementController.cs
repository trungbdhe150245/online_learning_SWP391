using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391_OnlineLearning_Platform.Data;
using SWP391_OnlineLearning_Platform.Models;
using SWP391_OnlineLearning_Platform.Models.ViewModels;
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

        public IActionResult UserProfile(int? id)
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
        public IActionResult EditProfile(int? id)
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
        public IActionResult EditProfile(User obj)
        {
            var temp = _db.Users.Find(obj.Id);
            temp.Username = obj.Username;
            temp.Full_Name = obj.Full_Name;
            temp.Gender = obj.Gender;
            temp.Phone = obj.Phone;
            temp.Dob = obj.Dob;
            _db.Users.Update(temp);
            _db.SaveChanges();
            return Redirect($"~/AccountManagement/UserProfile?id={obj.Id}");
        }

        //GET - CHANGE PASSWORD
        [HttpGet]
        public IActionResult ChangePassword(int? id)
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
            Change_Password x = new Change_Password();
            x.Id = user.Id;
            x.Full_Name = user.Full_Name;
            x.Avatar_Url = user.Avatar_Url;
            return View(x);
        }

        //POST - CHANGE PASSWORD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(Change_Password obj)
        {
            var temp = _db.Users.Find(obj.Id);
            obj.Id = temp.Id;
            obj.Full_Name = temp.Full_Name;
            obj.Avatar_Url = temp.Avatar_Url;
            if (ModelState.IsValid)
            {
                if (obj.OldPassword == temp.Password)
                {
                    temp.Password = obj.NewPassword;
                    _db.Users.Update(temp);
                    _db.SaveChanges();
                    return Redirect($"~/AccountManagement/UserProfile?id={obj.Id}");
                }
                else
                {
                    ViewBag.ErrorMess = "Password is not correct";
                    return View(obj);
                }
            }
            return View(obj);
        }

        //GET - CHANGE PHOTO
        public IActionResult ChangePhoto(int? id)
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

        //POST - CHANGE PHOTO
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePhoto(User obj)
        {
            var temp = _db.Users.Find(obj.Id);
            temp.Avatar_Url = obj.Avatar_Url;
            _db.Users.Update(temp);
            _db.SaveChanges();
            return Redirect($"~/AccountManagement/UserProfile?id={obj.Id}");
        }


    }
}
