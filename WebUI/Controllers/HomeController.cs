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
using WebUI.Utils;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        //=============================================================================================
        private readonly UserService _userService;
        private readonly ReservationService _reservationService;
        private readonly UserManager<IdentityUser> _userManager;
        #endregion
        
        
        
        //=============================================================================================
        public HomeController(UserService userService, ReservationService reservationService, 
            UserManager<IdentityUser> userManager)
        {
            _userService = userService;
            _reservationService = reservationService;
            _userManager = userManager;
        }
        
        

        #region Routes
        //=============================================================================================
        /// <summary> The Action method you route everytime you go to the home page. </summary>
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                model.User ??= HttpContext.Items["user"] as User;
                model.UserReservation = await _reservationService.GetReservationByUser(model.User?.Id ?? Guid.Empty);
            }
            
            
            model.Shifts = new List<SelectListItem>
            {
                new SelectListItem {Text = "1ва (08:00 - 14:00)", Value = "1"},
                new SelectListItem {Text = "2ра (14:00 - 21:00)", Value = "2"},
                new SelectListItem {Text = "Целодневна (09:30 - 18:30)", Value = "3"}
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
        
        
        
        //=============================================================================================
        /// <summary> Action method where you can submit a new reservation </summary>
        [HttpPost]
        public async Task<IActionResult> Reserve(ReservationViewModel model)
        {
            var resultModel = new IndexViewModel
            {
                Date = model.From,
                Shift = model.Shift
            };


            if (!User.Identity.IsAuthenticated)
            {
                resultModel.Messages.Add("danger");
                resultModel.Messages.Add("Трябва да си влязал в профила си за да запазиш място!");
            }
            else if (ModelState.IsValid)
            {
                resultModel.User = HttpContext.Items["user"] as User;
                var reservation = model.ToReservation(resultModel.User.Id);
                var isScheduleRequired = (model.To - model.From).Days > 2;
                
                if (isScheduleRequired)
                {
                    if (model.Schedule is null || model.Schedule.Length == 0)
                    {
                        resultModel.Messages.Add("danger");
                        resultModel.Messages.Add("Трябва да се прикачи документ за график (pdf)!");
                        
                        return RedirectToAction("Index", resultModel);
                    }
                    
                    if (model.Schedule.ContentType != "application/pdf")
                    {
                        resultModel.Messages.Add("danger");
                        resultModel.Messages.Add("Файла трябва да е в .pdf формат!");
                            
                        return RedirectToAction("Index", resultModel);
                    }
                }
            
                try
                {
                    await _reservationService.TryAddAsync(reservation);
                    
                    resultModel.Messages.Add("success");
                    resultModel.Messages.Add("Успешно запазихте мястото!");

                    if (isScheduleRequired)
                    {
                        await FileManager.SaveSchedule(model.Schedule, resultModel.User);   
                    }
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

        
        
        //=============================================================================================
        /// <summary> Action method where you can submit a reservation to be deleted. </summary>
        [HttpPost]
        public async Task<IActionResult> RemoveReservation(Reservation model)
        {
            var resultModel = new IndexViewModel();
            
            if (model != null && User.Identity.IsAuthenticated)
            {
                resultModel.Date = model.From;
                resultModel.Shift = model.Shift;
                resultModel.User = HttpContext.Items["user"] as User;

                if (model.By == resultModel.User.Id)
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
        #endregion
    }
}