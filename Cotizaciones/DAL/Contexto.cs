using Cotizaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizaciones.DAL
    
{
    
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Cotizacioness> Cotizaciones { get; set; }

        
        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}