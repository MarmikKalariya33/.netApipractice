using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly EcomDbContext _context;
        public ProductController(EcomDbContext context)
        {
            context = _context;
        }
        [HttpGet]
        [Route("GetallProduct")]
        public IActionResult getProduct()
        {
            var List = _context.productModels.ToList();
            return Ok(List);
        }

        [HttpPost]
        [Route("CareateNewProduct")]
        public IActionResult AddNew(productModel obj)
        {
            var isExit = _context.productModels.FirstOrDefault(m => m.productName == obj.productName);
            if(isExit == null)
            {
                _context.productModels.Add(obj);
                _context.SaveChanges();
                return Created("Product Create Successfull",obj);
            }
            else
            {
                return BadRequest(new { message = " product name already exit" });
            }
        }
          
    }
}
