using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Mau_DataLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal InputPrice { get; set; }
        public decimal SellPrice { get; set; }
        public string PhotoPath { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
