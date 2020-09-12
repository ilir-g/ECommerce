using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ecommerce.Pages
{
    public class CreateClienteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateClienteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Ecommerce.Models.Clienti cliente { get; set; }

      
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Clienti.Add(cliente);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}