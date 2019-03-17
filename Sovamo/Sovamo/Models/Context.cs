using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Sovamo.Models
{
    public class Context : DbContext
    {
        public Context() : base("bancosovamo") { Configuration.ProxyCreationEnabled = false; Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>()); }


        //           Classes aqui


        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove(); modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); }
    }
}