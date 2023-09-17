using DA_Mau_DataLayer.DBContext;
using DA_Mau_DataLayer.Entities;
using DA_mau_Utilities.Common_Use;
using DA_mau_Utilities.EmployeeRequest;
using DA_mau_Utilities.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_BussinessLayer.Catalog.Employee
{
    public class ManageEmployeeService : IManageEmployeeService
    {
        private readonly ShopDBContext _dbContext;
        private DbContextOptions<ShopDBContext> GetDbContextOptions()
        {
            // Replace with your actual connection string and other configurations
            var optionsBuilder = new DbContextOptionsBuilder<ShopDBContext>()
                .UseSqlServer(@"Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=DA_Mau_Shop_Code_First;Integrated Security=True;TrustServerCertificate=true");

            return optionsBuilder.Options;
        }
        public ManageEmployeeService()
        {
            var dbContextOptions = GetDbContextOptions();
            _dbContext = new ShopDBContext(dbContextOptions);
        }

        public async Task<LoginResult> Login(LoginRequest request)
        {
            var employee = await _dbContext.Employees.Where(x => x.Email == request.Email && x.Password == request.Password).FirstOrDefaultAsync();
            if (employee == null)
            {
                return new LoginResult()
                {
                    IsSuccess = false,
                };
            }
            return new LoginResult()
            {
                IsSuccess = true,
                Id = employee.Id,
                Email = employee.Email,
                Password = employee.Password,
                Role = employee.Role,
            };
        }

        public async Task<bool> ForgetPassword(ForgetPasswordRequest request)
        {
            var employeeForgetPass = await _dbContext.Employees.Where(x => x.Email == request.Email).FirstOrDefaultAsync();
            if (employeeForgetPass == null)
            {
                return false;
            }
            var newPassword = CommonUnitilyUse.RandomPassword(6, true);
            CommonUnitilyUse.SendMail(request.Email, newPassword);
            employeeForgetPass.Password = newPassword;
            _dbContext.Employees.Update(employeeForgetPass);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ChangePassword(ChangePasswordRequest request)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (employee == null || employee.Password != request.OldPassword || request.NewPassword != request.ConfirmPassword)
            {
                return false;
            }
            employee.Password = request.NewPassword;
            _dbContext.Employees.Update(employee);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<EmployeeViewModel>> GetAll(string? name)
        {

            if (name == null)
            {
                var result = await _dbContext.Employees.Select(x => new EmployeeViewModel
                {
                    Id = x.Id,
                    Email = x.Email,
                    Name = x.Name,
                    Address = x.Address,
                    Role = x.Role,
                    Status = x.Status
                }).ToListAsync();
                return result;
            }
            else
            {
                var result = await _dbContext.Employees.Where(x => x.Name.ToLower().Contains(name.ToLower().Trim())).Select(x => new EmployeeViewModel
                {
                    Id = x.Id,
                    Email = x.Email,
                    Name = x.Name,
                    Address = x.Address,
                    Role = x.Role,
                    Status = x.Status
                }).ToListAsync();
                return result;
            }

        }

        public async Task<bool> CreateEmployee(CreateNewEmployeeRequest request)
        {
            try
            {
                if (_dbContext.Employees.Any(x => x.Email == request.Email))
                {
                    return false;
                }

                DA_Mau_DataLayer.Entities.Employee newEmployee = new DA_Mau_DataLayer.Entities.Employee()
                {
                    Name = request.Name,
                    Address = request.Address,
                    Role = request.Role,
                    Status = request.Status,
                    Email = request.Email,
                    Password = request.Password,
                };
                _dbContext.Employees.Add(newEmployee);
                await _dbContext.SaveChangesAsync();
                return true;


            }
            catch
            {

                return false;
            }
        }

        public async Task<bool> Updateemployee(UpdateRequest request, string email)
        {
            try
            {
                var employee = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Email == email);
                if (employee == null)
                {
                    return false;
                }
                employee.Name = request.Name;
                employee.Address = request.Address;
                employee.Role = request.Role;
                employee.Status = request.Status;
                _dbContext.Employees.Update(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteEmployee(string email)
        {
            try
            {
                var employee = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Email == email);
                if (employee == null)
                {
                    return false;
                }
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<IQueryable<CheckEmployeeProductInput>> GetProductInput()
        {
            //var data = from d in _dbContext.Employees
            //           join f in _dbContext.Products
            //           on d.Id equals f.EmployeeId
            //           select new
            //           {
            //               d.Id,
            //               d.Name,
            //               ProductId = f.Id
            //           } into x
            //           group x by new
            //           {
            //               x.Id,
            //               x.Name,
            //           } into g
            //           select new CheckEmployeeProductInput
            //           {
            //               EmployeeId = g.Key.Id,
            //               EmployeeName = g.Key.Name,
            //               ProductCount = g.Select(x => x.ProductId).Count(),
            //           };

            var data = from employee in _dbContext.Employees
            join product in _dbContext.Products
            on employee.Id equals product.EmployeeId into productGroup
            from product in productGroup.DefaultIfEmpty() // Perform a left join
            group new { employee.Id, employee.Name, ProductId = product != null ? product.Id : (int?)null } by new { employee.Id, employee.Name } into grouped
            select new CheckEmployeeProductInput
            {
                EmployeeId = grouped.Key.Id,
                EmployeeName = grouped.Key.Name,
                ProductCount = grouped.Count(x => x.ProductId.HasValue)
            };

            return data;
        }
    }
}
