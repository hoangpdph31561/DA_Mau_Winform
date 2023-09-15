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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasKey(x => x.EmployeeId);
            builder.Property(x => x.EmployeeId).HasDefaultValueSql("'NV' + CONVERT(VARCHAR, Id)");
            builder.Property(x => x.Email).IsUnicode(false).HasMaxLength(50).IsRequired(true);
            builder.HasIndex(x => x.Email).IsUnique(true);
            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(50).IsUnicode(true);
            builder.Property(x => x.Address).IsRequired(true).HasMaxLength(100).IsUnicode(true);
            builder.Property(x => x.Role).IsRequired(true);
            builder.Property(x => x.Status).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true).HasMaxLength(200).IsUnicode(false);
        }
    }
}
