using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practice.Models;

namespace practice.Controllers  
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        EcomDbContext _context;
        public CategoryController(EcomDbContext context)
        {
            _context = context;
        }
        public List<CategoryModel> getAllcategory()
        {
            var data = _context.categoryModels.ToList();
            return data;
        }
    }

}
