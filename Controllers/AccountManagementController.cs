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
            if(id == 0 || id == null)
            {
                return NotFound();
            }
            var user = _db.Users.Find(id);
            if(user == null)
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
            _db.Users.Update(obj);
            //CHƯA UPDATE DATABASE:
            //Auth_Provider
            //Avatar_Url
            //Reset_password_token
            //Verification_code
            //Status_Id
            obj.Auth_Provider = "xx";
            obj.Reset_password_token = "xx";
            _db.SaveChanges();
            return RedirectToAction("userProfile");
        }

        public IActionResult changePassword()
        {
            return View();
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
