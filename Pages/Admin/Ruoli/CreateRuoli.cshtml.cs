using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pages.Admin.Ruoli
{
    public class CreateRuoliModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Models.Utenti> _userManager;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<Models.Ruoli> _roleManager;
        public CreateRuoliModel(
            ApplicationDbContext db, 
            Microsoft.AspNetCore.Identity.UserManager<Models.Utenti> userManager,
            Microsoft.AspNetCore.Identity.RoleManager<Models.Ruoli> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public class InputModel
        {
            public string Id { get; set; }
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Role Name")]
            public string RoleName { get; set; }
        }
        [BindProperty]
        public InputModel Input { get; set; }

        public Models.Ruoli Ruolo { get; set; }
        [TempData]
        public string ResultMessage { get; set; }
        public async Task OnGetAsync(string Id)
        {
          
            if (Id == null)
            {
                ViewData["Title"] = "New Ruolo";
            }
            else
            {
                ViewData["Title"] = "Edit Ruolo";
                Ruolo = await _db.Ruoli.FindAsync(Id);
            }
        }
        [HttpPost]
        public async Task<IActionResult> OnPostAddRuoloAsync(Models.Ruoli ruolo)
        {          
                if (ruolo.Id == null)
                {

                    if (!await _roleManager.RoleExistsAsync(ruolo.Name))
                    {

                        _db.Ruoli.Add(new Models.Ruoli()
                        {
                            Name = ruolo.Name,
                            NormalizedName = ruolo.Name.ToUpper()
                        });
                        _db.SaveChanges();


                        return RedirectToPage("/Admin/Ruoli/IndexRuoli");
                    }
                    else
                    {
                        ResultMessage = "Role already exists!";
                        return RedirectToPage();
                    }
                }
                else
                {
                    ruolo.NormalizedName = ruolo.Name.ToString().ToUpper();
                    _db.Attach(ruolo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                   
                    await _db.SaveChangesAsync();
                    return RedirectToPage("/Admin/Ruoli/IndexRuoli");
                }
            }
           
    }
}