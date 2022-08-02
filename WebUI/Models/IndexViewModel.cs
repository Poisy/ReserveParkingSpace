using Domain.Entities;
using Infrastructure.DataModels;

namespace WebUI.Models
{
    public class IndexViewModel
    {
        public LoginUserDataModel LoginUserDataModel { get; set; }
        
        public RegisterUserDataModel RegisterUserDataModel { get; set; }
        
        public User User { get; set; }
    }
}