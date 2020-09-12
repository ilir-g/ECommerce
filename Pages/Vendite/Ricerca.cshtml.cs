using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using System.Linq;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Pages
{
    public class VenditeModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public VenditeModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Ecommerce.Models.Vendite> Vendite { get; set; }
        public Ecommerce.Models.Vendite vendita { get; set; }

        public async Task OnGetAsync()
        {
           Vendite = await _db.Vendite
                                .Include(c => c.Cliente)
                                .Include(c => c.Prodotto)
                                .AsNoTracking()
                                .ToListAsync();
        }

        public async Task<IActionResult> OnGetDelete(int? id)
        {
            if (id != null)
            {
                vendita = await _db.Vendite.FindAsync(id);

                _db.Vendite.Remove(vendita);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("./Ricerca");
        }
    }
}