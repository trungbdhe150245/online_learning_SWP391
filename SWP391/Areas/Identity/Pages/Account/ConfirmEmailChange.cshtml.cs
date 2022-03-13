using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using SWP391.Models;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailChangeModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ConfirmEmailChangeModel(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string email, string code)
        {
            if (userId == null || email == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code)); //Base64UrlDecode - mã token dành riêng cho từng user
            var result = await _userManager.ChangeEmailAsync(user, email, code); //nếu mã user và code phù hợp sẽ tiến hành đổi email

            //khai báo biên old Email
            var oldEmail = user.Email;

            //Báo lỗi nếu không chính xác
            if (!result.Succeeded)
            {
                StatusMessage = "Error changing email.";
                return Page();
            }

            // In our UI email and user name are one and the same, so when we update the email
            // we need to update the user name.

            //Trường hợp để đăng nhập bằng username và email giống nhau sẽ đổi luôn cả username và email
            if (user.UserName == oldEmail)
            {
                var setUserNameResult = await _userManager.SetUserNameAsync(user, email);//khi đổi địa chỉ email sẽ đổi luôn username
                if (!setUserNameResult.Succeeded)
                {
                    StatusMessage = "Error changing user name.";
                    return Page();
                }
            }


            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Thank you for confirming your email change.";
            return Page();
        }
    }
}
