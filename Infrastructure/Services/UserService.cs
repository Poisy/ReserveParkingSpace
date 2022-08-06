using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Repos;

namespace Infrastructure.Services
{
    public class UserService
    {
        private readonly UsersRepo _usersRepo;

        public UserService(UsersRepo usersRepo)
        {
            _usersRepo = usersRepo;
        }

        public async Task AddAsync(User user)
        {
            await _usersRepo.AddAsync(user);
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _usersRepo.GetAsync(id);
        }
    }
}