using DA_Mau_DataLayer.DBContext;
using DA_Mau_DataLayer.Entities;
using DA_mau_Utilities.ProductRequest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_BussinessLayer.Catalog.Product
{
    public class ManageProductService : IManageProductService
    {
        private readonly ShopDBContext _dbContext;
        private DbContextOptions<ShopDBContext> GetDbContextOptions()
        {
            // Replace with your actual connection string and other configurations
            var optionsBuilder = new DbContextOptionsBuilder<ShopDBContext>()
                .UseSqlServer(@"Data Source=PHAMDUCHOANG\SQLEXPRESS;Initial Catalog=DA_Mau_Shop_Code_First;Integrated Security=True;TrustServerCertificate=true");

            return optionsBuilder.Options;
        }
        public ManageProductService()
        {
            var dbContextOption = GetDbContextOptions();
            _dbContext = new ShopDBContext(dbContextOption);
        }
        public async Task<List<ProductViewModel>> GetAll(string? productName)
        {
            var result = await _dbContext.Products.Include(x => x.Employee).Select(x => new ProductViewModel
            {
                ProductId = x.Id,
                ProductName = x.Name,
                ProductQuantity = x.Quantity,
                InputPrice = x.InputPrice,
                SellPrice = x.SellPrice,
                Images = x.PhotoPath,
                Note = x.Note,
                EmployeeName = x.Employee.Name
            }).ToListAsync();
            
            if(!string.IsNullOrWhiteSpace(productName)) 
            {
                result = (List<ProductViewModel>)result.Where(x => x.ProductName.ToLower().Trim().Contains(productName.ToLower().Trim()));
                
            }
            return result;
        }

        public async Task<bool> CreateNewProduct(ProductCreateRequest request)
        {
            try
            {
                DA_Mau_DataLayer.Entities.Product newProduct = new()
                {
                    Name = request.Name,
                    Quantity = request.Quantity,
                    InputPrice = request.InputPrice,
                    SellPrice = request.SellPrice,
                    PhotoPath = request.ImagePath,
                    Note = request.Note,
                    EmployeeId = request.EmployeeId
                };
                _dbContext.Products.Add(newProduct);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;   
            }
        }

        public async Task<bool> UpdateProduct(int productId, ProductUpdateRequest request)
        {
            try
            {
                var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
                if (product == null)
                {
                    return false;
                }
                product.Name = request.Name;
                product.Quantity = request.Quantity;
                product.InputPrice = request.InputPrice;
                product.SellPrice = request.SellPrice;
                product.Note = request.Note;
                product.PhotoPath = request.PhotoPath;
                _dbContext.Products.Update(product);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                
                var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
                if (product == null)
                {
                    return false;
                }
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CheckProductInventory>> CheckProductInventory()
        {
            var data = await (from c in _dbContext.Products
                       group c by c.Name into g
                       select new CheckProductInventory
                       {
                           ProductName = g.Key,
                           Quantity = g.Sum(x => x.Quantity)    
                       }).ToListAsync();
            return data;          
                       
        }
    }
}
