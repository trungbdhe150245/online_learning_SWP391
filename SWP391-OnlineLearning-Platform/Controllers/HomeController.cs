using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SWP391_OnlineLearning_Platform.Data;
using System.Security.Cryptography;
using System.Text;

using System.Web;


namespace SWP391_OnlineLearning_Platform.Controllers
{
	public class HomeController : Controller
	{
		/*private readonly ILogger<HomeController> _logger;*/
		private readonly OnlineLearningDbContext _db;

		public HomeController(OnlineLearningDbContext db)
		{
			_db = db;
		}

	/*	public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}*/

       /* public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
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
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(User obj)
		{
			if (ModelState.IsValid)
			{
				if(_db.Users.FirstOrDefault().Email.Equals(obj.Email) && _db.Users.FirstOrDefault().Password.Equals(obj.Password))
				
				/*var data = _db.Users.Where(s => s.Email.Equals(obj.Email) && s.Password.Equals(obj.Password)).ToList();
				if (data.Count() > 0)*/
				{
					/*//add session
					Session["FullName"] = data.FirstOrDefault().Full_Name;
					Session["Email"] = data.FirstOrDefault().Email;
					Session["UserID"] = data.FirstOrDefault().Id;*/
					return RedirectToAction("Index");
				}
				else
				{
					ViewBag.error = "Login failed";
					return RedirectToAction("Login");
				}
			}
			return View();
		}

		/*public static string GetMD5(string str)
		{
			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] fromData = Encoding.UTF8.GetBytes(str);
			byte[] targetData = md5.ComputeHash(fromData);
			string byte2String = null;

			for (int i = 0; i < targetData.Length; i++)
			{
				byte2String += targetData[i].ToString("x2");

			}
			return byte2String;
		}*/
	}
}
