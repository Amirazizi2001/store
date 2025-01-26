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
        public bool AddProduct(CreateProductDto productDto)
        {
            try
            {
                var product = new Product()
                {
                    Name = productDto.Name,
                    Stoke=productDto.Stoke,
                    Price=productDto.Price


                };
                _context.products.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteProduct(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Deleted;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
           var product=GetProductById(id);
            DeleteProduct(product);
            return true;    
        }

        public Product GetProductById(int id)
        {
            return _context.products.SingleOrDefault(p=>p.Id==id);
        }

        public IEnumerable<Product> GetProducts()
        {
           return _context.products.ToList();
            
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
