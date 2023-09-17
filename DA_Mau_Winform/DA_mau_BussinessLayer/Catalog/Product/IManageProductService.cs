using DA_mau_Utilities.ProductRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_BussinessLayer.Catalog.Product
{
    public interface IManageProductService
    {
        Task<List<ProductViewModel>> GetAll(string? productName);
        Task<bool> CreateNewProduct (ProductCreateRequest request);
        Task<bool> UpdateProduct(int productId, ProductUpdateRequest request);
        Task<bool> DeleteProduct(int productId);
        Task<List<CheckProductInventory>> CheckProductInventory();
    }
}
