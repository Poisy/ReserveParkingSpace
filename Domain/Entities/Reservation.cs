using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary> The basic model of a reservation. </summary>
    public class Reservation
    {
        /// <summary> Unique key for the reservation. </summary>
        [Key]
        public Guid Id { get; set; }

        
        /// <summary> Space which this reservation is for. </summary>
        [Required]
        [Range(1, 20)]
        public int Space { get; set; }

        
        /// <summary> Id of the user who created this reservation. </summary>
        [Required]
        public Guid By { get; set; }

        
        /// <summary> Start date of which this reservation is valid. </summary>
        [Required]
        public DateTime From { get; set; }

        
        /// <summary> End date of which this reservation is valid. </summary>
        [Required]
        public DateTime To { get; set; }

        
        /// <summary> Time of which this reservation is valid:<br/>
        ///1 -> 08:00 - 14:00<br/>
        ///2 -> 14:00 - 21:00<br/>
        ///3 -> 09:30 - 18:30
        /// </summary>
        [Required]
        [Range(1, 3)]
        public int Shift { get; set; }
        
        
        /// <summary> The user who created this reservation. </summary>
        [NotMapped]
        public User User { get; set; }
    }
}