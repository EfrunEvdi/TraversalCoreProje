using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous] // Kensini altına yazılan tüm metotların kurallara geçersiz hale getirilmesini sağlar.
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _singInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> singInManager)
        {
            _userManager = userManager;
            _singInManager = singInManager;
        }

        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingUp(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
            };
            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(UserSingInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _singInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area = "Member" });
                }
                else
                {
                    return RedirectToAction("SingIn", "Login");
                }
            }
            return View();
        }
    }
}
