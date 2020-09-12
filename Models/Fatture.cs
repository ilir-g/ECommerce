using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Fatture
    {
        [Key]
        public int IdFattura { get; set; }

       
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

      
        [DataType(DataType.Text)]
        [Display(Name = "Cognome")]
        public string Cognome { get; set; }

       
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

       
        [DataType(DataType.Text)]
        [Display(Name = "Via/Citta")]
        public string Indirizzo { get; set; }

       
        [DataType(DataType.Date)]
        [Display(Name = "DataNascita")]
        public string DataNascita { get; set; }

       
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string Telefono { get; set; }

       
        [DataType(DataType.PostalCode)]
        [Display(Name = "Codice Postale")]
        public string CodicePostale { get; set; }

        public int IdOrdini { get; set; }

        public decimal Somma { get; set; }

        [Display(Name = "Iva Fattura")]
        public decimal IvaFattura { get; set; }

    }
}
