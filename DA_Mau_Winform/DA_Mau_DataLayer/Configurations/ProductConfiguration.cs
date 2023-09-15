using DA_Mau_DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Mau_DataLayer.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(50).IsUnicode(true);
            builder.Property(x => x.Quantity).IsRequired(true);
            builder.Property(x => x.InputPrice).IsRequired(true);
            builder.Property(x => x.SellPrice).IsRequired(true);
            builder.Property(x => x.PhotoPath).IsRequired(false).HasMaxLength(400).IsUnicode(false);
            builder.Property(x => x.Note).IsRequired(true).HasMaxLength(20).IsUnicode(true);
            builder.HasOne(x => x.Employee).WithMany(x => x.Products).HasForeignKey(x => x.EmployeeId);
        }
    }
}
