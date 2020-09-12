using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Fornitori
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFornitore { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string CodiceFiscale { get; set; }

        public string RagioneSociale { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascita { get; set; }

        public string LuogoNascita { get; set; }

        public char Sesso { get; set; }

        public bool PersonaFisica { get; set; }

        

    }
}
