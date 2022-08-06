using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using FoolProof.Core;
using Microsoft.AspNetCore.Http;
using WebUI.Validation;

namespace WebUI.Models
{
    public class ReservationViewModel
    {
        [Required]
        [DateRange]
        public DateTime From { get; set; }

        [Required]
        [DateRange]
        [GreaterThanOrEqualTo("From", ErrorMessage = "Или си сбъркал датите или си пробваш да пътуваш назад във времето!")]
        [LessThanOrEqualTo("MaxReservationDate", ErrorMessage = "Не може да се резервира място за повече от една седмица!")]
        public DateTime To { get; set; }
        
        [Required]
        [Range(1, 20, ErrorMessage = "Мястото може да е единствено от 1 до 20!")]
        public int Space { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Трябва да се избере смяна (период на резервация)!")]
        public int Shift { get; set; }  

        public IFormFile Schedule { get; set; }


        public DateTime MaxReservationDate => From.AddDays(7);


        public Reservation Model(Guid userId)
        {
            var model = new Reservation
            {
                Id = Guid.NewGuid(),
                Space = Space,
                By = userId,
                Shift = Shift
            };

            switch (Shift)
            {
                case 1:
                    model.From = From.AddHours(8);
                    model.To = To.AddHours(14);
                    break;
                case 2:
                    model.From = From.AddHours(14);
                    model.To = To.AddHours(21);
                    break;
                case 3:
                    model.From = From.AddHours(9).AddMinutes(30);
                    model.To = To.AddHours(18).AddMinutes(30);
                    break;
            }

            return model;
        }
    }
}