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



        [HttpGet]
        [Route("GetCategory")]
        public List<CategoryModel> getAllcategory()
        {
            var data = _context.categoryModels.ToList();
            return data;
        }


        [HttpPost]
        [Route("CreateNewCategory")]
        public CategoryModel AddNew(CategoryModel obj)
        {
            _context.categoryModels.Add(obj);
            _context.SaveChanges();
            return obj;
        }
    }

}
