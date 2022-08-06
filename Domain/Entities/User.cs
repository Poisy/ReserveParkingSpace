using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [Display(Name = "Потребителско име", Prompt = "Потребителско име")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Потребителското име трябва да е между 3 и 25 символа!")]
        public string Username { get; set; }
        
        [Required]
        [Display(Name = "Име", Prompt = "Име")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Първото име трябва да е между 2 и 25 символа!")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия", Prompt = "Фамилия")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Фамилното име трябва да е между 2 и 25 символа!")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Отдел", Prompt = "Отдел")]
        [MaxLength(25, ErrorMessage = "Името на отдела е твърде голямо!")]
        public string Departure { get; set; }
    }
}