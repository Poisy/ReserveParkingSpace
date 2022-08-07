using System;
using System.Threading.Tasks;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        #region Fields
        //=============================================================================================
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserService _userService;
        #endregion
        

        
        //=============================================================================================
        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, 
            UserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }



        #region Methods
        //=============================================================================================
        /// <summary> Does nothing but redirects back to the view. </summary>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        
        
        //=============================================================================================
        /// <summary> Does nothing but redirects back to the view. </summary>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        
        
        //=============================================================================================
        /// <summary> Registers new users. </summary>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
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
                    await _userService.AddAsync(model);

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

            return View();
        }

        
        
        //=============================================================================================
        /// <summary> Logs into the account of a user. </summary>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, 
                    model.Password, true, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                
                ModelState.AddModelError("", "Грешно име и парола!");
            }

            return View();
        }

        
        
        //=============================================================================================
        /// <summary> Logs out from the account of the current user. </summary>
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}