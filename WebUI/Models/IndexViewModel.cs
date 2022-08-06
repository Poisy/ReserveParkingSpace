using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Models
{
    public class IndexViewModel
    {
        public Reservation[,] Reservations { get; set; }

        public List<string> Messages { get; set; } = new List<string>();
    
        public DateTime Date { get; set; } = DateTime.Today;

        public int Shift { get; set; } = 1;

        public User User { get; set; }

        public List<SelectListItem> Shifts { get; set; }
    }
}