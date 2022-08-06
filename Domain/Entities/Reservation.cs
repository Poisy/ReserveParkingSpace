using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1, 20)]
        public int Space { get; set; }

        [Required]
        public Guid By { get; set; }

        [Required]
        public DateTime From { get; set; }

        [Required]
        public DateTime To { get; set; }

        [Required]
        [Range(1, 3)]
        public int Shift { get; set; }


        [NotMapped]
        public User User { get; set; }
    }
}