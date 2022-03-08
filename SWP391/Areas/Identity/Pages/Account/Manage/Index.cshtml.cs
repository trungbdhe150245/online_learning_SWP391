﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWP391.Models;

namespace SWP391.Areas.Identity.Pages.Account.Manage
{

    public partial class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public IndexModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IWebHostEnvironment WebHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _WebHostEnvironment = WebHostEnvironment;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone(ErrorMessage = "{0} wrong format")]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
            [DataType(DataType.Text)]
            [Display(Name = "Address")]
            public string Address { get; set; }
            [DataType(DataType.Date)]
            [Display(Name = "BirthDay")]
            public DateTime? Birthday { get; set; }
            [MaxLength(255)]
            [Display(Name = "Full Name")]
            public string FullName { set; get; }
            [DataType(DataType.Text)]
            [Display(Name = "Profile PictureURL")]
            public string ProfilePictureURL { set; get; }

            [NotMapped]
            [DisplayName("Upload Image")]
            public IFormFile ImgFile { get; set; }
        }

        //LẤY THÔNG TIN CỦA USER
        private async Task LoadAsync(AppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Address = user.Address,
                Birthday = user.Birthday,
                FullName = user.FullName,
                ProfilePictureURL = user.ProfilePictureURL,
                ImgFile = user.ImgFile
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

            //string wwwroot = _WebHostEnvironment.WebRootPath;
            //string filename = Path.GetFileNameWithoutExtension(Input.ImgFile.FileName);
            //string ex = Path.GetExtension(Input.ImgFile.FileName);
            //Input.ProfilePictureURL = filename = filename + DateTime.Now.ToString("yymmssfff") + ex;
            //string path = Path.Combine(wwwroot + "/img/", filename);
            //using (var filestream = new FileStream(path, FileMode.Create))
            //{
            //    await Input.ImgFile.CopyToAsync(filestream);
            //}

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
            user.Birthday = Input.Birthday;

            user.FullName = Input.FullName;
            user.ProfilePictureURL = Input.ProfilePictureURL;
            user.ImgFile = Input.ImgFile;

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
        private string UploadFile(AppUser obj)
        {
            string fileName = null;
            if (obj.ImgFile != null)
            {
                string uploadDir = Path.Combine(_WebHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + obj.ImgFile;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    obj.ImgFile.CopyTo(filestream);
                }
            }
            return fileName;
        }
    }


}
