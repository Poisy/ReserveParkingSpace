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

        public async Task Add(User user)
        {
            await _usersRepo.AddAsync(user);
        }

        public async Task<User> Get(Guid id)
        {
            var user = await _usersRepo.GetAsync(id);

            return user;
        }
    }
}