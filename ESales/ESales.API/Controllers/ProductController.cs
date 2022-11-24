using ESales.Business.Interfaces;
using ESales.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ESales.API.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("api/product/getall")]
        public IActionResult GetAll()
        {
            var productsList = _productService.GetAll();
            return Ok(productsList);
        }

        [HttpGet("api/product/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            return Ok(product);
        }

        [HttpPost("api/product/add")]
        public IActionResult Add(Product product)
        {
            var products = _productService.Insert(product);
            return Ok(products);
        }

        [HttpPut("api/product/update")]
        public IActionResult Update(Product product)
        {
            var products = _productService.Update(product);
            return Ok(products);
        }

        [HttpDelete("api/product/delete")]
        public IActionResult Delete(Product product)
        {
             _productService.Delete(product);
            return Ok(product);
        }
    }
}
