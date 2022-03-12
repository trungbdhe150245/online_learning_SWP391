using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using SWP391.Utility;
using SWP391.Utility.BraintreeService;

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
            var packages = _learningDbContext.PricePackages;
            return View(packages);
        }
    }
}
