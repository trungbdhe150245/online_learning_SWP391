using Braintree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility;
using SWP391.Utility.BraintreeService;
using System;

namespace SWP391.Controllers
{
    [ServiceFilter(typeof(Filter))]
    public class MembershipController : Controller
    {
        private readonly IBraintreeService _braintreeService;
        private readonly ILogger<MembershipController> _logger;

        private readonly LearningDbContext _learningDbContext;
        public MembershipController(ILogger<MembershipController> logger, LearningDbContext learningDbContext, IBraintreeService braintreeService)
        {
            _learningDbContext = learningDbContext;
            _logger = logger;
            _braintreeService = braintreeService;
        }
        public IActionResult Index()
        {
            var packages = _learningDbContext.Packages;
            return View(packages);
        }
        
        public IActionResult Payment(string packageId) 
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            var package = _learningDbContext.Packages.Find(packageId);
            return View(package);
        }
        //public IActionResult  { get; set; }
        [HttpPost]
        public IActionResult Create()
        {
            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal("250"),
                PaymentMethodNonce = "",
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                }
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);

            if (result.IsSuccess())
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }
        }
    }
}
