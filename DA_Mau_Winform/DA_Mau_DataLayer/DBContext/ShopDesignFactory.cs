using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Mau_DataLayer.DBContext
{
    public class ShopDesignFactory : IDesignTimeDbContextFactory<ShopDBContext>
    {
        public ShopDBContext CreateDbContext(string[] args)
        {
            string connectionString = @"Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=DA_Mau_Shop_Code_First;Integrated Security=True;TrustServerCertificate=true";
            var optionBuilder = new DbContextOptionsBuilder<ShopDBContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new ShopDBContext(optionBuilder.Options);
        }
    }
}
