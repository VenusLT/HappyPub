using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HappyPub.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace HappyPub.DAL
{
    public class PubContext : DbContext
    {
        public PubContext() : base("PubContext")
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}