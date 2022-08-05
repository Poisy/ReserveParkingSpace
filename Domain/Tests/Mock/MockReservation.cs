using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Exceptions;

namespace Domain.Tests.Mock
{
    public class MockReservation
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Reservation> Reservations { get; set; } = new List<Reservation>();

        private Random _random;


        public MockReservation(MockUsers mock)
        {
            Users = mock.GetUsers();
            _random = new Random();
        }

        public void Populate()
        {
            Reservations = new List<Reservation>();

            while (Reservations.Count < 50)
            {
                var user = Users[_random.Next(0, 50)];
                int rndDay1 = _random.Next(0, 31);
                int rndDay2 = _random.Next(0, 31);

                while ((rndDay1 = _random.Next(0, 31)) < (rndDay2 = _random.Next(0, 31)))
                {
                    var reservation = new Reservation
                    {
                        Id = Guid.NewGuid(), Space = _random.Next(1, 21), Shift = _random.Next(1, 4), By = user.Id, User = user,
                        From = DateTime.Today.AddDays(rndDay1),
                        To = DateTime.Today.AddDays(rndDay2)
                    };

                    try
                    {
                        TryAddReservation(reservation);
                    }
                    catch { }

                    break;
                }
            }
        }
        

        public static void TryAddReservation(Reservation reservation)
        {
            // Gets only the current reservations and removes the outdated
            var reservations = Reservations.Where(res => res.To >= DateTime.Today);
                    
            // Check if the user already have any reservation, if so he is unable to make a second one,
            // only one reservation at time is possible
            if (reservations.Any(res => res.By == reservation.By))
            {
                throw new UserAlreadyReservedException();
            }
            
            // Only get the reservations for that space
            reservations = reservations.Where(res => res.Space == reservation.Space);

            switch (reservation.Shift)
            {
                case 3:
                    // Check if the date range conflicts with other reservation
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        throw new SpaceAlreadyTakenException();
                    }

                    break;
                case 2:
                    // Gets all reservations where shift is 2 or 3
                    reservations = reservations.Where(res => res.Shift != 1);
                        
                    // Check if the date range conflicts with other reservation
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        throw new SpaceAlreadyTakenException();
                    }

                    break;
                case 1:
                    // Gets all reservations where shift is 1 or 3
                    reservations = reservations.Where(res => res.Shift != 2);
                        
                    // Check if the date range conflicts with other reservation
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        throw new SpaceAlreadyTakenException();
                    }

                    break;
            }
            
            Reservations.Add(reservation);
        }
    }
}