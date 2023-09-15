using DA_Mau_DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Mau_DataLayer.DataSeeding
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "admin",
                    Email = "admin@gmail.com",
                    Address = "Hà Nội",
                    Password = "admin",
                    Role = DA_mau_Utilities.Enums.Role.Manager,
                    Status = DA_mau_Utilities.Enums.Status.Active,

                });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                   PhoneNumber = "0987654321",
                   Name = "Hoàng",
                   Address = "HN",
                   Gender = DA_mau_Utilities.Enums.Gender.Male,
                   EmployeeId = 1,
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Test",
                    Quantity = 15,
                    InputPrice = 10,
                    SellPrice = 20,
                    Note = "ALo",
                    EmployeeId = 1
                });
        }
    }
}
