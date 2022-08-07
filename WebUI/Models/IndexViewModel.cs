using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Models
{
    public class IndexViewModel
    {
        /// <summary> The matrix which represents the parking lot of reservations for the current date, time and shift. </summary>
        public Reservation[,] Reservations { get; set; }

        
        /// <summary> The collection of messages which contains information and waited to be displayed. </summary>
        public List<string> Messages { get; set; } = new List<string>();
    
        
        /// <summary> The date of the showed parking lot. </summary>
        public DateTime Date { get; set; } = DateTime.Today;

        
        /// <summary> The shift of the showed parking lot. </summary>
        public int Shift { get; set; } = 1;

        
        /// <summary> The reservation the current user. <br/>
        /// Null if the user hasn't made reservation or the user is not authenticated.</summary>
        public Reservation UserReservation { get; set; }

        
        /// <summary> The current user. <br/>
        /// Null if the user is not authenticated.</summary>
        public User User { get; set; }

        
        /// <summary> Used for the &lt;select&gt; component for selecting shifts. </summary>
        public List<SelectListItem> Shifts { get; set; }
    }
}