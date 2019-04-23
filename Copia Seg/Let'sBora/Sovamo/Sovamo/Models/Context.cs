using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Sovamo.Models
{
    //Context db = new Context();
    //ViewBag.situa = new SelectList(db.Uf, "Id", "Initials");
    public class Context : DbContext
    {
        public Context() : base("Sovamo") { Configuration.ProxyCreationEnabled = false; Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>()); }





        public DbSet<CadCliente> CadClientes { get; set; }
        public DbSet<CadEstabelecimento> CadEstabelecimentoes { get; set; }
        public DbSet<CadUsuario> CadUsuarios { get; set; }
        public DbSet<Sovamo.Models.Evento> Eventoes { get; set; }
        



        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove(); modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); }

        
    }
}