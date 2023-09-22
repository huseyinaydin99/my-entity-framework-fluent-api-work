using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFFluentAPI.DAL.Entities.EfCodeFirstMappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.HasKey(t => t.CustomerId);
            this.Property(t => t.CustomerId).HasColumnName("CustomerId")
                .IsRequired();
            this.Property(t => t.Company).HasColumnName("Company")
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.City).HasMaxLength(15).HasColumnName("City");

            this.Property(t => t.Counrty).HasMaxLength(15).HasColumnName("Counrty");

            this.ToTable("Customers");
        }
    }
}
