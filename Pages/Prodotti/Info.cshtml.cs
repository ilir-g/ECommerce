using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pages.Prodotti
{
    public class InfoModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public InfoModel(ApplicationDbContext db)
        {
            _db = db;
        }


        [BindProperty]
        public Models.Prodotti prodotto { get; set; }

        [BindProperty]
        public IList<Models.InfoProdotto> infoprodotti { get; set; }

        



        public async Task OnGetAsync(int id)
        {
            prodotto = await _db.Prodotti
                               .Include(p => p.CategoriaProdotti)
                                .SingleOrDefaultAsync(p => p.IdProdotto == id)
                                ;

            infoprodotti = await _db.InfoProdotto
                                .Where(p => p.IdProdotto == id)
                                .AsNoTracking()
                                .ToListAsync();
                                 ;
        }
    }
}