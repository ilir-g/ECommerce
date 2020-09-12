using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Pages.Admin.Ruoli
{
    public class GestireRuoliModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly Microsoft.AspNetCore.Identity.UserManager<Models.Utenti> _userManager;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<Models.Ruoli> _roleManager;
        public GestireRuoliModel(
            ApplicationDbContext db,
            Microsoft.AspNetCore.Identity.UserManager<Models.Utenti> userManager,
            Microsoft.AspNetCore.Identity.RoleManager<Models.Ruoli> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

       
        [BindProperty]
        public Models.Ruoli Ruolo { get; set; }
        [DisplayName("Utente")]
        public string UtenteNome { get; set; }
        [DisplayName("Ruolo")]
        public string RuoloName { get; set; }
       
        public List<SelectListItem> UtentiList { get; set; }
        public List<SelectListItem> RuoliList { get; set; }

        public IEnumerable<SelectListItem> GetRoles()
        {

             RuoliList = _db.Ruoli
                    .OrderBy(r=>r.Name)
                        .Select(r =>
                        new SelectListItem
                        {
                            Value = r.Id,
                            Text = r.Name
                        }).ToList();
            return RuoliList;
        }
        
        public IEnumerable<SelectListItem> GetUtenti()
        {

            UtentiList = _db.Utenti
                   .OrderBy(r => r.UserName)
                       .Select(r =>
                       new SelectListItem
                       {
                           Value = r.Id,
                           Text = r.UserName
                       }).ToList();
            return UtentiList;
        }
        #region Add User To Role
        public string RuoloId { get; set; }
        public string UtenteId { get; set; }
        [TempData]
        public string TempMessageAdd { get; set; }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostAddUserToRoleAsync(string UtenteId, string RuoloId)
        {
            Utenti utente = _db.Utenti.Where(u => u.Id.Equals(UtenteId, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            Models.Ruoli ruoli = _db.Ruoli.Where(r => r.Id.Equals(RuoloId, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            var result = await _userManager.AddToRoleAsync(utente, ruoli.Name);
            if (result.Succeeded)
            {
                TempMessageAdd = "Role assigned successfully for this user  !";
            }
            else
            {
                TempMessageAdd = "The Role exists for this user!";
                return Page();
            }
            return RedirectToPage();
        }
        #endregion

        #region Get User Role List
        public string UtenteRuoloId { get; set; }
        public IList<string> RuoliDiUtente { get; set; }
        [TempData]
        public int HasRuolo { get; set; }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostGetUserRoleAsync(string UtenteRuoloId)
        {
            if (!string.IsNullOrWhiteSpace(UtenteRuoloId))
            {
                Utenti utente = _db.Utenti.Where(u => u.Id.Equals(UtenteRuoloId, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                RuoliDiUtente = await _userManager.GetRolesAsync(utente);
                if(RuoliDiUtente.Count == 0)
                {
                    RuoliDiUtente = null;
                    HasRuolo = -1;
                }
                return Page();
            }
            
            return Page();
        }
        #endregion

        #region Delete User From Role
        public string RuoloIdDel { get; set; }
        public string UtenteIdDel { get; set; }
        [TempData]
        public string TempMessageDel { get; set; }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OnPostDeleteUserFromRoleAsync(string UtenteIdDel, string RuoloIdDel)
        {
            
           Utenti utente = _db.Utenti.Where(u => u.Id.Equals(UtenteIdDel, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            Models.Ruoli ruoli = _db.Ruoli.Where(r => r.Id.Equals(RuoloIdDel, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            if (await _userManager.IsInRoleAsync(utente,ruoli.Name))
            {
               await _userManager.RemoveFromRoleAsync(utente,ruoli.Name);
                TempMessageDel = "Role removed from this user successfully !";
            }
            else
            {
                TempMessageDel = "This user doesn't belong to selected role.";
            }
            
            return Page();
        }
        #endregion
    }
}