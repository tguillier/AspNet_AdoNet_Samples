using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StokotopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }

        public StokotopContext() : base("name=StokotopContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Store>()
                .HasMany<Product>(s => s.Products)
                .WithRequired(p => p.Store)
                .HasForeignKey(p => p.StoreId);
        }
    }
}