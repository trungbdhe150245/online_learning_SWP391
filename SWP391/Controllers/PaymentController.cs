using Braintree;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Models;
using SWP391.Utility.BraintreeService;
using System;

namespace SWP391.Controllers
{

    public class Product<T>
    {
        public T product { get; set; }
        public string Nonce { get; set; }

        public Product(T p, string n) => (product, Nonce) = (p, n);

        public Product()
        {
        }
    }

    public class PaymentController : Controller
    {
        private readonly IBraintreeService _braintreeService;
        private readonly ILogger<PaymentController> _logger;

        private readonly LearningDbContext _learningDbContext;
        public PaymentController(ILogger<PaymentController> logger, LearningDbContext learningDbContext, IBraintreeService braintreeService)
        {
            _learningDbContext = learningDbContext;
            _logger = logger;
            _braintreeService = braintreeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[Route("/Payment/{id}")]
        public IActionResult PurchaseMembership(string id)
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            var package = _learningDbContext.PricePackages.Find(id);
            Product<PricePackage> product = new Product<PricePackage> { product = package, Nonce = ""};
            return View(product);
        }

        [HttpPost]
        [Route("/Payment/{id}")]
        public IActionResult PurchaseCart()
        {
            return Ok("");
        }




        public IActionResult Purchase(int id)
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            var package = _learningDbContext.PricePackages.Find(id);
            return View(package);
        }
        //public IActionResult  { get; set; }
        [HttpPost]
        public IActionResult Create()
        {
            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal("1000"),
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
                return View("Failure" + "1000");
            }
        }
    }
}
