using Microsoft.AspNetCore.Mvc;
using practice.Models;

namespace practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly EcomDbContext _context;
        public CategoryController (EcomDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetCategory")]
        public List<CategoryModel> getAllCategory()
        {
            var data = _context.CategoryModels.ToList();
            return data;
        }

        [HttpPost]
        [Route("PostCategory")]
        public CategoryModel AddNew(CategoryModel obj)
        {
            _context.CategoryModels.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        [HttpPut]
        [Route("PutCategory")]
        public CategoryModel Update(CategoryModel obj , int id)
        {
            var data = _context.CategoryModels.SingleOrDefault(m => m.categoryId == id);
            data.categoryName = obj.categoryName;
            data.categoryLogo = obj.categoryLogo;
            _context.SaveChanges();
            return data;        
        }
    }
}