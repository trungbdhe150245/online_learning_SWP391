using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SWP391.Models;
using System.Threading.Tasks;
using XTLASPNET;

namespace SWP391.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<AppUser> signInManager, ILogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            if (!_signInManager.IsSignedIn(User)) return RedirectToPage("/Index");

            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out");
            return RedirectToPage("Index");

            //return ViewComponent(MessagePage.COMPONENTNAME,
            //    new MessagePage.Message()
            //    {
            //        Title = "Logged out",
            //        HtmlContent = "Logged out successfully",
            //        UrlRedirect = (returnUrl != null) ? returnUrl : Url.Page("/Index")
            //    }
            //);
        }
    }
}