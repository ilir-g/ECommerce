using Ecommerce.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Ecommerce.Models;
namespace Ecommerce.Pages
{
    public class ProdottiModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public ProdottiModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Models.CategoriaProdotti CategoriaProdotti { get; set; }
        public List<SelectListItem> CategoriaList { get; set; }

        public IList<CategoriaProdotti> categprod { get; set; }


    public int IdCategoriaProdotti { get; set; }
        public IEnumerable<SelectListItem> GetCategorie()
        {
            CategoriaList = _db.CategoriaProdotti
                   .OrderBy(c => c.CategoriaNome)
                       .Select(c =>
                       new SelectListItem
                       {
                           Value = c.IdCategoria.ToString(),
                           Text = c.CategoriaNome
                       }).ToList();
            
            return CategoriaList;
        }

        public async Task OnPostProdottiByFilterAsync(int? IdCategoriaProdotti)
        {
            if (IdCategoriaProdotti != null) {
                prodotti = await
                    _db.Prodotti.Where(p => p.IdCategoria == IdCategoriaProdotti).OrderByDescending(p => p.IdCategoria).Include(p => p.CategoriaProdotti).ToListAsync();
            }
            else
            {
                prodotti = await
                   _db.Prodotti.Include(p => p.CategoriaProdotti).AsNoTracking().ToListAsync();
            }
            
        }
     
        public IList<Models.Prodotti> prodotti { get; set; }
        public Models.Prodotti prodotto { get; set; }

        public Models.CategoriaProdotti categoriaProdotti { get; set; }


        public async Task OnGetAsync()
        {
            prodotti = await _db.Prodotti
                                .Include(p => p.CategoriaProdotti)
                                .AsNoTracking()
                                .ToListAsync();


            categprod = await _db.CategoriaProdotti.AsNoTracking().ToListAsync();

    }

        public async Task<IActionResult> OnGetDelete(int? id)
        {
            if (id != null)
            {
                prodotto = await _db.Prodotti.FindAsync(id);

                _db.Prodotti.Remove(prodotto);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("./Ricerca");
        }
    }
}