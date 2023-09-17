using DA_mau_Utilities.EmployeeRequest;
using DA_mau_Utilities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_BussinessLayer.Catalog.Employee
{
    public interface IManageEmployeeService
    {
        Task<LoginResult> Login(LoginRequest request);
        Task <bool> ForgetPassword(ForgetPasswordRequest request);
        Task <bool> ChangePassword(ChangePasswordRequest request);
        Task<List<EmployeeViewModel>> GetAll(string? name);
        Task<bool> CreateEmployee(CreateNewEmployeeRequest request);
        Task<bool> Updateemployee(UpdateRequest request,string email);
        Task<bool> DeleteEmployee(string email);
    }
}
