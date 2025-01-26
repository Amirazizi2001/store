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
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        bool AddProduct(CreateProductDto product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);
        bool DeleteProduct(int id);
    }
}
