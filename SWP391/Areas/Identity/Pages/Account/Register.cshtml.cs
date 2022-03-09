﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using SWP391.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        // Các dịch vụ được Inject vào: UserManger, SignInManager, ILogger, IEmailSender
        public RegisterModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        // InputModel được binding khi Form Post tới

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        // Xác thực từ dịch vụ ngoài (Googe, Facebook ... bài này chứa thiết lập)
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        // Lớp InputModel chứa thông tin Post tới dùng để tạo User
        public class InputModel
        {
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "Username")]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            [DataType(DataType.Text)]
            [Display(Name = "Full Name")]
            public string FullName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            //[Required]
            //[DataType(DataType.Text)]
            //[Display(Name = "Sex")]
            //public string Sex { get; set; }

            //[Required]
            //[DataType(DataType.Date)]
            //[Display(Name = "Dob")]
            //public DateTime? Birthday { get; set; }

            //[Required]
            //[StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
            //[DataType(DataType.Text)]
            //[Display(Name = "Address")]
            //public string Adress { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        // Đăng ký tài khoản theo dữ liệu form post tới
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                // Tạo AppUser sau đó tạo User mới (cập nhật vào db)
                var user = new AppUser { UserName = Input.UserName, Email = Input.Email, FullName = Input.FullName };
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("Created account successfully.");

                    // phát sinh token theo thông tin user để xác nhận email
                    // mỗi user dựa vào thông tin sẽ có một mã riêng, mã này nhúng vào link
                    // trong email gửi đi để người dùng xác nhận
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    // callbackUrl = /Account/ConfirmEmail?userId=useridxx&code=codexxxx
                    // Link trong email người dùng bấm vào, nó sẽ gọi Page: /Acount/ConfirmEmail để xác nhận
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    // Gửi email    
                    await _emailSender.SendEmailAsync(Input.Email, "Email verification",
                        $"To verify your email <a href='{callbackUrl}'>click here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedEmail)
                    {
                        // Nếu cấu hình phải xác thực email mới được đăng nhập thì chuyển hướng đến trang
                        // RegisterConfirmation - chỉ để hiện thông báo cho biết người dùng cần mở email xác nhận
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        // Không cần xác thực - đăng nhập luôn
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                // Có lỗi, đưa các lỗi thêm user vào ModelState để hiện thị ở html heleper: asp-validation-summary
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }
    }
}