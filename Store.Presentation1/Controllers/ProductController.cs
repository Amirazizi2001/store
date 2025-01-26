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
        public IActionResult GetAll()
        {
            var products= _productService.GetProducts();
            return Ok(products);
            
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product=_productService.GetProductById(id);
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductDto product)
        {
           _productService.AddProduct(product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            _productService.DeleteProduct(product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _productService.DeleteProduct(id);
            return Ok(true);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
           _productService.UpdateProduct(product);
            return Ok(product);
        }
    }
}
