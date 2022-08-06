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
            if (User.Identity.IsAuthenticated)
            {
                model.User ??= _userService.GetAsync(new Guid(_userManager.GetUserId(User))).Result;
            }
            
            model.UserReservation = await _reservationService.GetReservationByUser(model.User.Id);
            model.Shifts = new List<SelectListItem>
            {
                new SelectListItem {Text = "1ва", Value = "1"},
                new SelectListItem {Text = "2ра", Value = "2"},
                new SelectListItem {Text = "Целодневна", Value = "3"}
            };
            model.Shift = model.Shift == 0 ? 1 : model.Shift;
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
                resultModel.Messages.Add("danger");
                resultModel.Messages.Add("Трябва да си влязал в профила си за да запазиш място!");
            }
            else if (ModelState.IsValid)
            {
                var reservation = viewModel.Model(new Guid(_userManager.GetUserId(User)));
                
                if ((viewModel.To - viewModel.From).Days > 2)
                {
                    if (viewModel.Schedule is null)
                    {
                        resultModel.Messages.Add("danger");
                        resultModel.Messages.Add("Трябва да се прикачи документ за график (pdf)!");
                    }
                    else
                    {
                        // TODO: Check the file and upload it to the project storage
                        
                    }
                }

                try
                {
                    await _reservationService.TryAddAsync(reservation);
                    
                    resultModel.Messages.Add("success");
                    resultModel.Messages.Add("Успешно запазихте мястото!");
                }
                catch (UserAlreadyReservedException)
                {
                    resultModel.Messages.Add("danger");
                    resultModel.Messages.Add("Вече имате едно запазено място, не може да имате повече!");
                }
                catch (SpaceAlreadyTakenException)
                {
                    resultModel.Messages.Add("danger");
                    resultModel.Messages.Add("Това място е вече заето от някой! Моля опитайте с друго или друг период от време.");
                }
            }
            else
            {
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        resultModel.Messages.Add("danger");
                        resultModel.Messages.Add(error.ErrorMessage);
                    }
                }
            }
            
            return RedirectToAction("Index", resultModel);
        }

        /// <summary> Action method where you can submit a reservation to be deleted. </summary>
        [HttpPost]
        public async Task<IActionResult> RemoveReservation(Reservation model)
        {
            var resultModel = new IndexViewModel();
            
            if (model != null && User.Identity.IsAuthenticated)
            {
                resultModel.Date = model.From;
                resultModel.Shift = model.Shift;
                model.User ??= _userService.GetAsync(new Guid(_userManager.GetUserId(User))).Result;

                if (model.By == model.User.Id)
                { 
                    await _reservationService.DeleteAsync(model.Id);
                    
                    resultModel.Messages.Add("success");
                    resultModel.Messages.Add("Успешно освободихте мястото!");
                }
                else
                {
                    resultModel.Messages.Add("danger");
                    resultModel.Messages.Add("Това не е ваше място!");
                }
            }
            else
            {
                resultModel.Messages.Add("danger");
                resultModel.Messages.Add("Беше изпратена празна форма!");   
            }

            return RedirectToAction("Index", resultModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}