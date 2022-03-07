using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SWP391.Utility;

namespace SWP391.Controllers
{
    public class MembershipController : Controller
    {
        [ServiceFilter(typeof(Filter))]
        public IActionResult Index()
        {
            return View();
        }
    }
}
