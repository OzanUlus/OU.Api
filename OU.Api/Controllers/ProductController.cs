using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OU.Api.Context;
using OU.Api.Entities;

namespace OU.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContex _dbContext;

        public ProductController(AppDbContex dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Add(Product product) 
        {
            _dbContext.Products .Add(new Product() { Name = product.Name, Price = product.Price, Color = product.Color });
            _dbContext.SaveChanges();
            return Ok();
        
        
        }
        [HttpPut("")]
        public IActionResult Update(Product product) 
        {
           
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return Ok();    
        
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var product = _dbContext.Products.Find(id);
            if (product == null) 
            {
                return BadRequest("böyle ürün bulunamadı");
            }
            _dbContext.Products.Remove (product);
            _dbContext.SaveChanges();
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var product = _dbContext.Products.Where(p=>p.Id==id) ;
            
            return Ok(product);

        }
        [HttpGet("")]
        public IActionResult GetAll()
        {
           
            var products = _dbContext.Products.ToList();
            
        
         return Ok(products);
        }
    }
}
