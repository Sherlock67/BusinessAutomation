using BusinessAutomation.Database;
using BusinessAutomation.Models.EntityModels;
using BusinessAutomation.Models.UtilitiesModels.ProductSearch;
using BusinessAutomation.Repositories;
using BusinessAutomation.Repositories.Abstractions.Products;
using BusinessAutomation.Services.Abstractions.Products;
using BusinessAutomationApp.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusinessAutomationApp.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
      

        public ProductController(IProductService productService)
        {
            _productService = productService;
          
        }

        public IActionResult Index(ProductIndex model)
        {
            ICollection<Product> products = new List<Product>();

            if (model.SearchKey != null)
            {
                var productSearchCriteria = new ProductSearchCriteria()
                {
                    SearchKey = model.SearchKey
                };
                products = _productService.SearchProduct(productSearchCriteria); 
            }
            else
            {
               products = _productService.GetAll();
            } 
                
               

            //for each 
            //LINQ
            //Automapper
            model.ProductList = products.Select(c=> new ProductListItem()
            {
                Id = c.Id,
                Name = c.Name, 
                Description = c.Description,
                SalesPrice = c.SalesPrice
            }).ToList(); 

            return View(model);
        }


        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(ProductCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    Name = model.Name, 
                    Description = model.Description, 
                    SalesPrice = model.SalesPrice
                };

                bool isSuccess = _productService.Add(product);
                if (isSuccess)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(model);

        }


        // product/edit?id=8
        public IActionResult Edit(int? id)
        {
            if(id==null)
            {
                ViewBag.ErrorMessage = "Id is not set for the product!";
                return View("_ApplicationError");
            }
            var existingProduct = _productService.GetById((int)id);

            if (existingProduct == null)
            {
                ViewBag.ErrorMessage = $"Did not find any product with Id {id}";

                return View("_ApplicationError");
            }

            var productEditVm = new ProductEditVM()
            {
                Id = existingProduct.Id,
                Name = existingProduct.Name,
                Description = existingProduct.Description,
                SalesPrice = existingProduct.SalesPrice
            };

            return View(productEditVm);


        }

        [HttpPost]
        public IActionResult Edit(ProductEditVM model)
        {
            return null; 
        }
    }
}
