using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Core Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Core Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public virtual DbSet<Clienti> Clienti { get; set; }
        public virtual DbSet<Prodotti> Prodotti { get; set; }
        public virtual DbSet<Vendite> Vendite { get; set; }
        public virtual DbSet<InfoProdotto> InfoProdotto { get; set; }
        public virtual DbSet<Fornitori> Fornitori { get; set; }
        public virtual DbSet<Ordini> Ordini { get; set; }
        public virtual DbSet<CategoriaProdotti> CategoriaProdotti { get; set; }

        public virtual DbSet<Utenti> Utenti { get; set; }
        public virtual DbSet<Ruoli> Ruoli { get; set; }

        public virtual DbSet<Consegna> Consegna { get; set; }

        public virtual DbSet<Fatture> Fatture { get; set; }
    }
}
