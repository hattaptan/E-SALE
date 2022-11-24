using ESales.Business.Interfaces;
using ESales.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ESales.API.Controllers
{
    [ApiController]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryServie;
        private IProductService _productService;
         
        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
             _categoryServie = categoryService;
            _productService = productService;
        }

        [HttpGet("api/category/getall")]
        public IActionResult GetAll()
        {
            var CategoryList = _categoryServie.GetAll();
            return Ok(CategoryList);
        }

        [HttpGet("api/category/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryServie.GetById(id);
            return Ok(category);
        }

        [HttpPost("api/category/add")]
        public IActionResult Add(Category category )
        {
            var addCategory = _categoryServie.Insert(category);
            return Ok(addCategory);
        }
        [HttpPut("api/category/update")]
        public IActionResult Update(Category category)
        {
            var updateCategory = _categoryServie.Update(category);  
            return Ok(updateCategory);
        }
        [HttpDelete("api/category/delete")]
        public IActionResult Delete(Category category)
        {
             _categoryServie.Delete(category);
            return Ok(category);
        }
        [HttpGet("api/productbycategory/{id}")]
        public IActionResult GetProductBtCategory(int id)
        { 
           var products = _productService.GetAll().Where(x=>x.categoryID.categoryId == id);
           return Ok(products);
        }
    }
}
