using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Ecommerce.Models;
using Ecommerce.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
      
            private readonly UserManager<Ecommerce.Models.Utenti> _userManager;
            private readonly SignInManager<Ecommerce.Models.Utenti> _signInManager;
            private readonly EmailSender _emailSender;
            private readonly IConfiguration _configuration;

        public IndexModel(
                UserManager<Ecommerce.Models.Utenti> userManager,
                SignInManager<Ecommerce.Models.Utenti> signInManager,
                EmailSender emailSender,
                IConfiguration configuration)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _emailSender = emailSender;
               _configuration = configuration;
            }

            public string Username { get; set; }

            public bool IsEmailConfirmed { get; set; }

            [TempData]
            public string StatusMessageSucces { get; set; }
            [BindProperty]
            public InputModel Input { get; set; }

            public class InputModel
            {
                [Required]
                [DataType(DataType.Text)]
                [Display(Name = "Full name")]
                public string Name { get; set; }
           
                [Required]
                [EmailAddress]
                public string Email { get; set; }

                [Phone]
                [Display(Name = "Phone number")]
                public string PhoneNumber { get; set; }
            }

            public async Task<IActionResult> OnGetAsync()
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                }

                var userName = await _userManager.GetUserNameAsync(user);
                var email = await _userManager.GetEmailAsync(user);
                var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
                
                Username = userName;

                Input = new InputModel
                {
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Name = user.Name
                };

                IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);

                return Page();
            }

            public async Task<IActionResult> OnPostAsync()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                }

                var email = await _userManager.GetEmailAsync(user);
                if (Input.Email != email)
                {
                    var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                    if (!setEmailResult.Succeeded)
                    {
                        var userId = await _userManager.GetUserIdAsync(user);
                        throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{userId}'.");
                    }
                }
               
                var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
                if (Input.PhoneNumber != phoneNumber)
                {
                    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                    if (!setPhoneResult.Succeeded)
                    {
                        var userId = await _userManager.GetUserIdAsync(user);
                        throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                    }
                }

               if (Input.Name != user.Name)
               {
                 user.Name = Input.Name;
               }

               await _userManager.UpdateAsync(user);

                await _signInManager.RefreshSignInAsync(user);
                StatusMessageSucces = "Your profile has been updated";
                return RedirectToPage();
            }

            public async Task<IActionResult> OnPostSendVerificationEmailAsync()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
            var user = await _userManager.GetUserAsync(User);
           
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
           
            var userId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            var callbackUrl = Url.Page(
             "/Account/ConfirmEmail",
             pageHandler: null,
             values: new { userId = userId, code = code },
             protocol: Request.Scheme);

            _emailSender.EnableSSL = _configuration.GetValue<bool>("EmailSender:EnableSSL");
            _emailSender.HostSmtp = _configuration["EmailSender:Host"];
            _emailSender.Port = _configuration.GetValue<int>("EmailSender:Port");
            _emailSender.FromEmail = _configuration["EmailSender:EmailName"];
            _emailSender.Password = _configuration["EmailSender:Password"];

            await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                StatusMessageSucces = "Verification email sent. Please check your email.";
                return RedirectToPage();
            }
        
    }
}