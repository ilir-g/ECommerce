using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Pages.Prodotti
{
    public class OrdineModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public OrdineModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
      

        [BindProperty]
        public Consegna Consegna { get; set; }


        [BindProperty]
        public Fatture Fattura { get; set; }

        [BindProperty]
        public Models.Ordini ordine { get; set; }

        [BindProperty]
        public Models.Prodotti prodotto { get; set; }
        [BindProperty]

        public IList<Models.InfoProdotto> infoProdotti { get; set; }

        public InfoProdotto InfoProdotto { get; set; }
        [BindProperty]
        public Models.Clienti cliente { get; set; }

        public static int IdProd;
       
        public async Task OnGetAsync(int id)
        {
            IdProd = id;
            prodotto = await _db.Prodotti
                                .SingleOrDefaultAsync(c => c.IdProdotto == id)
                                ;
            infoProdotti = await _db.InfoProdotto
                                .Where(p => p.IdProdotto == id)
                                .AsNoTracking()
                                .ToListAsync();
        }

        public async Task<IActionResult> OnPostSaveOrderAsync()
        {

            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "New Ordine";
                ViewData["Error"] = "Could not create new ordine.";
                return Page();
            }
            
            //Not this client... The one who is logged in
            ordine.IdCliente = 1;
            ordine.IdProdotto = IdProd;
            ordine.Date = DateTime.Today;

            InfoProdotto = await _db.InfoProdotto
                                .Where(p => p.IdProdotto == IdProd && p.LuogoMagazzino == ordine.Cita)
                                .AsNoTracking().SingleAsync();

             if(InfoProdotto.Quantita < ordine.Quantita)
             {
                ViewData["Title"] = "New Ordine";
                ViewData["Error"] = "Prova un altra magazzina. Ci sono solo " + InfoProdotto.Quantita + " prodotti a maggazino " + InfoProdotto.LuogoMagazzino;
                infoProdotti = await _db.InfoProdotto
                               .Where(p => p.IdProdotto == IdProd)
                               .AsNoTracking()
                               .ToListAsync();
                return Page();
             }
             else
             {
                InfoProdotto.Quantita = InfoProdotto.Quantita - ordine.Quantita;
                InfoProdotto.MediaVenduti = InfoProdotto.MediaVenduti + ordine.Quantita;

                _db.Attach(InfoProdotto).State = EntityState.Modified;
                await _db.SaveChangesAsync();
             }
               
            var result = _db.Ordini.Add(ordine);
            if (result.State == EntityState.Added)
            {
                await _db.SaveChangesAsync();
            }
            else
            {
                ViewData["Error"] = "Could not create new ordine.";
                return Page();
            }
            var idOrderine = result.Entity.IdOrdini;
            Fattura.Somma = ordine.SommaTotale;
            Fattura.IdOrdini = int.Parse(idOrderine.ToString());
            _db.Fatture.Add(Fattura);
            await _db.SaveChangesAsync();
            if(Consegna.Nome == null && Consegna.Cognome == null && Consegna.Email == null &&
                Consegna.CodicePostale==null && Consegna.DataNascita==null && Consegna.Indirizzo==null
                && Consegna.Telefono == null)
            {
                Consegna.Nome = Fattura.Nome;
                Consegna.Cognome = Fattura.Cognome;
                Consegna.Email = Fattura.Email;
                Consegna.CodicePostale = Fattura.CodicePostale;
                Consegna.DataNascita = Fattura.DataNascita;
                Consegna.Indirizzo = Fattura.Indirizzo;
                Consegna.Telefono = Fattura.Telefono;
                Consegna.IdOrdini = int.Parse(idOrderine.ToString());
                _db.Consegna.Add(Consegna);
                await _db.SaveChangesAsync();
            }
            else
            {
                Consegna.IdOrdini = int.Parse(idOrderine.ToString());
                _db.Consegna.Add(Consegna);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage("./Ricerca");
        }
        
    }
}