using System.Linq;
using Domain.Entities;
using Domain.Seeds;
using Infrastructure.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            var users = UserSeed.Generate();
            var identityUsers = IdentityUserSeed.Generate(users);

            builder.Entity<IdentityUser>().HasData(identityUsers);
        }
    }
}