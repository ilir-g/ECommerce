using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Pages
{
    public class FornitoriModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public FornitoriModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Ecommerce.Models.Fornitori> fornitori  { get; set; }
        public Ecommerce.Models.Fornitori fornitore  { get; set; }

        public async Task OnGetAsync()
        {
            fornitori = await _db.Fornitori
                                .AsNoTracking()
                                .ToListAsync();

        }

        public async Task<IActionResult> OnGetDelete(int? id)
        {
            if (id != null)
            {
                fornitore = await _db.Fornitori.FindAsync(id);

                _db.Fornitori.Remove(fornitore);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("./Ricerca");
        }
    }
}