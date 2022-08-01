using System;
using System.ComponentModel.DataAnnotations;

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
    }
}