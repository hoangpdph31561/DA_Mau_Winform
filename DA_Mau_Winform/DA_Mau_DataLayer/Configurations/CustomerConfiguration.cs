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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.PhoneNumber);
            builder.Property(x => x.PhoneNumber).IsUnicode(false).HasMaxLength(15);
            builder.Property(x => x.Name).IsUnicode(true).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Address).IsUnicode(true).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Gender).IsRequired(true);
            builder.HasOne(x => x.Employee).WithMany(x => x.Customers).HasForeignKey(x => x.EmployeeId);
        }
    }
}
