using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Controllers;
using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Areas.Identity.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Utenti> _userManager;
        private readonly SignInManager<Utenti> _signInManager;
        private readonly Services.EmailSender _emailSender;
        private readonly ILogger _logger;

        public ConfirmEmailModel(
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
        public string Message { get; set; }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> OnPostAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{userId}'.");
            }
            
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                ViewData["Mesagge"] = "Your email has been successfully confirmed";
               
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                ViewData["Mesagge"] = "An error ocurred. Please,Try again to confirm your email!";
                return Page();
            }
                
        }

    }
}