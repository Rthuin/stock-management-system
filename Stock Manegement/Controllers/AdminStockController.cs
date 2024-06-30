using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Stock_Manegement.Controllers
{
    [Authorize]
    public class AdminStockController : Controller
    {
        private readonly IStockService _stockService;
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdminStockController(IHttpContextAccessor httpContextAccessor, IStockService stockService, IProductService productService, IUserService userService)
        {
            _httpContextAccessor = httpContextAccessor;
            _stockService = stockService;
            _productService = productService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Products = new SelectList(_productService.GetAllProducts(), "ProductCode", "ProductName");
            ViewBag.Users = new SelectList(_userService.GetAllUsers(), "UserID", "UserName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Stock stock)
        {
            var adminId = GetCurrentAdminId();
            stock.AdminID = adminId;
            _stockService.StockAdd(stock);
            return RedirectToAction("ShowStocks");
        }
        public IActionResult ShowStocks()
        {
            var stocks = _stockService.GetAllStocksWithProductAndAdmin();
            return View(stocks);
        }

        public IActionResult RemoveStock(int stockId)
        {
            var stock = _stockService.GetStock(stockId);
            if (stock != null)
            {
                _stockService.StockRemove(stock);
                TempData["Message"] = $"{stock.StockCode} kodlu stok silindi.";
                return RedirectToAction("ShowStocks");
            }
            return RedirectToAction("Create");

        }

        private int GetCurrentAdminId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid)?.Value;
            if (userId != null && int.TryParse(userId, out int adminId))
            {
                return adminId;
            }
            // Varsayılan olarak bir hata durumu için -1 veya başka bir işaretçi değeri döndürebilirsiniz
            return -1;
        }
    }
}
