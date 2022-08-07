using System;
using System.ComponentModel.DataAnnotations;
using WebUI.Models;

namespace WebUI.Validation
{
    /// <summary> <see cref="DateTime"/> attribute for validated if its between today and one month far.</summary>
    public class DateRangeAttribute : ValidationAttribute
    {
        //=============================================================================================
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var date = (DateTime)value;
            var minDate = DateTime.Today;
            var maxDate = DateTime.Today.AddMonths(1);

            if (date >= minDate && date <= maxDate)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Невалидна дата!");
        }
    }
}