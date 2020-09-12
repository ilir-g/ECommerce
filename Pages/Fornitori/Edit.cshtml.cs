using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pages.Fornitori
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Ecommerce.Models.Fornitori fornitore { get; set; }

        public static int IDTemp;
        public async Task OnGetAsync(int id)
        {
            IDTemp = id;
            if (id == 0)
            {
                ViewData["Mesagge"] = "Crea nuovo fornitore";
                ViewData["Title"] = "Nuovo Fornitore";
            }
            else
            {
                ViewData["Mesagge"] = "Update Fornitore";
                ViewData["Title"] = "Edit Fornitore";
                fornitore = await _db.Fornitori
                                .SingleOrDefaultAsync(c => c.IdFornitore == id)
                                ;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //CREATE
            if (IDTemp == 0)
            {
                if (!ModelState.IsValid)
                {

                    ViewData["Title"] = "New Fornitore";
                    ViewData["Error"] = "Could not create new fornitore.";
                    return Page();
                }

                _db.Fornitori.Add(fornitore);
                await _db.SaveChangesAsync();

                return RedirectToPage("./Ricerca");
            }
            //UPDATE
            else
            {
                if (!ModelState.IsValid)
                {
                    ViewData["Title"] = "Edit Fornitore";
                    ViewData["Error"] = "Could not update fornitore.";
                    return Page();
                }

                _db.Attach(fornitore).State = EntityState.Modified;

                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_db.Fornitori.Any(e => e.IdFornitore == fornitore.IdFornitore))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToPage("./Ricerca");
            }

        }
    }
}