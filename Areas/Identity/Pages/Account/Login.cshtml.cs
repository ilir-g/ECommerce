using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly UserManager<Utenti> _userManager;
        private readonly SignInManager<Utenti> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public LoginModel(
            UserManager<Utenti> userManager,
            SignInManager<Utenti> signInManager,
            IEmailSender emailSender,
            ILogger<LoginModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
        }
        public string ErrorMessage { get; set; }
        [BindProperty]
        //public SignInManager<Utenti> SignInManager { get; private set; }
        public InputModel Input { get; set; }
        

        public class InputModel
        {
          
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [Display(Name = "Remember Password")]
            public bool RememberMe { get; set; }

        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostAsync(string returnUrl=null)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(Input.Email);
                if (user != null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ViewData["Mesagge"] = "You must have to confirm your email to log in.";
                        return Page();
                    }
                }
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe,lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");

                    if (returnUrl == null)
                        return LocalRedirect("/Home/Index");
                    else
                        return LocalRedirect(returnUrl);

                }
                else
                {
                    //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    ViewData["Mesagge"] = "Invalid login attempt.";
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}