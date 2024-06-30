using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Stock_Manegement.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly IProductService _productService;
        public AdminProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            _productService.ProductAdd(p);
            return RedirectToAction("ShowProducts");


        }

        public IActionResult ShowProducts()
        {
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult RemoveProduct(int productId)
        {
            var product = _productService.GetProduct(productId);
            if (product != null)
            {
                _productService.ProductRemove(product);
                TempData["Message"] = $"{product.ProductName} isimli urun silindi.";
                return RedirectToAction("ShowProducts");
            }
            return RedirectToAction("Create");

        }
    }
}

