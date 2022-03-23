using Braintree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility;
using SWP391.Utility.BraintreeService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using XTLASPNET;

namespace SWP391.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Nonce { get; set; }
        public PricePackage PricePackage { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBraintreeService _braintreeService;
        private readonly UserManager<AppUser> _userManager;
        private readonly LearningDbContext _db;
        public HomeController(ILogger<HomeController> logger, LearningDbContext db, IBraintreeService braintreeService, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _db = db;
            _braintreeService = braintreeService;
            _userManager = userManager;
        }

        //[AllowAnonymous]
        //[Route("/Home/Index")]
        public IActionResult Index()
        {
            IEnumerable<Course> courses = _db.Courses.Where(c => c.SlideId == 1);
            this.ViewBag.Course = courses;
            UserPricePackage up = new UserPricePackage();
            var user = _userManager.GetUserAsync(User).Result;
            //if (user != null)
            //{
            //    up = _db.UserPricePackages.FirstOrDefault(u => u.UserId.Equals(user.Id));
            //    this.ViewBag.UPP = up;
            //}

            List<Blog> blogs = _db.Blogs.Where(b => b.SlideId == 1).OrderByDescending(b => b.CreatedDate).ToList();
            foreach (var b in blogs)
            {
                string shortdesc = b.Content.Split(",").ToList().First();
                b.Content = shortdesc;
                foreach (var u in _userManager.Users)
                {
                    if (b.UserId.Equals(u.Id))
                    {
                        b.User = u;
                        break;
                    }
                }
            }
            if (user != null)
            {
                List<UserPricePackage> upp = _db.UserPricePackages.Where(u => u.UserId.Equals(user.Id)).ToList();
                this.ViewBag.UP = upp.Count;
                var user_roles = _db.UserRoles.FirstOrDefault(u => u.UserId.Equals(user.Id) && u.RoleId.Equals("ROLE2"));
                this.ViewBag.userAdmin = user_roles;
            }

            this.ViewBag.Blogs = blogs;
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
        }


        [AllowAnonymous]
        [Route("/Membership")]
        public IActionResult Membership()
        {
            List<PricePackage> packages = (from pricepackage in _db.PricePackages select pricepackage).ToList();
            List<string[]> properties = new List<string[]>();
            foreach (var package in packages)
            {
                string[] property = package.Properties.Split("|");
                properties.Add(property);
            }
            ViewBag.Properties = properties;
            return View(packages);
        }

        [ServiceFilter(typeof(MyFilter))]
        [Route("/Membership/{membershipid}")]
        public IActionResult OneMembership(string membershipid)
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            Product product = new Product
            {
                Id = new Random().Next(),
                PricePackage = (from pricepackage in _db.PricePackages
                                where pricepackage.PricePackageId.Equals(Int32.Parse(membershipid))
                                select pricepackage).FirstOrDefault(),
                Nonce = ""
            };
            return View(product);
        }

        [ServiceFilter(typeof(MyFilter))]
        [Route("/Membership/Checkout")]
        public IActionResult CheckoutMembership(Product model)
        {
            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal(model.PricePackage.Price),
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };
            Result<Transaction> result = gateway.Transaction.Sale(request);
            if (result.IsSuccess())
            {
                var roles = _userManager.GetRolesAsync(_userManager.GetUserAsync(User).Result).Result;
                UserPricePackage userPricePackage = new UserPricePackage { PricePackageId = model.PricePackage.PricePackageId, UserId = _userManager.GetUserAsync(User).Result.Id, SubcribeDate = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", DateTime.Now.Date)) };
                _db.UserPricePackages.Add(userPricePackage);
                if(model.PricePackage.PricePackageId == 2 && !roles.Contains("Admin"))
                {
                    UserPricePackage bonus = new UserPricePackage { PricePackageId = 3, UserId = _userManager.GetUserAsync(User).Result.Id, SubcribeDate = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", DateTime.Now.Date)) };
                    _db.UserPricePackages.Add(bonus);
                }

                List<string> roleIds = (from r in _db.Roles select r.Id).ToList();
                foreach (var id in roleIds)
                {
                    if (id.Contains(model.PricePackage.PricePackageId.ToString()))
                    {
                        _db.UserRoles.Add(new IdentityUserRole<string>() { RoleId = id, UserId = _userManager.GetUserAsync(User).Result.Id });
                        if(id.Contains("2") && !roles.Contains("Admin"))
                        {
                            _db.UserRoles.Add(new IdentityUserRole<string>() { RoleId = "ROLE3", UserId = _userManager.GetUserAsync(User).Result.Id });
                        }
                        break;
                    }
                }

                _db.SaveChanges();
                return RedirectToAction("Membership");
            }
            else
            {
                return RedirectToAction("Membership");
            }
        }
    }
}
