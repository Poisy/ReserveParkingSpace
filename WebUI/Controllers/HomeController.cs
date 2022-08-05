using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Tests.Mock;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _userService;
        private readonly ReservationService _reservationService;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(UserService userService, ReservationService reservationService, 
            UserManager<IdentityUser> userManager)
        {
            _userService = userService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public IActionResult Index(IndexViewModel model)
        {
            model.Shifts = new List<SelectListItem>
            {
                new SelectListItem {Text = "1ва", Value = "1"},
                new SelectListItem {Text = "2ра", Value = "2"},
                new SelectListItem {Text = "Целодневна", Value = "3"}
            };
            
            model.Shifts[model.Shift-1].Selected = true;
            
            if (MockReservation.Reservations.Count == 0)
            {
                new MockReservation(new MockUsers()).Populate();

                var Reservations = MockReservation.Reservations;
            }

            var reservs = MockReservation.Reservations;
            
            
            

            // Gets all reservations which are for the current date and the current shift
            reservs = reservs.Where(reservation => reservation.From <= model.Date && reservation.To >= model.Date
                && reservation.Shift == model.Shift).ToList();
            
            var reservations = new Reservation[2,10];
            
            reservs.ForEach(reservation => reservations[(reservation.Space-1)/10, (reservation.Space-1)%10] = reservation);

            model.Reservations = reservations;
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Reserve(IndexViewModel model)
        {
            model.Shift = model.NewReservation.Shift;
            model.Date = model.NewReservation.From;
            
            if (ModelState.IsValid)
            {
                var reservation = new Reservation
                {
                    Id = Guid.NewGuid(),
                    Space = model.NewReservation.Space,
                    By = MockUsers.CurrentUser.Id,
                    From = model.NewReservation.From,
                    To = model.NewReservation.To,
                    Shift = model.NewReservation.Shift,
                    User = MockUsers.CurrentUser
                };
                
                // if ((model.NewReservation.To - model.NewReservation.From).Days > 2)
                // {
                //     if (model.NewReservation.Schedule is null)
                //     {
                //         model.Errors.Add("Трябва да се прикачи документ за график (pdf)!");
                //     }
                //     else
                //     {
                //         
                //         
                //         
                //         
                //         
                //     }
                // }

                try
                {
                    MockReservation.TryAddReservation(reservation);
                }
                catch (UserAlreadyReservedException ue)
                {
                    model.Errors.Add("Вече имате едно запазено място, не може да имате повече!");
                }
                catch (SpaceAlreadyTakenException se)
                {
                    model.Errors.Add("Това място е вече заето от някой! Моля опитайте с друго или друг период от време.");
                }
            }
            else
            {
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        model.Errors.Add(error.ErrorMessage);
                    }
                }
            }
            
            return RedirectToAction("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}