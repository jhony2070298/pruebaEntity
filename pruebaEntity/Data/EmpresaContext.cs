using pruebaEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace pruebaEntity.Data
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext() : base("EmpresaContext")
        {
            
        }
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}