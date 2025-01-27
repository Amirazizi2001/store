using Store.Application.Dtos;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Interfaces
{
   public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id);
         Task<bool> AddProduct(CreateProductDto product);
         Task <bool> UpdateProduct(Product product);
         Task <bool> DeleteProduct(Product product);
         Task<bool> DeleteProduct(int id);
       
    }
}
