using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using КурсовойПроект.Models;

namespace КурсовойПроект.Controllers
{
    [Authorize]
        public class AccountController : Controller
        {
            private readonly UserManager<IdentityUser> userManager;
            private readonly SignInManager<IdentityUser> signInManager;
            public AccountController(UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signinMgr)
            {
                userManager = userMgr;
                signInManager = signinMgr;
            }

        //передаём в качестве модели в представление LoginViewModel
            [AllowAnonymous]
            public IActionResult Login(string returnUrl)
            {
                ViewBag.returnUrl = returnUrl;
                return View(new LoginViewModel());
            }

            [HttpPost]
            [AllowAnonymous]
            public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
            {
                if (ModelState.IsValid)  
                {
                    IdentityUser user = await userManager.FindByNameAsync(model.UserName);// если пользователь ввёл логин и пароль, то дальше пытаемся найти по имени (логину, который указан в моделе)
                if (user != null)
                    {
                        await signInManager.SignOutAsync(); //если пользователь найден, пренудительно делается выход
                        Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                        //в объекте result пытаемся войти по паролю 
                        if (result.Succeeded) // если действие было успешно, мы перенаправляем пользователя по значению returnUrl (где он пытался зайти, либо на главную страницу)
                        {
                            return Redirect(returnUrl ?? "/");
                        }
                    }
                    ModelState.AddModelError(nameof(LoginViewModel.UserName), "Неверный логин или пароль");
                }
                return View(model);
            }

            [Authorize]
            public async Task<IActionResult> Logout()
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
        }
}
