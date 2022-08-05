using System;
using System.ComponentModel.DataAnnotations;
using WebUI.Models;

namespace WebUI.Validation
{
    public class DateRangeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;
            var minDate = new ReservationModel().MinDate;
            var maxDate = new ReservationModel().MaxDate;

            if (date >= minDate && date <= maxDate)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Невалидна дата!");
        }
    }
}