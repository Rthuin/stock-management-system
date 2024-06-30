using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Stock_Manegement.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var userId = int.Parse(User.FindFirst(ClaimTypes.Sid)?.Value);
            var user = _userService.GetUser(userId);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
