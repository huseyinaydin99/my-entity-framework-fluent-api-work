using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindEFFluentAPI.DAL.Entities.EfCodeFirstMappings;

namespace NorthwindEFFluentAPI.DAL.Context
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("Name = ConnectionString")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
