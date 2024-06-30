using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Manegement.Controllers
{
    public class AdminAccountController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminAccountController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(); // Admin login formunu göstermek için bir view döndürüyoruz
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var admin = _adminService.GetAllAdmins().FirstOrDefault(a => a.AdminName == username && a.AdminPassword == password);

            if (admin != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.AdminName),
                    new Claim(ClaimTypes.Role, admin.AdminRole),
                    new Claim(ClaimTypes.Sid, admin.AdminID.ToString())
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                // Giriş başarısız, tekrar login sayfasına yönlendir
                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre");
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); // Oturumu sonlandır
            return RedirectToAction("Login", "AdminAccount");
        }
    }
}
