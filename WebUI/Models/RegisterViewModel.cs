using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace WebUI.Models
{
    public class RegisterViewModel : User
    {
        [Required]
        [Display(Name = "Парола", Prompt = "Парола")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Потвърди парола", Prompt = "Потвърди парола")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Паролите не съвпадат!")]
        public string ConfirmPassword { get; set; }
    }
}