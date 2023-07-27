using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Services.Abstractions.Products;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusinessAutomationApp.Controllers.APIControllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService; 
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/products/getAllProducts
       
        [HttpGet()]
        public IActionResult Get([FromQuery] ProductSearchCriteria searchCriteria)
        {
            var products = _productService.SearchProduct(searchCriteria);

            if(products == null || products.Count == 0)
            {
                return NoContent();
            }

            return Ok(products);
        }

        // GET api/products/5
        // api/products/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetById(id); 

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
