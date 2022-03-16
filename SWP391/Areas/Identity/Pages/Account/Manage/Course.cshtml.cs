using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWP391.Models;

namespace SWP391.Areas.Identity.Pages.Account.Manage
{
    public class CourseModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public CourseModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IWebHostEnvironment WebHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _WebHostEnvironment = WebHostEnvironment;
        }

        public Course Course { get; set; }
        


        //LẤY THÔNG TIN CỦA USER
        private async Task LoadAsync(AppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            Username = userName;
            FullName = user.FullName;
            ProfilePictureURL = user.ProfilePictureURL;


            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Address = user.Address,
                FullName = user.FullName,
                ProfilePictureURL = user.ProfilePictureURL,
            };
        }

        //KIỂM TRA USER ĐÃ LOGIN HAY CHƯA?
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            user.Address = Input.Address;
            user.FullName = Input.FullName;
            user.ProfilePictureURL = Input.ProfilePictureURL;

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
