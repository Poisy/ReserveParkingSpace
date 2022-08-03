using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserService _userService;

        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, 
            UserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDataModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                    
                var user = new IdentityUser
                {
                    Id = model.Id.ToString(),
                    UserName = model.Username
                };
                    
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    await _userService.Add(model);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View("/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserDataModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, 
                    model.Password, true, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Username or Password are incorrect!");
            }

            return View("/Views/Home/Index.cshtml");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return RedirectToAction("Index", "Home");
        }
    }
}