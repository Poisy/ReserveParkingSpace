using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace WebUI.Models
{
    public class RegisterUserDataModel : User, IRegisterViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords must match!")]
        public string ConfirmPassword { get; set; }
    }
}