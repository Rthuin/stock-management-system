using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace Stock_Manegement.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly IUserService _userService;
        public AdminPanelController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult PendingUsers()
        {
            var pendingUsers = _userService.GetAllUsers().Where(u => !u.IsApproved).ToList();
            return View(pendingUsers);
        }
        public IActionResult ApprovedUser(int userId)
        {
            var user = _userService.GetUser(userId);
            if (user != null)
            {
                user.IsApproved = true;
                _userService.UserUpdate(user);
                TempData["Message"] = "Kullanıcı başarıyla onaylandı.";
            }
            return RedirectToAction("PendingUsers");
        }

        public IActionResult ShowUsers()
        {
            var users = _userService.GetAllUsers().ToList();
            return View(users);
        }
        public IActionResult DeletePendingUsers(int userId)
        {
            var user = _userService.GetUser(userId);
            if (user != null)
            {
                _userService.UserRemove(user);
                TempData["Message"] = $"{user.UserName} kullanıcısı silindi.";
            }
            return RedirectToAction("PendingUsers");
        }
        public IActionResult DeleteUser(int userId)
        {
            var user = _userService.GetUser(userId);
            if (user != null)
            {
                _userService.UserRemove(user);
                TempData["Message"] = $"{user.UserName} kullanıcısı silindi.";
            }
            return RedirectToAction("ShowUsers");
        }

    }
}
