using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pages.Vendite
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Ecommerce.Models.Vendite vendite { get; set; }

        public IList<Models.Clienti> ListClienti { get; set; }
        public IList<Models.Prodotti> ListProdotti { get; set; }

        public static int IDTemp;
        public async Task OnGetAsync(int id)
        {
            IDTemp = id;
            if (id == 0)
            {
                ViewData["Mesagge"] = "Crea nuova vendita";
                ViewData["Title"] = "Nuova Vendita";

                ListClienti = await _db.Clienti
                                    .AsNoTracking()
                                    .ToListAsync()
                                ;

                ListProdotti = await _db.Prodotti
                                    .AsNoTracking()
                                    .ToListAsync()
                                ;
            }
            else
            {
                ViewData["Mesagge"] = "Update Vendita";
                ViewData["Title"] = "Edit Vendita";

                vendite = await _db.Vendite
                                    .SingleOrDefaultAsync(v => v.IdVendita == id)
                                ;

                ListClienti = await _db.Clienti
                                    .AsNoTracking()
                                    .ToListAsync()
                                ;

                ListProdotti = await _db.Prodotti
                                    .AsNoTracking()
                                    .ToListAsync()
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

                    ViewData["Title"] = "New Vendita";
                    ViewData["Error"] = "Could not create new vendita.";
                    return Page();
                }

                _db.Vendite.Add(vendite);
                await _db.SaveChangesAsync();

                return RedirectToPage("./Ricerca");
            }
            //UPDATE
            else
            {
                if (!ModelState.IsValid)
                {
                    ViewData["Title"] = "Edit Vendita";
                    ViewData["Error"] = "Could not update vendita.";
                    return Page();
                }

                _db.Attach(vendite).State = EntityState.Modified;

                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_db.Vendite.Any(e => e.IdVendita == vendite.IdVendita))
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