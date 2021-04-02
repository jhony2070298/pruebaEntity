using pruebaEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pruebaEntity.Data
{
    public class Inicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpresaContext>
    {
        public override void InitializeDatabase(EmpresaContext context)
        {
            base.InitializeDatabase(context);

            var clientes = new List<Clientes>
            {
                new Clientes { Nombre = "jhony", Email="jhdjj@gmail.com" },
                new Clientes { Nombre = "maria", Email="maria@gmail.com" }
            };
            clientes.ForEach(c=>context.Clientes.Add(c));
            context.SaveChanges();
        }
    }
}