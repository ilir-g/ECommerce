using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Prodotti
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProdotto {get; set;}

        public int? IdCategoria { get; set; }

        public string Descrizione { get; set;}
        public decimal Altezza { get; set;}
        public decimal Larghezza { get; set;}
        public decimal Profondita { get; set;}
        public decimal Peso { get; set;}
        public decimal Prezzo { get; set;}
        public bool BloccoProdotto { get; set;}

        public virtual CategoriaProdotti CategoriaProdotti { get; set; }

        public virtual ICollection<Vendite> Vendite { get; set; }
    }
}
