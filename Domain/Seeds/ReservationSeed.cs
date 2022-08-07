using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Seeds
{
    /// <summary> Class for generating <see cref="Reservation"/> objects. </summary>
    public class ReservationSeed
    {
        //=============================================================================================
        private static Random Random { get; set; }

        
        
        //=============================================================================================
        /// <summary> Generates <see cref="Reservation"/> objects. </summary>
        /// <param name="users">Users who make the reservations.</param>
        /// <param name="count">The number of generated reservations.</param>
        /// <returns><see cref="IEnumerable{T}"/> which contains the reservations.</returns>
        public static IEnumerable<Reservation> Generate(List<User> users, int count = 50)
        {
            Random = new Random();
            
            var reservations = new List<Reservation>();

            while (reservations.Count < count)
            {
                var user = users[Random.Next(0, 50)];
                int rndDay1 = Random.Next(0, 31);
                int rndDay2 = Random.Next(0, 31);

                while ((rndDay1 = Random.Next(0, 31)) < (rndDay2 = Random.Next(0, 31)))
                {
                    var reservation = new Reservation
                    {
                        Id = Guid.NewGuid(), Space = Random.Next(1, 21), Shift = Random.Next(1, 4), By = user.Id,
                        From = DateTime.Today.AddDays(rndDay1),
                        To = DateTime.Today.AddDays(rndDay2)
                    };
                    
                    switch (reservation.Shift)
                    {
                        case 1:
                            reservation.From = reservation.From.AddHours(8);
                            reservation.To = reservation.To.AddHours(14);
                            break;
                        case 2:
                            reservation.From = reservation.From.AddHours(14);
                            reservation.To = reservation.To.AddHours(21);
                            break;
                        case 3:
                            reservation.From = reservation.From.AddHours(9).AddMinutes(30);
                            reservation.To = reservation.To.AddHours(18).AddMinutes(30);
                            break;
                    }

                    if (IsValid(reservations, reservation))
                    {
                        reservations.Add(reservation);
                    }

                    break;
                }
            }
            
            return reservations;
        }
        

        
        //=============================================================================================
        /// <summary> Checks if reservation is a valid and is not in conflict with other reservations. </summary>
        private static bool IsValid(IEnumerable<Reservation> res,  Reservation reservation)
        {
            // Excludes outdated reservations
            var reservations = res.Where(res => res.To >= DateTime.Today);

            // Reservation is invalid if the user already has made up a reservation
            if (reservations.Any(res => res.By == reservation.By)) return false;
            
            // Reservations for the current space
            reservations = reservations.Where(res => res.Space == reservation.Space);

            // Different shifts have different rules
            // Shift 3: can't conflict with 1, 2 and 3
            // Shift 2: can't conflict with 2 and 3
            // Shift 1: can't conflict with 1 and 3
            switch (reservation.Shift)
            {
                case 3:
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        return false;
                    }

                    break;
                case 2:
                    reservations = reservations.Where(res => res.Shift != 1);
                        
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        return false;
                    }

                    break;
                case 1:
                    reservations = reservations.Where(res => res.Shift != 2);
                        
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        return false;
                    }

                    break;
            }

            return true;
        }
    }
}