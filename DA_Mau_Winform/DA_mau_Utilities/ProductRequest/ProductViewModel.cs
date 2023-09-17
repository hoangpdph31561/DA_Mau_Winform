using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.ProductRequest
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal InputPrice { get; set; }
        public decimal SellPrice { get; set; }
        public string Images { get; set; }
        public string Note { get; set; }
        public string EmployeeName { get; set; }
    }
}
