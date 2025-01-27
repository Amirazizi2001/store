using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Application.Dtos;
using Store.Application.Interfaces;
using Store.Domain.Entities;

namespace Store.Presentation1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task< IActionResult> GetAll()
        {
            var products= await _productService.GetProducts();
            return Ok(products);
            
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product=await _productService.GetProductById(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task< IActionResult> AddProduct(CreateProductDto product)
        {
           await _productService.AddProduct(product);
            return Ok(product);
        }
        [HttpDelete]
        public async Task< IActionResult> Delete(Product product)
        {
           await  _productService.DeleteProduct(product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
           await  _productService.DeleteProduct(id);
            return Ok(true);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
          await  _productService.UpdateProduct(product);
            return Ok(product);
        }
    }
}
