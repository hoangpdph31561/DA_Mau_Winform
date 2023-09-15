using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DA_Mau_DataLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }

    }
}
