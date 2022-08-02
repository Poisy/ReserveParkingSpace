using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Repos;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class ReservationService
    {
        private readonly ReservationRepo _reservationRepo;
        
        
        public ReservationService(ReservationRepo reservationRepo)
        {
            _reservationRepo = reservationRepo;
        }
        
        /// <summary> Adds new reservation. </summary>
        public async Task Add(Reservation reservation)
        {
            await _reservationRepo.AddAsync(reservation);
        }

        /// <summary> Deletes already existing reservation. </summary>
        public async Task Delete(Guid id)
        {
            var reservation = await _reservationRepo.GetAsync(id);

            if (reservation != null)
            {
                await _reservationRepo.DeleteAsync(reservation);
            }
        }

        /// <summary> Returns all reservations that were from the given user. </summary>
        public IEnumerable<Reservation> GetReservationsByUser(Guid userId)
        {
            var reservations = _reservationRepo.GetAll()
                .Where(reservation => reservation.By == userId);

            return reservations;
        }
        
        /// <summary> Returns all reservations that were from the given date. </summary>
        public IEnumerable<Reservation> GetReservationsByDate(DateTime dateTime)
        {
            var reservations = _reservationRepo.GetAll()
                .Where(reservation => reservation.From < dateTime && reservation.To > dateTime);

            return reservations;
        }

        /// <summary> Returns all reservations that were from the given user and are reserved for now. </summary>
        public async Task<Reservation> GetCurrentReservationByUser(Guid userId)
        {
            var reservation = await _reservationRepo.GetAll()
                .FirstOrDefaultAsync(reservation => reservation.By == userId && reservation.From < DateTime.Now && reservation.To > DateTime.Now);

            return reservation;
        }

        /// <summary> Returns all reservations that were reserved for now. </summary>
        public IEnumerable<Reservation> GetCurrentReservations()
        {
            var reservations = _reservationRepo.GetAll()
                .Where(reservation => reservation.From < DateTime.Now && reservation.To > DateTime.Now);

            return reservations;
        }
    }
}