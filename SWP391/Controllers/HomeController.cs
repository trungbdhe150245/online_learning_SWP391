using Braintree;
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

        public IActionResult Index()
        {
            IEnumerable<Course> courses = _db.Courses.Where(c => c.SlideId == 1);
            this.ViewBag.Course = courses;
            return View(courses);
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
        [Route("/About")]
        [Route("/Home/About")]
        public IActionResult About()
        {
            return View();
        }

        
        [Route("/Membership")]
        public IActionResult Membership() 
        {
            List<PricePackage> packages = (from pricepackage in _db.PricePackages select pricepackage).ToList();
            List<string[]> properties = new List<string[]>();
            foreach(var package in packages)
            {
                string[] property = package.Properties.Split("|");
                properties.Add(property);
            }
            ViewBag.Properties = properties;
            return View(packages);
        }

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
                                where pricepackage.PricePackageId.Equals(Int32.Parse(membershipid)) select pricepackage).FirstOrDefault(),
                Nonce = ""
            };
            return View(product);
        }

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
                UserPricePackage userPricePackage = new UserPricePackage {PricePackageId = model.PricePackage.PricePackageId, UserId = _userManager.GetUserAsync(User).Result.Id,  SubcribeDate = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", DateTime.Now.Date))};
                _db.UserPricePackages.Add(userPricePackage);
                _db.SaveChanges();
                return /*RedirectToAction("Index");*/ Ok("Success");
            }
            else
            {
                return Ok("Failed");
            }
        }


    }
}
