using System.ComponentModel.DataAnnotations;

namespace Infrastructure.DataModels
{
    public class LoginUserDataModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}