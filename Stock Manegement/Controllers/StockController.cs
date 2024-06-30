using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Stock_Manegement.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        public IActionResult Index()
        {
            var values = _stockService.GetAllStocksWithProductAndAdmin();
            return View(values);
        }
    }
}
