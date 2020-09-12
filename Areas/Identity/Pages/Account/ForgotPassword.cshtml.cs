using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Areas.Identity.Pages.Account
{
    public class ForgotPasswordModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<Utenti> _userManager;
        private readonly SignInManager<Utenti> _signInManager;
        private readonly EmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _db;

        public ForgotPasswordModel(
            UserManager<Utenti> userManager,
            SignInManager<Utenti> signInManager,
            EmailSender emailSender,
            ILogger<LoginModel> logger,
             IConfiguration configuration,
             ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _configuration = configuration;
            _db = db;
        }
        [BindProperty]
        //public SignInManager<Utenti> SignInManager { get; private set; }
        public InputModel Input { get; set; }
        public class InputModel
        {

            [Required]
            [EmailAddress]
            
            public string Email { get; set; }

        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //var user = _db.Utenti.Single(u => u.Email == Input.Email);
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    ViewData["Mesagge"] = "An error occurred. Check your email address and try it again";
                    // If we got this far, something failed, redisplay form
                    return Page();
                }
                

                _emailSender.EnableSSL = _configuration.GetValue<bool>("EmailSender:EnableSSL");
                _emailSender.HostSmtp = _configuration["EmailSender:Host"];
                _emailSender.Port = _configuration.GetValue<int>("EmailSender:Port");
                _emailSender.FromEmail = _configuration["EmailSender:EmailName"];
                _emailSender.Password = _configuration["EmailSender:Password"];
                // For more information on how to enable account confirmation and password reset please
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                //var callbackUrl = Url.ResetPasswordCallbackLink(user.Id, code, Request.Scheme);
                var callbackUrl = Url.Page(
                     "/Account/ResetPassword",
                     pageHandler: null,
                     values: new { userId = user.Id, code = code },
                     protocol: Request.Scheme);
                await _emailSender.SendEmailAsync(Input.Email, "Reset Password",
                   $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");
                return Redirect("/Identity/Account/ForgotPasswordConfirmation");
            }
            ViewData["Mesagge"] = "An erro occurred. Check your email address and try it again";
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}