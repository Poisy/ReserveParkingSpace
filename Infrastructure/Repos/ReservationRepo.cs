using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repos
{
    /// <summary> Repository which talks with <see cref="ParkingDbContext"/>
    /// and controls the reservations. </summary>
    public class ReservationRepo
    {
        //=============================================================================================
        private readonly ParkingDbContext _db;

        
        
        //=============================================================================================
        public ReservationRepo(ParkingDbContext dbContext)
        {
            _db = dbContext;
        }

        
        
        //=============================================================================================
        /// <summary> Inserts new reservation into the database. </summary>
        /// <param name="reservation">The new reservation. <br/> !! All properties need to be filled !!</param>
        public async Task AddAsync(Reservation reservation)
        {
            await _db.Reservations.AddAsync(reservation);
            
            await _db.SaveChangesAsync();
        }

        
        
        //=============================================================================================
        /// <summary> Gets reservation from the database by a Id. </summary>
        /// <param name="id">Non-nullable id of the reservation.</param>
        public async Task<Reservation> GetAsync(Guid id)
        {
            return await _db.Reservations.FirstOrDefaultAsync(reservation => reservation.Id == id);
        }

        
        
        //=============================================================================================
        /// <summary> Gets all reservations from the database. </summary>
        public IQueryable<Reservation> GetAll()
        {
            return _db.Reservations;
        }

        
        
        //=============================================================================================
        /// <summary> Gets reservation from the database by a Id of the <see cref="User"/>. </summary>
        /// <param name="userId">Non-nullable id of the <see cref="User"/>.</param>
        public async Task<Reservation> GetByUserId(Guid userId)
        {
            return await _db.Reservations.FirstOrDefaultAsync(reservation => reservation.By == userId);
        }

        
        
        //=============================================================================================
        /// <summary> Deletes reservation from the database by reference. </summary>
        /// <param name="reservation">Non-nullable <see cref="Reservation"/>.</param>
        public async Task DeleteAsync(Reservation reservation)
        {
            _db.Remove(reservation);

            await _db.SaveChangesAsync();
        }
    }
}