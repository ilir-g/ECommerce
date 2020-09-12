using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNet.Identity;

namespace Ecommerce.Pages
{
    public class ClientiModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public ClientiModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Ecommerce.Models.Clienti> clienti { get;  set; }
        public Ecommerce.Models.Clienti cliente { get; set; }

        public async Task OnGetAsync()
        {
            clienti = await _db.Clienti
                                .AsNoTracking()
                                .ToListAsync();

        }

        public async Task<IActionResult> OnGetDelete(int? id)
        {
            if (id != null)
            {
                cliente = await _db.Clienti.FindAsync(id);

                _db.Clienti.Remove(cliente);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("./Ricerca");
        }


    }
}