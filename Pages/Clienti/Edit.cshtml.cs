using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pages.Clienti
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Ecommerce.Models.Clienti cliente { get; set; }

        public static int IDTemp;
        public async Task OnGetAsync(int id)
        {
            IDTemp = id;
            if (id == 0)
            {
                ViewData["Mesagge"] = "Create new Client";
                ViewData["Title"] = "New Client";
            }
            else
            {
                ViewData["Mesagge"] = "Update Client";
                ViewData["Title"] = "Edit Client";
                cliente = await _db.Clienti
                                .SingleOrDefaultAsync(c => c.IdCliente == id)
                                ;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //CREATE
            if(IDTemp == 0)   
            {
                if (!ModelState.IsValid)
                {
                    
                    ViewData["Title"] = "New Client";
                    ViewData["Error"] = "Could not create new client.";
                    return Page();
                }

                _db.Clienti.Add(cliente);
                await _db.SaveChangesAsync();

                return RedirectToPage("./Ricerca");
            }
            //UPDATE
            else     
            {
                if (!ModelState.IsValid)
                {
                    ViewData["Title"] = "Edit Client";
                    ViewData["Error"] = "Could not update  client.";
                    return Page();
                }

                _db.Attach(cliente).State = EntityState.Modified;

                try
                {
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_db.Clienti.Any(e => e.IdCliente == cliente.IdCliente))
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