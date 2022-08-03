using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public interface ILoginViewModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}