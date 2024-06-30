using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Stock_Manegement.Controllers
{
    public class UserRegisterController : Controller
    {
        private readonly IUserService _userService;


        public UserRegisterController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User p)
        {
            UserValidator validationRules = new UserValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                p.IsApproved = false;
                _userService.UserAdd(p);
                return RedirectToAction("RegistrationPending", "UserRegister");
            }
            else
            {
                foreach(var item  in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();

            }
        }
        public IActionResult RegistrationPending()
        {
            return View();
        }
    }
}
