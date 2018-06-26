using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace task1.Models
{
    public partial class databaseContext : DbContext
    {
        public databaseContext() : base("name=aleetaDBContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add<ManyToManyCascadeDeleteConvention>();
           // base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Images> Images { get; set; }
    }
}