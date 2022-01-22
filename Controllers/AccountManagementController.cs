using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Controllers
{
    public class AccountManagementController : Controller
    {
        public IActionResult resetPassword()
        {
            return View();
        }

        public IActionResult resetNewPassword()
        {
            return View();
        }

        public IActionResult userProfile()
        {
            return View();
        }

        public IActionResult editProfile()
        {
            return View();
        }
        public IActionResult changePassword()
        {
            return View();
        }
    }
}
