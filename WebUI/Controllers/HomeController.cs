using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        /// <summary> The Action method you route everytime you go to the home page. </summary>
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            model.Shifts = new List<SelectListItem>
            {
                new SelectListItem {Text = "1ва", Value = "1"},
                new SelectListItem {Text = "2ра", Value = "2"},
                new SelectListItem {Text = "Целодневна", Value = "3"}
            };
            model.Shifts[model.Shift-1].Selected = true;
            model.Reservations = new Reservation[2,10];
           

            // Gets all reservations which are for the current date
            var reservations = _reservationService.GetReservationsByDate(model.Date);
            
            // Gets all reservations which are for the current shift
            reservations = reservations.Where(reservation => reservation.Shift == model.Shift);
            
            foreach (var reservation in reservations)
            {
                // Sets the reservation's user
                reservation.User = await _userService.GetAsync(reservation.By);
                
                // Sets the reservation in a matrix (2x10) to represent the parking lot
                model.Reservations[(reservation.Space - 1) / 10, (reservation.Space - 1) % 10] = reservation;
            }

            return View(model);
        }

        /// <summary> Action method where you can submit a new reservation </summary>
        [HttpPost]
        public async Task<IActionResult> Reserve(ReservationViewModel viewModel)
        {
            var resultModel = new IndexViewModel
            {
                Date = viewModel.From,
                Shift = viewModel.Shift
            };


            if (!User.Identity.IsAuthenticated)
            {
                resultModel.Errors.Add("Трябва да си влязал в профила си за да запазиш място!");
            }
            else if (ModelState.IsValid)
            {
                var reservation = viewModel.Model(new Guid(_userManager.GetUserId(User)));
                
                if ((viewModel.To - viewModel.From).Days > 2)
                {
                    if (viewModel.Schedule is null)
                    {
                        resultModel.Errors.Add("Трябва да се прикачи документ за график (pdf)!");
                    }
                    else
                    {
                        // TODO: Check the file and upload it to the project storage
                        
                    }
                }

                try
                {
                    await _reservationService.TryAddAsync(reservation);
                }
                catch (UserAlreadyReservedException)
                {
                    resultModel.Errors.Add("Вече имате едно запазено място, не може да имате повече!");
                }
                catch (SpaceAlreadyTakenException)
                {
                    resultModel.Errors.Add("Това място е вече заето от някой! Моля опитайте с друго или друг период от време.");
                }
            }
            else
            {
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        resultModel.Errors.Add(error.ErrorMessage);
                    }
                }
            }
            
            return RedirectToAction("Index", resultModel);
        }

        public IActionResult RemoveReservation()
        {
            
            
            throw new NotImplementedException();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}