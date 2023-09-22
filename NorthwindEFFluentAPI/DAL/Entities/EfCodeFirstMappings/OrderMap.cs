using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFFluentAPI.DAL.Entities.EfCodeFirstMappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.HasKey(t => t.OrderId);

            this.Property(t => t.CustomerId)
                .IsFixedLength() //fixlength sabit boyutlu demek yani char(5) diyelim. 2 karakter bile girsek toplamda 5 karakterlik yer kaplar. 3 tanede boşluk karakterini yanına ekler ve depolar. boşa yer kaplar. bunun için değişken boyutlu olanı tercih edilmelidir ki depolama aygıtından(HDD/SSD) tasarruf edelim. 
                .HasMaxLength(5);

            this.ToTable("Orders");

            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");

            this.HasOptional(t => t.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerId); //Customers ve Order tablosu arasında 1'e çok ilişki var.
            //Bu noktada Customers tablosu parent yani anaç tablo Orders tablosu ise Child yani yavru/oğul tablodur. 
        }
    }
}