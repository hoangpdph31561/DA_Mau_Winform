using DA_mau_Utilities.EmployeeRequest;
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
    }
}
