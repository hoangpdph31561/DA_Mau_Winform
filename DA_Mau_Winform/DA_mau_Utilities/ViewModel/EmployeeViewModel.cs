using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }

    }
}
