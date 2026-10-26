using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practice.Models;
using System.Security.Cryptography.Pkcs;

namespace practice.Controllers
{
    public class ProductController : Controller
    {
        private readonly EcomDbContext _context;
        public ProductController(EcomDbContext context)
        {
            _context = context;
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

        [HttpPut]
        [Route("UpdateProduct")]

        public IActionResult Update(productModel obj)
        {
            _context.productModels.Update(obj);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        [Route("Deleteproduct")]
        public IActionResult Delete(int id)
        {
            var data = _context.productModels.FirstOrDefault(m => m.productId == id);
            if(data != null)
            {
                _context.productModels.Remove(data);
                _context.SaveChanges();
                return StatusCode(204, new { message = "Deleted" });
            }
            else
            {
                return StatusCode(405, new { message = "Product not found" });
            }
        }
          
    }
}
