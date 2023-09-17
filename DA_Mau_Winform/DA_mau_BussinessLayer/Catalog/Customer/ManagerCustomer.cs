using DA_Mau_DataLayer.DBContext;
using DA_mau_Utilities.CustomerRequest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_BussinessLayer.Catalog.Customer
{
    public class ManagerCustomer : IManagerCustomer
    {
        private readonly ShopDBContext _dbContext;
        private DbContextOptions<ShopDBContext> GetDbContextOptions()
        {
            // Replace with your actual connection string and other configurations
            var optionsBuilder = new DbContextOptionsBuilder<ShopDBContext>()
                .UseSqlServer(@"Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=DA_Mau_Shop_Code_First;Integrated Security=True;TrustServerCertificate=true");

            return optionsBuilder.Options;
        }
        public ManagerCustomer()
        {
            var dbContextOptions = GetDbContextOptions();
            _dbContext = new ShopDBContext(dbContextOptions);
        }
        public async Task<List<CustomerViewModel>> GetAll(string? phoneNumber)
        {
            if(phoneNumber == null)
            {
                var result = await _dbContext.Customers.Include(x => x.Employee).Select(x => new CustomerViewModel
                {
                    PhoneNumber = x.PhoneNumber,
                    Name = x.Name,
                    Address = x.Address,
                    Gender = x.Gender,
                    EmployeeName = x.Employee.Name,
                }).ToListAsync();
                return result;
            }
            else
            {
                var result = await _dbContext.Customers.Include(x => x.Employee).Where(x => x.PhoneNumber.Contains(phoneNumber)).Select(x => new CustomerViewModel
                {
                    PhoneNumber = x.PhoneNumber,
                    Name = x.Name,
                    Address = x.Address,
                    Gender = x.Gender,
                    EmployeeName = x.Employee.Name,
                }).ToListAsync();
                return result;
            }
        }

        public async Task<bool> CreateNewCustomer(CreateNewCustomerRequest request)
        {
            try
            {
                if(_dbContext.Customers.Any(x => x.PhoneNumber == request.PhoneNumber))
                {
                    return false;
                }
                DA_Mau_DataLayer.Entities.Customer newCustomer = new()
                {
                    PhoneNumber = request.PhoneNumber,
                    Name = request.Name,
                    Address = request.Address,
                    Gender = request.Gender,
                    EmployeeId = request.EmployeeId
                };
                _dbContext.Customers.Add(newCustomer);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateCustomer(string phoneNumber, CustomerUpdateRequest request)
        {
            try
            {
                var customer = await _dbContext.Customers.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
                if (customer == null)
                {
                    return false;
                }
                customer.Name = request.Name;
                customer.Address = request.Address;
                customer.Gender = request.Gender;
                _dbContext.Customers.Update(customer);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCustomer(string phoneNumber)
        {
            try
            {
                var customer = await _dbContext.Customers.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber); 
                if(customer == null)
                {
                    return false;
                }
                _dbContext.Customers.Remove(customer);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
