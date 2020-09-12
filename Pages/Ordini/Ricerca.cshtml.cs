using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pages.Ordini
{
    public class RicercaModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public RicercaModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Models.Ordini> ordini { get; set; }

        public async Task OnGetAsync()
        {
            ordini = await _db.Ordini
                                 .Include(o => o.Cliente)
                                 .Include(o => o.Prodotto)
                                 .AsNoTracking()
                                 .ToListAsync();

            //When first loading the page the DatePicker has no value
            FilterData = null;
        }



        #region FILTER BY

            //Filter by Prodotto-descizione
            [BindProperty]
            public Models.Prodotti prodotto { get; set; }
            public List<SelectListItem> ProdottoList { get; set; }
            public int IDProd { get; set; }
            public IEnumerable<SelectListItem> GetProdotto()
            {
                ProdottoList = _db.Prodotti
                        .OrderBy(c => c.Descrizione)
                            .Select(c =>
                            new SelectListItem
                            {
                                Value = c.IdProdotto.ToString(),
                                Text = c.Descrizione
                            }).ToList();

                return ProdottoList;
            }


            //Filter by Cita
            [BindProperty]
            public Models.Ordini ordine { get; set; }
            public List<SelectListItem> CitaList { get; set; }
            public string IDCita { get; set; }
            public IEnumerable<SelectListItem> GetCita()
            {
                CitaList = _db.Ordini                   
                    .Distinct()
                        .OrderBy(c => c.Cita)
                            .Select(c =>
                                        new SelectListItem
                                        {
                                            Value = c.Cita,
                                            Text = c.Cita
                                        })
                                        .Distinct()
                            .ToList();

                return CitaList;
            }


            //Filter by Data
            public DateTime? FilterData { get; set; }


            // Ordini By Filter
            public async Task OnPostOrdiniByFilterAsync(string IDCita, int? IDProd, DateTime? FilterData)
            {
            //optimizim i kodit per filtrim
             ordini = await  _db.Ordini.Where(p=>IDCita==null?true:p.Cita==IDCita)
                .Where(p=>IDProd==null?true:p.IdProdotto==IDProd)
                .Where(p=>FilterData==null?true:p.Date==FilterData)
                .Include(p => p.Prodotto)
                .Include(p => p.Cliente)
                .OrderByDescending(p => p.IdProdotto)
                .ToListAsync();

            // all of the fields given
          /*  if (IDCita != null && IDProd != null && FilterData != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.Cita == IDCita)
                                    .Where(p => p.IdProdotto == IDProd)
                                    .Where(p => p.Date == FilterData)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                // two of the fields given
                else if (IDCita != null && IDProd != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.Cita == IDCita)
                                    .Where(p => p.IdProdotto == IDProd)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                else if (IDCita != null && FilterData != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.Cita == IDCita)
                                    .Where(p => p.Date == FilterData)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                else if (IDProd != null && FilterData != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.IdProdotto == IDProd)
                                    .Where(p => p.Date == FilterData)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                // only one of the fields given
                else if (IDProd != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.IdProdotto == IDProd)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                else if (IDCita != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.Cita == IDCita)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                else if (FilterData != null)
                {
                    ordini = await _db.Ordini
                                    .Where(p => p.Date == FilterData)
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .OrderByDescending(p => p.IdProdotto)
                                    .ToListAsync();
                }
                // none of the fields give => list all ordine
                else
                {
                    ordini = await _db.Ordini
                                    .Include(p => p.Prodotto)
                                    .Include(p => p.Cliente)
                                    .AsNoTracking()
                                    .ToListAsync();
                }*/

            }
        #endregion

       


    }
}