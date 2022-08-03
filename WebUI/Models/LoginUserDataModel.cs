using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class LoginUserDataModel : ILoginViewModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}