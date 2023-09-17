using DA_mau_Utilities.CustomerRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_BussinessLayer.Catalog.Customer
{
    public interface IManagerCustomer
    {
        Task<List<CustomerViewModel>> GetAll(string? phoneNumber);
        Task<bool> CreateNewCustomer(CreateNewCustomerRequest request);
        Task<bool> UpdateCustomer(string phoneNumber, CustomerUpdateRequest request);
        Task<bool> DeleteCustomer(string phoneNumber);
    }
}
