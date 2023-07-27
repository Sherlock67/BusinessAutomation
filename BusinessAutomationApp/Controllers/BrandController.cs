using BusinessAutomation.Services.Abstractions.Brands;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAutomationApp.Controllers
{
    public class BrandController : Controller
    {
         IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            this._brandService = brandService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
