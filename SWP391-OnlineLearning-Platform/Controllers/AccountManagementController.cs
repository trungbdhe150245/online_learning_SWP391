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
            Change_PasswordVM x = new Change_PasswordVM();
            x.Id = user.Id;
            x.Full_Name = user.Full_Name;
            x.Avatar_Url = user.Avatar_Url;
            return View(x);
        }

        //POST - CHANGE PASSWORD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(Change_PasswordVM obj)
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
            Change_PhotoVM cp = new Change_PhotoVM();
            cp.Avatar_Url = user.Avatar_Url;
            cp.Full_Name = user.Full_Name;
            cp.Id = user.Id;
            return View(cp);
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

        /*LOGIN*/
        public ActionResult Login()
        {
            return View();
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(IFormCollection obj)
        {
            string Email = obj["Email"].ToString();
            string PassWord= obj["PassWord"].ToString();
            var isLogin = _db.Users.SingleOrDefault(x => x.Email.Equals(Email) && x.Password.Equals(PassWord));
            if (ModelState.IsValid)
            {
                if(isLogin != null)
                /*if (_db.Users.Any.Email.Equals(obj.Email) && _db.Users.FirstOrDefault().Password.Equals(obj.Password))*/

                /*var data = _db.Users.Where(s => s.Email.Equals(obj.Email) && s.Password.Equals(obj.Password)).ToList();
				if (data.Count() > 0)*/
                {
                    /*//add session
					Session["FullName"] = data.FirstOrDefault().Full_Name;
					Session["Email"] = data.FirstOrDefault().Email;
					Session["UserID"] = data.FirstOrDefault().Id;*/
                    return RedirectToAction("Home");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return View("Login");
                }
            }
            return View();
        }
        //GET: Register

        public ActionResult Register()
        {
            return View();
        }
        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User _user)
        {
            if (ModelState.IsValid)
            {
                var check = _db.Users.FirstOrDefault(s => s.Email == _user.Email);
                if (check == null)
                {
                    /*_user.Password = GetMD5(_user.Password);
					*//*_db.Configuration.ValidateOnSaveEnabled = false;*/
                    _db.Users.Add(_user);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }


            }
            return View();


        }
    }
}
