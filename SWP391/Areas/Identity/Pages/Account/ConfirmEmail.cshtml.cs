using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using SWP391.Models;
using System.Text;
using System.Threading.Tasks;
using XTLASPNET;

namespace SWP391.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ConfirmEmailModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string code, string returnUrl)
        {

            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }


            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"User not exist - '{userId}'.");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            // Xác thực email
            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (result.Succeeded)
            {

                // Đăng nhập luôn nếu xác thực email thành công
                await _signInManager.SignInAsync(user, false);

                return ViewComponent(MessagePage.COMPONENTNAME,
                    new MessagePage.Message()
                    {
                        Title = "Email verification",
                        HtmlContent = "Verification success, redirecting..",
                        UrlRedirect = (returnUrl != null) ? returnUrl : Url.Page("/Index")
                    }
                );
            }
            else
            {
                StatusMessage = "Email verification error.";
            }
            return Page();
        }
    }
}