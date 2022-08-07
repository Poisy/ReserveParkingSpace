using System;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Repos;

namespace Infrastructure.Services
{
    public class UserService
    {
        //=============================================================================================
        private readonly UsersRepo _usersRepo;

        
        //=============================================================================================
        public UserService(UsersRepo usersRepo)
        {
            _usersRepo = usersRepo;
        }

        
        
        //=============================================================================================
        /// <summary> Adds new user. </summary>
        /// <param name="user"></param>
        public async Task AddAsync(User user)
        {
            var doesExist = await _usersRepo.ExistByUsername(user.Username);

            if (!doesExist)
            {
                await _usersRepo.AddAsync(user);
            }
        }

        
        
        //=============================================================================================
        /// <summary> Gets a user by a id. </summary>
        /// <param name="id"></param>
        public async Task<User> GetAsync(Guid id)
        {
            return await _usersRepo.GetAsync(id);
        }
    }
}