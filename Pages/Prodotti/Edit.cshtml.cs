using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Ecommerce.Pages.Prodotti
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Models.Prodotti prodotto { get; set; }

        [BindProperty]
        public IList<Models.InfoProdotto> infoprodotti { get; set; }

        public static List<Models.InfoProdotto> p_infoprodotti = new List<Models.InfoProdotto>();

        public static List<Models.InfoProdotto> p_infoprodottiDeleted = new List<Models.InfoProdotto>();
        public IList<Models.CategoriaProdotti> ListCategoriaProdotti { get; set; }

        [BindProperty]
        public Models.InfoProdotto infoprodotto { get; set; }

        [TempData]
        public int IDTemp { get; set; }
        [TempData]
        public bool ShowFormDetail { get; set; }
        public static int temp;

        public void DataBind()
        {
            IDTemp = temp;
            if (ListCategoriaProdotti == null)
            {
                ListCategoriaProdotti = _db.CategoriaProdotti
                                                    .AsNoTracking()
                                                    .ToList();
            }
            if (prodotto == null)
            {
                prodotto = _db.Prodotti
                                .Include(p => p.CategoriaProdotti)
                                .SingleOrDefault(c => c.IdProdotto == IDTemp);
            }
            if (infoprodotti == null)
            {
                infoprodotti = _db.InfoProdotto
                                    .Where(p => p.IdProdotto == IDTemp)
                                    .AsNoTracking()
                                    .ToList();
                p_infoprodotti = (List<Models.InfoProdotto>)infoprodotti;
                p_infoprodottiDeleted = new List<Models.InfoProdotto>();
            }

        }




        public async Task OnGetAsync(int id)
        {
            IDTemp = id;
            temp = id;
            ShowFormDetail = false;
            //CREATE
            if (id == 0)
            {
                ViewData["Mesagge"] = "Crea nuovo prodotto";
                ViewData["Title"] = "Nuovo Prodotto";

            }
            //UPDATE
            else
            {
                ViewData["Mesagge"] = "Update Prodotto";
                ViewData["Title"] = "Edit Prodotto";

            }
            DataBind();
        }

        public async Task<IActionResult> OnPostSaveAsync()
        {
            if (p_infoprodottiDeleted.Count != 0)
            {
                foreach (var item in p_infoprodottiDeleted)
                {
                    if (item.IdInfoProdotto != 0)
                    {
                        _db.Attach(item).State = EntityState.Deleted;
                    }
                }
            }
            //CREATE
            if (temp == 0)
            {
                if (!ModelState.IsValid)
                {
                    ViewData["Title"] = "New Product";
                    ViewData["Error"] = "Could not create new Product.";
                    return Page();
                }

                _db.Prodotti.Add(prodotto);
                await _db.SaveChangesAsync();

                if (p_infoprodotti.Count == 0)
                {
                    // If the user does not give ANY info about the product => DO NOT add in db
                }
                else
                {
                    foreach (var item in p_infoprodotti)
                    {
                        //Add in the db
                        int lastProductId = _db.Prodotti.Max(x => x.IdProdotto);
                        item.IdProdotto = lastProductId;
                        _db.InfoProdotto.Add(item);
                        await _db.SaveChangesAsync();
                      
                    }
                }
                
            }
            //UPDATE
            else
            {
                if (!ModelState.IsValid)
                {
                    ViewData["Title"] = "Edit Product";
                    ViewData["Error"] = "Could not update Product.";
                    return Page();
                }

                //When there is existing Info for the product (update+add)
                if (p_infoprodotti.Count != 0)
                {
                    //UPDATE
                    foreach (var item in p_infoprodotti)
                    {
                        if (item.IdInfoProdotto == 0)
                        {
                            //Add in the db
                            item.IdProdotto = prodotto.IdProdotto;
                            _db.InfoProdotto.Add(item);
                        }
                        else
                        {
                            _db.Attach(item).State = EntityState.Modified;
                        }

                        await _db.SaveChangesAsync();
                    }
                }
                _db.Attach(prodotto).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                //p_infoprodotti = new List<Models.InfoProdotto>();
                //p_infoprodottiDeleted = new List<Models.InfoProdotto>();

                
            }
            return RedirectToPage("./Ricerca");

        }




        public IActionResult OnPostAddInfoAsync()
        {
            ShowFormDetail = true;
            DataBind();
            return Page();
        }

        public IActionResult OnPostSaveInfoAsync(int id)
        {
            IDTemp = temp;
            if (p_infoprodotti.Count == 0 && IDTemp > 0)
            {
               
                
                    p_infoprodotti = _db.InfoProdotto
                                        .Where(p => p.IdProdotto == IDTemp)
                                        .AsNoTracking()
                                        .ToList();
                
            }
            DataBind();
            if (id == 0)
            {
                //insert new item
                if (infoprodotto.LuogoMagazzino != null && infoprodotto.Quantita != null && infoprodotto.MediaVenduti != null)
                {
                        var item = p_infoprodotti.FirstOrDefault(i => i.LuogoMagazzino == infoprodotto.LuogoMagazzino);
                        if (item == null)
                        {
                            p_infoprodotti.Add(infoprodotto);
                            ShowFormDetail = false;
                            infoprodotti = p_infoprodotti;
                        }
                        else
                        {
                            ViewData["Error"] = "Questa magazzina gia esiste!";
                            ShowFormDetail = true;
                        }
                }
                else
                {
                    ViewData["Error"] = "Insert all InfoProdotto fields!";
                    ShowFormDetail = true;
                }
            }
            else
            {
                //update existing
                var item = p_infoprodotti.First(i => i.IdInfoProdotto == id);
                var exists = p_infoprodotti.FirstOrDefault(u => u.LuogoMagazzino == item.LuogoMagazzino);
                if (exists != null)
                {
                    item.LuogoMagazzino = infoprodotto.LuogoMagazzino;
                    item.MediaVenduti = infoprodotto.MediaVenduti;
                    item.Quantita = infoprodotto.Quantita;

                    ShowFormDetail = false;
                    infoprodotti = p_infoprodotti;
                }
                else
                {
                    ViewData["Error"] = "Questa magazzina gia esiste!";
                    ShowFormDetail = true;
                }

            }


            return Page();
        }

        public IActionResult OnPostEditAsync(int id)
        {
            if (p_infoprodotti.Count == 0 && IDTemp > 0)
            {

                p_infoprodotti = _db.InfoProdotto
                                        .Where(p => p.IdProdotto == IDTemp)
                                        .AsNoTracking()
                                        .ToList();

            }
            if (id > 0)
            {
                infoprodotto = p_infoprodotti.First(i => i.IdInfoProdotto == id);
            }
            else
            {
                ViewData["Error"] = "Non puoi editare un item che hai aggiunto, prima elimina e poi crea uno nuovo!";
                ShowFormDetail = false;
                DataBind();
                return Page();

            }
           
            ShowFormDetail = true;
            DataBind();
            return Page();
        }

        public IActionResult OnPostDeleteAsync(string LuogoMagazzino)
        {
           
            IDTemp = temp;
            if (p_infoprodotti.Count == 0 && IDTemp > 0)
            {
                p_infoprodotti = _db.InfoProdotto
                                        .Where(p => p.IdProdotto == IDTemp)
                                        .AsNoTracking()
                                        .ToList();                
            }
            DataBind();
            var item = p_infoprodotti.First(i => i.LuogoMagazzino == LuogoMagazzino);
            
            p_infoprodottiDeleted.Add(item);
            p_infoprodotti.Remove(item);
            infoprodotti = p_infoprodotti;
            ShowFormDetail = false;
            return Page();
        }

        public IActionResult OnPostCancelAsync()
        {
            IDTemp = temp;
            if (p_infoprodotti.Count == 0 && IDTemp != 0)
            {
                p_infoprodotti = _db.InfoProdotto
                                    .Where(p => p.IdProdotto == IDTemp)
                                    .AsNoTracking()
                                    .ToList();
            }

            infoprodotti = p_infoprodotti;
            ShowFormDetail = false;
            DataBind();
            return Page();
        }

       
    }
}