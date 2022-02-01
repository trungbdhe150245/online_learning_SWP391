using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class PublicFeatureController : Controller
    {
        public IActionResult BlogList()
        {
            return View();
        }
        public IActionResult BlogDetail()
        {
            return View();
        }
    }
}
