using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;
using Infrastructure.Repos;

namespace Infrastructure.Services
{
    public class ReservationService
    {
        //=============================================================================================
        private readonly ReservationRepo _reservationRepo;
        
        
        //=============================================================================================
        public ReservationService(ReservationRepo reservationRepo)
        {
            _reservationRepo = reservationRepo;
        }
        
        
        
        //=============================================================================================
        /// <summary> Tries to add new reservation. </summary>
        /// <param name="reservation">The new reservation.</param>
        /// <exception cref="Domain.Exceptions.UserAlreadyReservedException"> If the current user already have reservation. </exception>
        /// <exception cref="Domain.Exceptions.SpaceAlreadyTakenException"> If the space is already been taken by other user. </exception>
        public async Task TryAddAsync(Reservation reservation)
        {
            // Excludes outdated reservations
            var reservations = _reservationRepo.GetAll().Where(res => res.To >= DateTime.Today);
                    
            // Reservation is invalid if the user already has made up a reservation
            if (reservations.Any(res => res.By == reservation.By))
            {
                throw new UserAlreadyReservedException();
            }
            
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
                        throw new SpaceAlreadyTakenException();
                    }

                    break;
                case 2:
                    reservations = reservations.Where(res => res.Shift != 1);
                        
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        throw new SpaceAlreadyTakenException();
                    }

                    break;
                case 1:
                    reservations = reservations.Where(res => res.Shift != 2);
                        
                    if (!reservations.All(res => (res.To < reservation.From) || (res.From > reservation.To)))
                    {
                        throw new SpaceAlreadyTakenException();
                    }

                    break;
            }

            await _reservationRepo.AddAsync(reservation);
        }

        
        
        //=============================================================================================
        /// <summary> Deletes reservation if exists by id. </summary>
        /// <param name="id">Id of the reservation.</param>
        public async Task DeleteAsync(Guid id)
        {
            var reservation = await _reservationRepo.GetAsync(id);

            if (reservation != null)
            {
                await _reservationRepo.DeleteAsync(reservation);
            }
        }
        
        
        
        //=============================================================================================
        /// <summary> Returns all reservations that were from the given date. </summary>
        public IEnumerable<Reservation> GetReservationsByDate(DateTime dateTime)
        {
            var reservations = _reservationRepo.GetAll().AsEnumerable()
                .Where(reservation =>
                {
                    var date = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
                    var from = new DateTime(reservation.From.Year, reservation.From.Month, reservation.From.Day);
                    var to = new DateTime(reservation.To.Year, reservation.To.Month, reservation.To.Day);

                    return from <= date && to >= date;
                });

            return reservations;
        }

        
        
        //=============================================================================================
        public async Task<Reservation> GetReservationByUser(Guid userId)
        {
            return await _reservationRepo.GetByUserId(userId);
        }
    }
}