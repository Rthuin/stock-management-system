using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Stock_Manegement.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly IUserService _userService;
        public UserAccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(string username, string password)
        {
            var user = _userService.GetAllUsers().FirstOrDefault(u => u.UserName == username && u.UserPassword == password && u.IsApproved == true);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Sid, user.UserID.ToString())
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return RedirectToAction("Index", "User");
            }
            else
            {
                // Giriş başarısız, tekrar login sayfasına yönlendir
                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre. Kullanici Onaylanmamis Olabilir");
                return View();
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); // Oturumu sonlandır
            return RedirectToAction("Login", "UserAccount");
        }
    }
}
