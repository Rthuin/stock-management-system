using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Stock_Manegement.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;


        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [Authorize]
        public IActionResult Index()
        {
            var adminId = int.Parse(User.FindFirst(ClaimTypes.Sid)?.Value);
            var admin = _adminService.GetAdmin(adminId);
            if (admin != null)
            {
                return View(admin); ;
            }

            else
            {
                return NotFound();
            }
        }

        public IActionResult AdminList()
        {
            var admins = _adminService.GetAllAdmins();
            return View(admins); // AdminList.cshtml'e Admin listesini gönderiyoruz
        }

    }
}
