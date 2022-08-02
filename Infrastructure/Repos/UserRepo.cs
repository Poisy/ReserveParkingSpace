using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repos
{
    public class UsersRepo
    {
        private readonly ParkingDbContext _db;

        public UsersRepo(ParkingDbContext dbContext)
        {
            _db = dbContext;
        }

        public async Task Add(User user)
        {
            await _db.Users.AddAsync(user);
            
            await _db.SaveChangesAsync();
        }

        public async Task<User> Get(Guid id)
        {
            return await _db.Users.FirstOrDefaultAsync(user => user.Id == id);
        }
        
        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }

        public async Task<bool> Exists(string username)
        {
            var user = await _db.Users.FirstOrDefaultAsync(user => user.Username == username);

            return user != null;
        }
    }
}