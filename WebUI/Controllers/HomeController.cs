using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserService _userService;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserService userService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userService = userService;
            _userManager = userManager;
        }

        public async  Task<IActionResult> Index(MainViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                var identityUser = await _userManager.FindByNameAsync(User.Identity.Name);
                var user = await _userService.Get(new Guid(identityUser.Id));

                model.Id = user.Id;
                model.Username = user.Username;
                model.FirstName = user.FirstName;
                model.LastName = user.LastName;
                model.Departure = user.Departure;

                model.Password = null;
                model.ConfirmPassword = null;
            }

            return View("/Views/Home/Index.cshtml", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}