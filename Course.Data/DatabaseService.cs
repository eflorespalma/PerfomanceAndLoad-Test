﻿using Course.Entity;
using System.Data.Entity;

namespace Course.Data
{
    public class DatabaseService : DbContext
    {
        public IDbSet<Person> Person { get; set; }
        public IDbSet<Gift> Gift { get; set; }
        public IDbSet<Product> Product { get; set; }

        public DatabaseService() : base("cn")
        {
        }

        public void Save()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Gift>().ToTable("Gift");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
