using Ecommerce.Models;
using Ecommerce.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


namespace Ecommerce.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        
        private readonly IConfiguration _configuration;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Utenti> _userManager;
        private readonly SignInManager<Utenti> _signInManager;
        private readonly Services.EmailSender _emailSender;
        private readonly ILogger _logger;

        public RegisterModel(
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

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string StatusSuccess { get; set; }
        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Full name")]
            public string Name { get; set; }


            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }


            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Phone Number")]
            
            public string PhoneNumber { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
           
            if (ModelState.IsValid)
            {
                var user = new Utenti(Input.Email)
                {
                    Email = Input.Email,
                    PhoneNumber = Input.PhoneNumber,
                    Name = Input.Name
                   
                };
               
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                     "/Account/ConfirmEmail",
                     pageHandler: null,
                     values: new { userId = user.Id, code = code },
                     protocol: Request.Scheme);

                    _emailSender.EnableSSL = _configuration.GetValue<bool>("EmailSender:EnableSSL");
                    _emailSender.HostSmtp = _configuration["EmailSender:Host"];
                    _emailSender.Port = _configuration.GetValue<int>("EmailSender:Port");
                    _emailSender.FromEmail = _configuration["EmailSender:EmailName"];
                    _emailSender.Password = _configuration["EmailSender:Password"];

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    // await _signInManager.SignInAsync(user, isPersistent: false);
                    StatusSuccess = "Your account has been created succesfully. Verification email sent. Please check your email to confirm it.";
                    return RedirectToPage();
                    
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}