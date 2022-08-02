using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repos
{
    public class ReservationRepo
    {
        private readonly ParkingDbContext _db;

        public ReservationRepo(ParkingDbContext dbContext)
        {
            _db = dbContext;
        }

        public async Task Add(Reservation reservation)
        {
            await _db.Reservations.AddAsync(reservation);
            
            await _db.SaveChangesAsync();
        }

        public async Task<Reservation> Get(Guid id)
        {
            return await _db.Reservations.FirstOrDefaultAsync(reservation => reservation.Id == id);
        }

        public IQueryable<Reservation> GetAll()
        {
            return _db.Reservations;
        }

        public async Task Delete(Reservation reservation)
        {
            _db.Remove(reservation);

            await _db.SaveChangesAsync();
        }
    }
}