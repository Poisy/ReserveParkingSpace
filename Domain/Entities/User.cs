using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "First name length should be in range 2 - 25!")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Last name length should be in range 2 - 25!")]
        public string LastName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Username length should be in range 3 - 25!")]
        public string Username { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Departure name is too long!")]
        public string Departure { get; set; }
    }
}