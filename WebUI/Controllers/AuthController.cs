using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.DataModels;
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
        public async Task<IActionResult> Register(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Checking if an user with this name already exists
                var findUser = await _userManager.FindByNameAsync(model.RegisterUserDataModel.Username);
                if (findUser is null)
                {
                    model.RegisterUserDataModel.Id = Guid.NewGuid();
                    
                    var user = new IdentityUser
                    {
                        Id = model.RegisterUserDataModel.Id.ToString(),
                        UserName = model.RegisterUserDataModel.Username
                    };
                    
                    var result = await _userManager.CreateAsync(user, model.RegisterUserDataModel.Password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, false);
                        await _userService.Add(model.RegisterUserDataModel);

                        model.User = model.RegisterUserDataModel;
                        model.LoginUserDataModel = null;
                        model.RegisterUserDataModel = null;
                        
                        return RedirectToAction("Index", "Home", model);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Username", $"'{model.RegisterUserDataModel.Username}' is already taken!");
                }
            }

            return View("/Views/Home/Index.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.LoginUserDataModel.Username, 
                    model.LoginUserDataModel.Password, true, false);

                if (result.Succeeded)
                {
                    

                    return RedirectToAction("Index", "Home");
                }
                
                ModelState.AddModelError("", "Username or Password are incorrect!");
            }

            return View("/Views/Home/Index.cshtml", model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return Redirect("/Home/Index");
        }
    }
}