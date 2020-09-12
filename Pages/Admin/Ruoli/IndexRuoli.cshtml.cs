using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecommerce.Pages.Admin.Ruoli
{
    public class IndexRuoliModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<Models.Ruoli> _roleManager;


        public IndexRuoliModel(ApplicationDbContext db, Microsoft.AspNetCore.Identity.RoleManager<Models.Ruoli> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
        }

        [BindProperty]
        public IList<Models.Ruoli> Ruoli { get; set; }
        [BindProperty]
        public Models.Ruoli Ruolo { get; set; }

        public void OnGetAsync()
        {
            Ruoli =  _roleManager.Roles.ToList();
        }
       
        public async Task<ActionResult> OnGetDelete(string Id=null)
        {
            if (Id != null)
            {
               
                Ruolo = await _db.Ruoli.FindAsync(Id);

                _db.Ruoli.Remove(Ruolo);
                await _db.SaveChangesAsync();
                
                return RedirectToPage();
            }
            return RedirectToPage();
        }

    }
}