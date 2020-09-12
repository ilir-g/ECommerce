using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Areas.Identity.Pages.Account.Manage
{
    public class ChangePasswordModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Utenti> _userManager;
        private readonly SignInManager<Utenti> _signInManager;
        private readonly Services.EmailSender _emailSender;
        private readonly ILogger _logger;

        public ChangePasswordModel(
            Microsoft.AspNetCore.Identity.UserManager<Utenti> userManager,
            SignInManager<Utenti> signInManager,
            Services.EmailSender emailSender,
            ILogger<RegisterModel> logger,
            IConfiguration configuration)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _configuration = configuration;
        }

        [TempData]
        public string StatusMesagge { get; set; }

        [TempData]
        public string ErrorMesagge { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {

            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [Display(Name = "New password")]
            [DataType(DataType.Password)]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostChangePassowrdAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var result = await _userManager.ChangePasswordAsync(user, Input.Password,Input.NewPassword);
            if (result.Succeeded)
            {
                StatusMesagge = "Yor password has been changed succesfully";
                return RedirectToPage();
            }
           
            else
            {
                ErrorMesagge = "Check your old password because it is not corresponding.";
                return RedirectToPage();
            }
        }
    }
}