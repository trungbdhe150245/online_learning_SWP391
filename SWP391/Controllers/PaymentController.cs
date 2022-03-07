﻿using Braintree;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Utility.BraintreeService;
using System;

namespace SWP391.Controllers
{
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

        public IActionResult Payment(string id)
        {
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();  //Genarate a token
            ViewBag.ClientToken = clientToken;
            var package = _learningDbContext.Packages.Find(id);
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