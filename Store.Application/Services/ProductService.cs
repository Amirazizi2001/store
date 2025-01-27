using Microsoft.EntityFrameworkCore;
using Store.Application.Dtos;
using Store.Application.Interfaces;
using Store.Domain.Entities;
using Store.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly StoreDbContext _context;
        public ProductService(StoreDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddProduct(CreateProductDto productDto)
        {
            try
            {
                var product = new Product()
                {
                    Name = productDto.Name,
                    Stoke=productDto.Stoke,
                    Price=productDto.Price


                };
                await _context.products.AddAsync(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> DeleteProduct(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Deleted;
               await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteProduct(int id)
        {
           var product= await GetProductById(id);
            DeleteProduct(product);
            return true;    
        }

        public async Task< Product> GetProductById(int id)
        {
            return await _context.products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _context.products.ToListAsync();
            return products;
            
        }

        public async Task< bool> UpdateProduct(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
