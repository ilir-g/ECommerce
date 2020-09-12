using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class CategoriaProdotti
    {

        [Key]
        public int IdCategoria { get; set; }
        public string CategoriaNome { get; set; }
        public string Descrizione { get; set; }

    }
}
