using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.EmployeeRequest
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public Role? Role { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
