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
        /// <summary> Start date of which this reservation is valid. </summary>
        [Required]
        [DateRange]
        public DateTime From { get; set; }

        
        /// <summary> End date of which this reservation is valid. </summary>
        [Required]
        [DateRange]
        [GreaterThanOrEqualTo("From", ErrorMessage = "Или си сбъркал датите или си пробваш да пътуваш назад във времето!")]
        [LessThanOrEqualTo("MaxReservationDate", ErrorMessage = "Не може да се резервира място за повече от една седмица!")]
        public DateTime To { get; set; }
        
        
        /// <summary> Space which the reservation is for. </summary>
        [Required]
        [Range(1, 20, ErrorMessage = "Мястото може да е единствено от 1 до 20!")]
        public int Space { get; set; }

        
        /// <summary> Time of which this reservation is valid:<br/>
        ///1 -> 08:00 - 14:00<br/>
        ///2 -> 14:00 - 21:00<br/>
        ///3 -> 09:30 - 18:30
        /// </summary>
        [Required]
        [Range(1, 3, ErrorMessage = "Трябва да се избере смяна (период на резервация)!")]
        public int Shift { get; set; }  

        
        /// <summary> The pdf file that needs to be uploaded if the reservation is for more than 2 days. </summary>
        public IFormFile Schedule { get; set; }


        /// <summary> The end date to which you can reserve space. </summary>
        public DateTime MaxReservationDate => From.AddDays(7);


        /// <summary> Converts this object to <see cref="Reservation"/>. </summary>
        /// <param name="userId">Id of the user who has made the reservation.</param>
        public Reservation ToReservation(Guid userId)
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