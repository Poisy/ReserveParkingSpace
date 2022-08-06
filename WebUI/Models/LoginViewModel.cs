using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Потребителско име", Prompt = "Потребителско име")]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Парола", Prompt = "Парола")]
        public string Password { get; set; }
    }
}