using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Ordini
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 IdOrdini { get; set; }
        public int IdProdotto { get; set; }
        public int IdCliente { get; set; }


        public string Cita { get; set; }
        public int? Deleted { get; set; }
        public int? Quantita { get; set; }
        public decimal SommaTotale { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }


        public virtual Clienti Cliente { get; set; }
        public virtual Prodotti Prodotto { get; set; }
    }
}

