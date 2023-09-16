using DA_Mau_DataLayer.DBContext;
using DA_mau_Utilities.Common_Use;
using DA_mau_Utilities.EmployeeRequest;
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

        public  async Task<LoginResult> Login(LoginRequest request)
        {
            var employee =  await _dbContext.Employees.Where(x => x.Email == request.Email && x.Password == request.Password).FirstOrDefaultAsync();
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
            var newPassword = CommonUnitilyUse.RandomPassword(6,true);
            CommonUnitilyUse.SendMail(request.Email, newPassword);
            employeeForgetPass.Password = newPassword;
            _dbContext.Employees.Update(employeeForgetPass);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
