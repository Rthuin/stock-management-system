using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Stock_Manegement.Controllers
{
    public class UserStockController : Controller
    {
        private readonly IStockService _stockService;
        private readonly IHttpContextAccessor _httpContextAccessor;
   
        public UserStockController(IStockService stockService, IHttpContextAccessor httpContextAccessor)
        {
            _stockService = stockService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult ShowStock()
        {
            var userId = GetCurrentUserId();
            var stocksByUserId = _stockService.GetAllStocksByUserID(userId);
            return View(stocksByUserId);
        }

        private int GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid)?.Value;
            if (userId != null && int.TryParse(userId, out int UserId))
            {
                return UserId;
            }
            return -1;
        }
    }
}
