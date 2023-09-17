using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.EmployeeRequest
{
    public class UpdateRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }
    }
}
