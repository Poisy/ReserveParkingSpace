using System;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repos
{
    /// <summary> Repository which talks with <see cref="ParkingDbContext"/>
    /// and controls the users. </summary>
    public class UsersRepo
    {
        //=============================================================================================
        private readonly ParkingDbContext _db;

        
        //=============================================================================================
        public UsersRepo(ParkingDbContext dbContext)
        {
            _db = dbContext;
        }

        
        
        //=============================================================================================
        /// <summary> Inserts new user into the database. </summary>
        /// <param name="user">The new user. <br/> !! All properties need to be filled !!</param>
        public async Task AddAsync(User user)
        {
            await _db.Users.AddAsync(user);
            
            await _db.SaveChangesAsync();
        }

        
        
        //=============================================================================================
        /// <summary> Gets user from the database by a Id. </summary>
        /// <param name="id">Non-nullable id of the user.</param>
        public async Task<User> GetAsync(Guid id)
        {
            return await _db.Users.FirstOrDefaultAsync(user => user.Id == id);
        }


        
        //=============================================================================================
        /// <summary> Checks if a user exist with the given username. </summary>
        public async Task<bool> ExistByUsername(string username)
        {
            return await _db.Users.AnyAsync(user => user.Username == username);
        }
    }
}