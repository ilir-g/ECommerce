using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Utenti : IdentityUser
    {
        public Utenti(string UserName) : base(UserName) { }
        public string Name { get; set; }
    }
}
