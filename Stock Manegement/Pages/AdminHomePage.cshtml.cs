using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stock_Manegement.Pages
{
    public class AdminHomePageModel : PageModel
    {
        private readonly IAdminService _adminService;
        private readonly IProductService _productService;
        private readonly IStockService _stockService;
        private readonly IUserService _userService;
      
        public AdminHomePageModel(IAdminService adminService, IProductService productService, IStockService stockService, IUserService userService)
        {
            _adminService = adminService;
            _productService = productService;
            _stockService = stockService;
            _userService = userService;
        }

        public string AdminName { get; set; }
        public List<Product> Products { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<User> Users { get; set; }

        public void OnGet()
        {
            // Yönetici adýný al
            AdminName = "Admin"; // Örnek olarak sabit bir yönetici adý atadým, gerçek uygulamada bu doðru yöntem olmayabilir.

            // Ürünleri ve stoklarý getir
            Products = _productService.GetAllProducts();
            Stocks = _stockService.GetAllStocksWithProductAndAdmin();

            // Kullanýcýlarý getir
            Users = _userService.GetAllUsers();
        }
    }
}
