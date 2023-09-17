using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.ProductRequest
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal InputPrice { get; set; }
        public decimal SellPrice { get; set; }
        public string ImagePath { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }

    }
}
