using System.Linq;
using Domain.Entities;
using Domain.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var users = UserSeed.Generate();
            var reservations = ReservationSeed.Generate(users.ToList());

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Reservation>().HasData(reservations);
        }
    }
}