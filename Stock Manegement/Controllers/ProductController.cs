using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Stock_Manegement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.GetAllProducts();
            return View(values);
        }
    }
}
