using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class InfoProdotto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdInfoProdotto { get; set; }
        public string LuogoMagazzino { get; set; }
        public int? Quantita { get; set; }
        public decimal? MediaVenduti { get; set; }

        //Foreign key
        public int IdProdotto { get; set; }
        public virtual Prodotti Prodotto { get; set; }

    }
}
