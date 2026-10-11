using Microsoft.AspNetCore.Mvc;
using practice.Models;

namespace practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly EcomDbContext _context;

        public CategoryController(EcomDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("CreateNewCategory")]
        public CategoryModel AddNew(CategoryModel obj)
        {
            _context.CategoryModels.Add(obj);
            _context.SaveChanges();

            return obj;
        }
    }
}