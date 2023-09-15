using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Mau_DataLayer.Entities
{
    public class Customer
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
