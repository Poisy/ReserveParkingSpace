using System.Linq;
using Domain.Entities;
using Domain.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    /// <summary> DbContext which directly communicates with the ParkingApp database. </summary>
    public class ParkingDbContext : DbContext
    {
        //=============================================================================================
        /// <summary> Represents the Users table in the database. </summary>
        public DbSet<User> Users { get; set; }

        /// <summary> Represents the Reservations table in the database. </summary>
        public DbSet<Reservation> Reservations { get; set; }
        
        
        
        //=============================================================================================
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {
            
        }
        
        
        
        //=============================================================================================
        /// <summary> Seeds a users and reservations in the database. <br/>
        /// Comment this method to avoid it if you desire.</summary>
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