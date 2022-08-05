using System;
using System.ComponentModel.DataAnnotations;
using FoolProof.Core;
using Microsoft.AspNetCore.Http;
using WebUI.Validation;

namespace WebUI.Models
{
    public class ReservationModel
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


        public DateTime MinDate { get; } = DateTime.Today;

        public DateTime MaxDate { get; } = DateTime.Today.AddMonths(1);


        public DateTime MaxReservationDate => From.AddDays(7);
    }
}